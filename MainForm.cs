using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace SafeBroadcast
{
    public partial class MainForm : UIForm
    {
        public MainForm()
        {
            InitializeComponent();

            //检测log文件
            string log_path = Path.Combine(Environment.CurrentDirectory, "aqbcjs.log");
            //如果文件不存在
            if (!File.Exists(log_path))
            {
                File.Create(log_path).Close();

            }
            Log.log("安全播出计时程序运行");

            //设置Tab
            int pageIndex = 1001;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 361459);
            pageIndex = 1002;
            Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[1], 361737);
            pageIndex = 1003;
            Header.SetNodePageIndex(Header.Nodes[2], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[2], 61501);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddPage(new SubForm1());
            AddPage(new SubForm2());
            AddPage(new SubForm3());
            SelectPage(1001);

            //弹出自动加载框
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "sub1.ini")))
            {
                AutoLoad al = new AutoLoad();
                al.ShowDialog();
                if (PublicArgs.is_auto_load)
                {
                    PublicArgs.is_auto_load = false;
                    //向子窗体发送自动加载请求
                    if (SetParamToPage(1001, 0, "自动加载") && SetParamToPage(1002, 0, "自动加载") && SetParamToPage(1003, 0, "自动加载"))
                    {
                        Log.log("配置自动加载成功！");
                        //夜间重启，回收资源，防止卡死
                        if (PublicArgs.is_auto_show)
                        {
                            //线程等待2秒，使主界面加载完成
                            Thread.Sleep(2000);
                            Submit.PerformClick();   //重开展示界面
                        }
                    }
                    else
                    {
                        ShowErrorTip("自动加载失败，部分参数可能存在错误！");
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.log("退出程序");
        }

        //public ShowForm sf;
        private void Submit_Click(object sender, EventArgs e)
        {
            //SetParamToPage
            //可以向指定子页面发送消息
            if (SetParamToPage(1001, 0, "第1屏参数") && SetParamToPage(1002, 0, "第2屏参数") && SetParamToPage(1003, 0, "第3屏参数"))
            {
                //注册自启任务
                register_task();
                ShowForm sf = new ShowForm();
                sf.ShowDialog();
                if (PublicArgs.MyVlc != null)
                {
                    PublicArgs.MyVlc.Stop();
                }
            }
            else
            {
                ShowErrorTip("提示框 - 设置的参数有误");
            }
        }

        private void register_task()
        {
            //1.首先编辑bat脚本(或者使用SCHTASK 修改XML的方式)
            string bat_path = Path.Combine(Environment.CurrentDirectory, "autorestart.bat");
            FileStream fs = new FileStream(bat_path, FileMode.Create);
            //实例化一个StreamWriter-->与fs相关联
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("cd /d " + Environment.CurrentDirectory);
            sw.WriteLine("start SafeBroadcast.exe");
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();

            //因为计划任务cmd方式只支持Hour:Minute，所以程序的自动退出时间需要和计划任务的启动时间区分开
            //将dateTimePicker2.Value设置为程序关闭时间，+1分钟为计划任务自启时间
            DateTime date1 = new System.DateTime(2022, 7, 28, PublicArgs.restart_hour, PublicArgs.restart_min, 00);
            DateTime task_time = date1.AddMinutes(1);
            int task_hour = task_time.Hour;
            int task_min = task_time.Minute;

            //2.使用cmd创建计划任务，绑定为bat脚本
            Process proc = new Process();
            //使用 /f 参数禁止显示确认消息
            string cmd = string.Format(
                "schtasks /create /tn \"{0}\" /tr \"{1}\" /sc DAILY /st {2}:{3} /f", "MySBTask", bat_path, task_hour, task_min);
            Console.WriteLine(cmd);
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");
            string outStr = proc.StandardOutput.ReadToEnd();
            proc.Close();
        }
    }
}
