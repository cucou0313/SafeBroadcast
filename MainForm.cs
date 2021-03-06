using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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

        bool is_restart = false;
        /// <summary>
        /// 在每晚4:15重启显示页面，回收资源防止卡死
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartTimer_Tick(object sender, EventArgs e)
        {
            DateTime now_time = DateTime.Now;
            if (is_restart)
            {
                if (PublicArgs.MyVlc != null)
                {
                    PublicArgs.MyVlc.Stop();
                }
                is_restart = false;
                //重开展示界面
                Submit.PerformClick();
            }
            if (now_time.Hour == 4 && now_time.Minute == 15)
            {
                //遍历所有窗体
                FormCollection childCollection = Application.OpenForms;
                foreach (Form f in childCollection)
                {
                    if (f.Name == "ShowForm")
                    {
                        is_restart = true;
                        f.Close();
                        f.Dispose();
                        break;
                    }
                }
            }
        }
    }
}
