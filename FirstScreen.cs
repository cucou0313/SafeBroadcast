using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace SafeBroadcast
{
    public partial class FirstScreen : UIPage
    {
        public FirstScreen()
        {
            InitializeComponent();
            //mleft_panel.Width = mright_panel.Width = 0;
            //tleft_panel.Width = tright_panel.Width = 0;

            duty_Label.Visible = PublicArgs.is_use_duty;
            duty_Label.ForeColor = PublicArgs.duty_color;
            duty_Label.Text = PublicArgs.day_in_week();

            DateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd dddd");
            Time_LedLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            MainLabel.Text = PublicArgs.main_text;
            TimerLabel.Text = PublicArgs.diff_time();
            MainLabel.Font = PublicArgs.main_font;
            MainLabel.ForeColor = PublicArgs.main_color;
            TimerLabel.Font = PublicArgs.time_font;
            TimerLabel.ForeColor = PublicArgs.time_color;

            StartLabel.Text = " 自 " + PublicArgs.start_time.ToString("yyyy-MM-dd dddd HH:mm:ss") + " 起 ";
        }

        private void per_second_timer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd dddd");
            Time_LedLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            TimerLabel.Text = PublicArgs.diff_time();

            //手动计算文本上下左右居中
            //空余宽度 = 该窗体宽度 - 两边固定最少边距
            int spare = this.Width - this.Padding.Left * 2;
            //Console.WriteLine("spare={0}", spare);
            //空余宽度应大于控件的宽度
            if (spare > MainLabel.Width)
            {
                int a = (spare - MainLabel.Width) / 2;
                mleft_panel.Width = a;
                mright_panel.Width = a;
                //Console.WriteLine("tleft={0}", tleft_panel.Width);
            }
            else
            {
                mleft_panel.Width = 0;
                mright_panel.Width = 0;
            }

            if (spare > TimerLabel.Width)
            {
                int a = (spare - TimerLabel.Width) / 2;
                tleft_panel.Width = a;
                tright_panel.Width = a;
                //Console.WriteLine("hleft={0}", hleft_panel.Width);
            }
            else
            {
                tleft_panel.Width = 0;
                tright_panel.Width = 0;
            }
            //上下居中显示文本
            //Console.WriteLine(" groupBoxEx2.Padding={0}", groupBoxEx2.Padding);
            spare = My_Panel.Height - panel7.Height - panel10.Height - StartLabel.Height;
            My_Panel.Padding = new Padding(0, spare / 3, 0, 0);
        }

        private void FirstScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.log(string.Format("退出计时，本次安全播出持续了{0}", TimerLabel.Text));
        }

        public override bool SetParam(int fromPageIndex, params object[] objects)
        {
            if (objects.Length == 1)
            {
                duty_Label.Text = objects[0].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
