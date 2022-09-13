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
    public partial class SubForm4 : UIPage
    {
        public SubForm4()
        {
            InitializeComponent();
            days.Parent = bg_pic;
            days.Location = new Point(680, 450);

            status_pic.Parent = bg_pic;
            status_pic.Location = new Point(450, 540);
        }

        private void uiSwitch1_ActiveChanged(object sender, EventArgs e)
        {
            uiGroupBox2.Visible = uiSwitch1.Active;
            Page4_UpDown.Enabled = uiSwitch1.Active;
            Load_Button.Enabled = uiSwitch1.Active;
            dateTimePicker1.Enabled = uiSwitch1.Active;
            uiSwitch2.Enabled = uiSwitch1.Active;
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
                bg_pic.Image = Image.FromFile(pic_path);
                PublicArgs.count_down_bg = pic_path;
            }
        }

        private void Page4_UpDown_ValueChanged(object sender, int value)
        {
            if (Page4_UpDown.Value <= 0)
            {
                ShowWarningNotifier("第4屏停留时间设置错误！");
            }
            else
            {
                PublicArgs.page_stay[3] = Page4_UpDown.Value;
            }
        }

        string sub4_ini = Path.Combine(Environment.CurrentDirectory, "sub4.ini");
        public override bool SetParam(int fromPageIndex, params object[] objects)
        {
            if (objects.Length == 1)
            {
                string parm_recv = objects[0].ToString();
                if (parm_recv == "第4屏参数")
                {
                    if (Page4_UpDown.Value <= 0)
                        return false;

                    PublicArgs.count_down_start_time = dateTimePicker1.Value;
                    PublicArgs.page_stay[3] = uiSwitch1.Active ? Page4_UpDown.Value : 0;
                    PublicArgs.is_use_count_down = uiSwitch2.Active;

                    //写入当前配置
                    IniFile ini = new IniFile(sub4_ini);
                    //IniFile类支持的数据类型
                    //bool，byte，byte[]，char，Color，Datetime，decimal，double，float，int，
                    //long，Point，PointF，sbyte，short，Size，SizeF，uint，ulong，ushort，Struct*
                    ini.Write("Setup", "IsFourthScreen", uiSwitch1.Active);
                    ini.Write("Setup", "PageStay", Page4_UpDown.Value);
                    ini.Write("Setup", "StartTime", dateTimePicker1.Value);
                    ini.Write("Setup", "BackGround", pic_path);
                    ini.Write("Setup", "IsUseCountDown", uiSwitch2.Active);
                    ini.UpdateFile();

                    return true;
                }
                //加载上次参数
                else if (parm_recv == "自动加载")
                {
                    //读取当前配置
                    IniFile ini = new IniFile(sub4_ini);
                    uiSwitch1.Active = ini.ReadBool("Setup", "IsFourthScreen", false);
                    uiSwitch2.Active = ini.ReadBool("Setup", "IsUseCountDown", true);
                    Page4_UpDown.Value = ini.ReadInt("Setup", "PageStay", 10);
                    dateTimePicker1.Value = ini.ReadDateTime("Setup", "StartTime", dateTimePicker1.Value);
                    PublicArgs.count_down_bg = ini.ReadString("Setup", "BackGround", "");
                    pic_path = PublicArgs.count_down_bg;
                    if (PublicArgs.count_down_bg != "" && !File.Exists(PublicArgs.count_down_bg))
                    {
                        ShowErrorNotifier("无法加载此图片文件！");
                        uiSwitch1.Active = false;
                        return false;
                    }
                    else
                    {
                        bg_pic.Image = Image.FromFile(PublicArgs.count_down_bg);
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

        private void uiSwitch2_ActiveChanged(object sender, EventArgs e)
        {
            status_pic.Visible = uiSwitch2.Active;
            days.Visible = uiSwitch2.Active;
        }
    }
}
