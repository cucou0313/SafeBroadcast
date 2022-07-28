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
using Sunny.UI;

namespace SafeBroadcast
{
    public partial class SubForm1 : UIPage
    {
        public SubForm1()
        {
            InitializeComponent();
            Time_ComboBox.SelectedIndex = 3;

            //检测log文件
            string log_path = Path.Combine(Environment.CurrentDirectory, "aqbcjs.log");
            //如果文件不存在
            if (!File.Exists(log_path))
            {
                File.Create(log_path).Close();

            }
            Log.log("安全播出计时程序运行");

            //检测config文件
            string conf_path = Path.Combine(Environment.CurrentDirectory, "config.txt");
            //如果文件不存在
            if (!File.Exists(log_path))
            {
                ShowWarningNotifier("未检测到可加载的配置文件");
            }
            else
            {
                string[] strArray = File.ReadAllLines(conf_path);
                for (int i = 1; i < 6; i++)
                {
                    for (int j = 1; j < 8; j++)
                    {
                        int row = i;
                        if (i == 2 || i == 3)
                        {
                            row = 2;
                        }
                        else if (i > 3)
                        {
                            row = i - 1;
                        }

                        string ctrl_name = string.Format("day{0}_comboBox{1}", j, i);
                        Control[] cb = uiGroupBox2.Controls.Find(ctrl_name, true);
                        if (cb.Length > 0)
                        {
                            ComboBox tt = cb[0] as ComboBox;
                            //必须动态数据源，不能都赋值同一个，否则多个控件的数据源同一个会联动
                            tt.DataSource = strArray[row].Split(' ');
                        }
                    }
                }
            }
        }

