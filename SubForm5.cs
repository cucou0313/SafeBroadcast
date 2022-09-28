using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBroadcast
{
    public partial class SubForm5 : UIPage
    {
        public SubForm5()
        {
            InitializeComponent();
        }

        private void uiSwitch1_ActiveChanged(object sender, EventArgs e)
        {
            uiGroupBox2.Visible = uiSwitch1.Active;
            Page5_UpDown.Enabled = uiSwitch1.Active;
            Load_Button.Enabled = uiSwitch1.Active;
        }

        private string pic_path = "";
        private void Load_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择图片类型文件";
            dialog.Filter = "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pic_path = dialog.FileName;
                info_pic.Image = Image.FromFile(pic_path);
                PublicArgs.info_bg = pic_path;
            }
        }

        private void Page5_UpDown_ValueChanged(object sender, int value)
        {
            if (Page5_UpDown.Value <= 0)
            {
                ShowWarningNotifier("第5屏停留时间设置错误！");
            }
            else
            {
                PublicArgs.page_stay[4] = Page5_UpDown.Value;
            }
        }

        string sub5_ini = Path.Combine(Environment.CurrentDirectory, "sub5.ini");
        public override bool SetParam(int fromPageIndex, params object[] objects)
        {
            if (objects.Length == 1)
            {
                string parm_recv = objects[0].ToString();
                if (parm_recv == "第5屏参数")
                {
                    if (Page5_UpDown.Value <= 0)
                        return false;

                    PublicArgs.page_stay[4] = uiSwitch1.Active ? Page5_UpDown.Value : 0;

                    //写入当前配置
                    IniFile ini = new IniFile(sub5_ini);
                    //IniFile类支持的数据类型
                    //bool，byte，byte[]，char，Color，Datetime，decimal，double，float，int，
                    //long，Point，PointF，sbyte，short，Size，SizeF，uint，ulong，ushort，Struct*
                    ini.Write("Setup", "IsFourthScreen", uiSwitch1.Active);
                    ini.Write("Setup", "PageStay", Page5_UpDown.Value);
                    ini.Write("Setup", "BackGround", pic_path);
                    ini.UpdateFile();

                    return true;
                }
                //加载上次参数
                else if (parm_recv == "自动加载")
                {
                    //读取当前配置
                    IniFile ini = new IniFile(sub5_ini);
                    uiSwitch1.Active = ini.ReadBool("Setup", "IsFourthScreen", false);
                    Page5_UpDown.Value = ini.ReadInt("Setup", "PageStay", 10);
                    PublicArgs.info_bg = ini.ReadString("Setup", "BackGround", "");
                    pic_path = PublicArgs.info_bg;
                    if (PublicArgs.info_bg != "" && !File.Exists(PublicArgs.info_bg))
                    {
                        ShowErrorNotifier("无法加载此图片文件！");
                        uiSwitch1.Active = false;
                        return false;
                    }
                    else
                    {
                        if (PublicArgs.info_bg != "")
                            info_pic.Image = Image.FromFile(PublicArgs.info_bg);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
