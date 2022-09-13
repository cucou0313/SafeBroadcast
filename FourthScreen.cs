using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBroadcast
{
    public partial class FourthScreen : UIPage
    {
        public FourthScreen()
        {
            InitializeComponent();
            if (PublicArgs.count_down_bg != "")
                bg_pic.Image = Image.FromFile(PublicArgs.count_down_bg);
            else
                bg_pic.Image = null;
            days.Parent = bg_pic;
            days.Location = new Point(700, 680);
            days.Text = count_down();

            status_pic.Parent = bg_pic;
            status_pic.Location = new Point(360, 810);

            status_pic.Visible = PublicArgs.is_use_count_down;
            days.Visible = PublicArgs.is_use_count_down;
        }

        DateTime final_time = PublicArgs.count_down_start_time;
        public string count_down()
        {
            //只取日期进行模糊天数计算，去除小时差的影响
            DateTime now_time = DateTime.Now.Date;
            TimeSpan ts = final_time - now_time;
            if (ts.Days <= 0)
            {
                //小时差为负数表示已开始
                status_pic.Image = Properties.Resources.已进行;
                int start_days = Math.Abs(ts.Days) + 1;
                //单个数字转为两位字符串 "D2"
                return start_days.ToString("D2");
            }
            return ts.Days.ToString("D2");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now_time = DateTime.Now;
            TimeSpan ts = final_time - now_time;
            days.Text = count_down();
        }
    }
}
