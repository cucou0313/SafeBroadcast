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
            //AddPage(new FirstScreen());
            //if (PublicArgs.is_use_second_screen)
            //{
            //    AddPage(new SecondScreen());
            //}
            //else
            //{
            //    Switch_ProcessBar.Visible = false;
            //}
            //SelectPage(2001);
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
                    }
                }
            }
            SelectPage(2001);
            Switch_ProcessBar.Visible = only_first;
            Switch_ProcessBar.Maximum = PublicArgs.page_stay[0];
            per_sceond_timer.Start();

            ShowCursor(0);
        }

        int duty_update = 0;
        //int page_stay = 0;
        //bool is_first = true;
        int[] stays = new int[PublicArgs.page_stay.Length];
        int page_index = 0;
        private void per_sceond_timer_Tick(object sender, EventArgs e)
        {
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
            }

            //换页
            if (i != page_index)
            {
                if (2001 + i == 2003)
                {
                    PublicArgs.MyVlc.Play();
                }
                else
                {
                    PublicArgs.MyVlc.Stop();
                }
                SelectPage(2001 + i);
                Switch_ProcessBar.Maximum = PublicArgs.page_stay[i];
                Switch_ProcessBar.Value = 0;
                page_index = i;
            }

            //if (PublicArgs.is_use_second_screen)
            //{
            //    //第一屏、第二屏切换
            //    if (is_first)
            //    {
            //        page_stay++;
            //        Switch_ProcessBar.Value = page_stay * 100 / PublicArgs.page1_stay;
            //        if (page_stay > PublicArgs.page1_stay)
            //        {
            //            SelectPage(2002);
            //            page_stay = 0;
            //            Switch_ProcessBar.Value = 0;
            //            is_first = false;
            //        }
            //    }
            //    else
            //    {
            //        page_stay++;
            //        Switch_ProcessBar.Value = page_stay * 100 / PublicArgs.page2_stay;
            //        if (page_stay > PublicArgs.page2_stay)
            //        {
            //            SelectPage(2001);
            //            page_stay = 0;
            //            Switch_ProcessBar.Value = 0;
            //            is_first = true;
            //        }
            //    }
            //}
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 调用Windows API打开或关闭鼠标显示
        /// </summary>
        /// <param name="status"></param>
        [DllImport("user32.dll", EntryPoint = "ShowCursor", CharSet = CharSet.Auto)]
        public extern static void ShowCursor(int status);


        private void ShowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowCursor(1);
        }
    }
}
