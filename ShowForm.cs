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
using System.Runtime.InteropServices;

namespace SafeBroadcast
{
    public partial class ShowForm : UIForm
    {
        public ShowForm()
        {
            InitializeComponent();
            ShowCursor(0);

            bool only_first = false;
            for (int i = 0; i < PublicArgs.page_stay.Length; i++)
            {
                if (PublicArgs.page_stay[i] > 0)
                {
                    switch (i)
                    {
                        case 0:
                            AddPage(new FirstScreen());
                            break;
                        case 1:
                            AddPage(new SecondScreen());
                            only_first = true;
                            break;
                        case 2:
                            AddPage(new ThirdScreen());
                            only_first = true;
                            break;
                        case 3:
                            //二十大倒计时
                            AddPage(new FourthScreen());
                            only_first = true;
                            break;
                        case 4:
                            //重保期发布
                            AddPage(new FifthScreen());
                            only_first = true;
                            break;
                    }
                }
            }
            SelectPage(2001);
            Switch_ProcessBar.Visible = only_first;
            Switch_ProcessBar.Maximum = PublicArgs.page_stay[0];
            per_sceond_timer.Start();
        }

        int duty_update = 0;
        int[] stays = new int[PublicArgs.page_stay.Length];
        int page_index = 0;
        private void per_sceond_timer_Tick(object sender, EventArgs e)
        {
            DateTime now_time = DateTime.Now;
            //到达规定时间后，展示页面直接退出程序
            if (now_time.Hour == PublicArgs.restart_hour && now_time.Minute == PublicArgs.restart_min)
            {
                System.Environment.Exit(0);
            }

            //每十秒计算一次最新排班信息并下发
            if (duty_update++ > 10)
            {
                string duty_content = PublicArgs.day_in_week();
                duty_update = 0;
                //将排班信息向两个子页分发
                SetParamToPage(2001, 0, duty_content);
                SetParamToPage(2002, 0, duty_content);
            }

            stays[page_index]++;
            //Switch_ProcessBar.Maximum = PublicArgs.page_stay[page_index];
            Switch_ProcessBar.Value = stays[page_index];
            //Switch_ProcessBar.Value = stays[page_index] * 100 / PublicArgs.page_stay[page_index];
            int i;
            //依次获取停留时间数组中需要显示的子页
            for (i = 0; i < stays.Length; i++)
            {
                if (stays[i] < PublicArgs.page_stay[i])
                {
                    break;
                }
            }
            //最后一页都超出了，表示需要重头开始，重置数组
            if (i >= stays.Length)
            {
                stays = new int[PublicArgs.page_stay.Length];
                i = 0;
                //重头开始时，也将后台视频关闭
                if (PublicArgs.MyVlc != null)
                {
                    PublicArgs.MyVlc.Stop();
                }
            }

            //换页
            if (i != page_index)
            {
                //换页到了视频页，开始播放
                if (2001 + i == 2003)
                {
                    PublicArgs.MyVlc.Play();
                }

                SelectPage(2001 + i);
                Switch_ProcessBar.Maximum = PublicArgs.page_stay[i];
                Switch_ProcessBar.Value = 0;
                page_index = i;
            }
        }

        /// <summary>
        /// 调用Windows API打开或关闭鼠标显示
        /// </summary>
        /// <param name="status"></param>
        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public extern static void ShowCursor(int status);


        private void ShowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //在主页面进行子页视频关闭操作，直接在子页退出前关闭视频会卡死
            //if (PublicArgs.MyVlc != null)
            //{
            //    PublicArgs.MyVlc.Stop();
            //}
            Console.WriteLine("ShowForm Close");
            per_sceond_timer.Enabled = false;
            ShowCursor(1);
        }
    }
}
