using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SafeBroadcast
{
    internal class PublicArgs
    {
        public static DateTime start_time;
        public static string main_text, duty_text, header_text, content_text;
        public static int time_type = 3;
        public static Color main_color, time_color, duty_color, header_color, content_color;
        public static Font main_font, time_font, duty_font, header_font, content_font;
        public static HorizontalAlignment header_align = HorizontalAlignment.Center;
        public static string[] dutys = { "", "", "", "", "", "", "" };
        public static string rtf_filepath = "";
        //TXT标题的上间距
        public static int header_top = 10;
        //第一页的停留时间，默认60秒
        //public static int page1_stay = 60;
        //第二页的停留时间
        //public static int page2_stay = 30;
        //是否启用第二屏
        //public static bool is_use_second_screen = false;
        //是否启用排班
        public static bool is_use_duty = true;
        //视频文件地址
        public static string vedio_filepath = "";
        public static int volume = 0;
        public static VlcPlayer.VlcPlayerBase MyVlc = null;
        //各子页的停留时间
        public static int[] page_stay = new int[3];


        /// <summary>
        /// 计算当天为星期几
        /// </summary>
        /// <returns></returns>
        public static string day_in_week()
        {
            //string s1 = "2022-06-13 08:11:11";
            //DateTime now_time = Convert.ToDateTime(s1);
            DateTime now_time = DateTime.Now;
            //DayOfWeek（%7）：  周天 周一...周六 = （0,1,2,3,4,5,6）
            //Console.WriteLine((int)now_time.DayOfWeek);
            int _day = (int)now_time.DayOfWeek - 1;
            if (_day < 0)
            {
                _day = 6;
            }
            //_day：  周一...周六 周天  = （0,1,2,3,4,5,6）
            //Console.WriteLine(_day);
            //每日八点为两天班次的分界点
            int select_day = now_time.Hour >= 8 ? _day : _day - 1;
            //Console.WriteLine(select_day);
            //-1 -2 6
            //周一的八点前，取周天
            if (select_day < 0)
            {
                select_day = 6;

            }
            //Console.WriteLine(select_day);
            return dutys[select_day];
        }

        /// <summary>
        /// 计算时差
        /// </summary>
        /// <returns></returns>
        public static string diff_time()
        {
            DateTime now_time = DateTime.Now;
            TimeSpan ts = now_time - start_time;
            string days = ts.Days.ToString() + "天";
            string hours = ts.Hours.ToString() + "小时";
            string minutes = ts.Minutes.ToString() + "分钟";
            string seconds = ts.Seconds.ToString() + "秒";
            string res = "";
            switch (time_type)
            {
                case 0:
                    res = days;
                    break;
                case 1:
                    res = days + hours;
                    break;
                case 2:
                    res = days + hours + minutes;
                    break;
                case 3:
                    res = days + hours + minutes + seconds;
                    break;
                default:
                    res = days;
                    break;
            }
            return res;
        }
    }
}