        private void Time_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Time_ComboBox.SelectedIndex)
            {
                case 0:
                    time_label.Text = "30天";
                    break;
                case 1:
                    time_label.Text = "30天24小时";
                    break;
                case 2:
                    time_label.Text = "30天24小时60分";
                    break;
                case 3:
                    time_label.Text = "30天24小时60分60秒";
                    break;
            }
        }

        private void Main_TextBox_TextChanged(object sender, EventArgs e)
        {
            main_label.Text = Main_TextBox.Text;
        }

        private void Main_ColorPicker_ValueChanged(object sender, Color value)
        {
            main_label.ForeColor = Main_ColorPicker.Value;
        }

        private void main_font_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                main_label.Font = fontDialog1.Font;
            }
        }

        private void time_font_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                time_label.Font = fontDialog1.Font;
            }
        }

        private void Time_ColorPicker_ValueChanged(object sender, Color value)
        {
            time_label.ForeColor = Time_ColorPicker.Value;
        }

        private void Duty_ColorPicker_ValueChanged(object sender, Color value)
        {
            duty_label.ForeColor = Duty_ColorPicker.Value;
        }

        string sub1_ini = Path.Combine(Environment.CurrentDirectory, "sub1.ini");
        /// <summary>
        /// 继承的SetParam，可以响应其他页面发送过来的参数
        /// </summary>
        /// <param name="fromPageIndex"></param>
        /// <param name="objects"></param>
        /// <returns></returns>
        public override bool SetParam(int fromPageIndex, params object[] objects)
        {
            if (objects.Length == 1)
            {
                string parm_recv = objects[0].ToString();
                if (parm_recv == "第1屏参数")
                {
                    if (Page1_UpDown.Value <= 0)
                    {
                        return false;
                    }
                    PublicArgs.page_stay[0] = Page1_UpDown.Value;

                    PublicArgs.main_text = Main_TextBox.Text;
                    PublicArgs.main_color = main_label.ForeColor;
                    PublicArgs.main_font = main_label.Font;
                    PublicArgs.time_type = Time_ComboBox.SelectedIndex;
                    PublicArgs.start_time = dateTimePicker1.Value;
                    PublicArgs.time_color = time_label.ForeColor;
                    PublicArgs.time_font = time_label.Font;
                    PublicArgs.is_use_duty = uiSwitch1.Active;
                    //因为计划任务cmd方式只支持Hour:Minute，所以程序的自动退出时间需要和计划任务的启动时间区分开
                    //将dateTimePicker2.Value设置为程序关闭时间，+1分钟为计划任务自启时间
                    PublicArgs.restart_hour = dateTimePicker2.Value.Hour;
                    PublicArgs.restart_min = dateTimePicker2.Value.Minute;

                    if (uiSwitch1.Active)
                    {
                        //保存值班表
                        for (int i = 1; i < 8; i++)
                        {
                            string day_duty = "";
                            for (int j = 1; j < 6; j++)
                            {
                                string ctrl_name = string.Format("day{0}_comboBox{1}", i, j);
                                Control[] cb = uiGroupBox2.Controls.Find(ctrl_name, true);
                                if (cb.Length > 0)
                                {
                                    string context = "";
                                    switch (j)
                                    {
                                        case 1:
                                            context = string.Format("{0}：{1}    ", director_textBox.Text, cb[0].Text);
                                            break;
                                        case 2:
                                            context = string.Format("{0}：{1}, ", tech_textBox.Text, cb[0].Text);
                                            break;
                                        case 3:
                                            context = cb[0].Text;
                                            break;
                                        case 4:
                                            context = string.Format("    {0}：{1}", manager_textBox.Text, cb[0].Text);
                                            break;
                                        case 5:
                                            context = string.Format("   {0}：{1}", editor_textBox.Text, cb[0].Text);
                                            break;
                                    }
                                    day_duty += context;
                                }
                            }
                            PublicArgs.dutys[i - 1] = day_duty;
                        }
                        PublicArgs.duty_text = PublicArgs.day_in_week();
                        PublicArgs.duty_color = duty_label.ForeColor;
                        PublicArgs.duty_font = duty_label.Font;
                    }

                    Log.log(string.Format("开始时间 = {0},主文本 = {1},计时精度 = {2}", PublicArgs.start_time, PublicArgs.main_text, Time_ComboBox.SelectedItem));

                    //写入当前配置
                    IniFile ini = new IniFile(sub1_ini);
                    //IniFile类支持的数据类型
                    //bool，byte，byte[]，char，Color，Datetime，decimal，double，float，int，
                    //long，Point，PointF，sbyte，short，Size，SizeF，uint，ulong，ushort，Struct*
                    ini.Write("Setup", "PageStay", Page1_UpDown.Value);
                    ini.Write("Setup", "MainText", Main_TextBox.Text);
                    ini.Write("Setup", "MainColor", main_label.ForeColor);
                    ini.Write("Setup", "TimeType", Time_ComboBox.SelectedIndex);
                    ini.Write("Setup", "TimeColor", time_label.ForeColor);
                    ini.Write("Setup", "StartTime", dateTimePicker1.Value);
                    ini.Write("Setup", "IsUseDuty", uiSwitch1.Active);
                    ini.Write("Setup", "RestartTime", dateTimePicker2.Value);
                    //for (int i = 0; i < PublicArgs.dutys.Length; i++)
                    //{
                    //    ini.Write("Setup", "DutyDay" + i, PublicArgs.dutys[i]);
                    //}
                    for (int i = 1; i < 6; i++)
                    {
                        for (int j = 1; j < 8; j++)
                        {
                            int row = i;
                            if (i == 2 || i == 3)
                            {
                                row = 2;
                            }
                            else if (i > 3)
                            {
                                row = i - 1;
                            }

                            string ctrl_name = string.Format("day{0}_comboBox{1}", j, i);
                            Control[] cb = uiGroupBox2.Controls.Find(ctrl_name, true);
                            if (cb.Length > 0)
                            {
                                ComboBox tt = cb[0] as ComboBox;
                                ini.Write("Setup", ctrl_name, tt.Text);
                            }
                        }
                    }
                    ini.Write("Setup", "DutyColor", duty_label.ForeColor);
                    ini.UpdateFile();

                    return true;
                }
                //加载上次参数
                else if (parm_recv == "自动加载")
                {
                    //读取当前配置
                    IniFile ini = new IniFile(sub1_ini);
                    Page1_UpDown.Value = ini.ReadInt("Setup", "PageStay", 60);
                    Main_TextBox.Text = ini.ReadString("Setup", "MainText", "安全播出无事故累计");
                    main_label.ForeColor = ini.ReadColor("Setup", "MainColor", main_label.ForeColor);
                    Main_ColorPicker.Value = main_label.ForeColor;
                    Time_ComboBox.SelectedIndex = ini.ReadInt("Setup", "TimeType", 3);
                    time_label.ForeColor = ini.ReadColor("Setup", "TimeColor", time_label.ForeColor);
                    Time_ColorPicker.Value = time_label.ForeColor;
                    dateTimePicker1.Value = ini.ReadDateTime("Setup", "StartTime", dateTimePicker1.Value);
                    uiSwitch1.Active = ini.ReadBool("Setup", "IsUseDuty", true);
                    dateTimePicker2.Value = ini.ReadDateTime("Setup", "RestartTime", dateTimePicker2.Value);
                    for (int i = 1; i < 6; i++)
                    {
                        for (int j = 1; j < 8; j++)
                        {
                            int row = i;
                            if (i == 2 || i == 3)
                            {
                                row = 2;
                            }
                            else if (i > 3)
                            {
                                row = i - 1;
                            }

                            string ctrl_name = string.Format("day{0}_comboBox{1}", j, i);
                            Control[] cb = uiGroupBox2.Controls.Find(ctrl_name, true);
                            if (cb.Length > 0)
                            {
                                ComboBox tt = cb[0] as ComboBox;
                                tt.Text = ini.ReadString("Setup", ctrl_name, tt.Text);
                            }
                        }
                    }
                    duty_label.ForeColor = ini.ReadColor("Setup", "DutyColor", duty_label.ForeColor);
                    Duty_ColorPicker.Value = duty_label.ForeColor;
                    return true;
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

        private void Page1_UpDown_ValueChanged(object sender, int value)
        {
            if (Page1_UpDown.Value <= 0)
            {
                ShowWarningNotifier("第一屏停留时间设置错误！");
            }
            else
            {
                PublicArgs.page_stay[0] = Page1_UpDown.Value;
            }
        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {
            uiGroupBox2.Visible = uiSwitch1.Active;
            duty_label.Visible = uiSwitch1.Active;
            PublicArgs.is_use_duty = uiSwitch1.Active;
            //传值给Sub2页面
            Frame.SetParamToPage(1002, PageIndex, uiSwitch1.Active);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            PublicArgs.restart_hour = dateTimePicker2.Value.Hour;
            PublicArgs.restart_min = dateTimePicker2.Value.Minute;
        }
    }
}
