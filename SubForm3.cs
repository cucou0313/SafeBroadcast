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
    public partial class SubForm3 : UIPage
    {
        private VlcPlayer.VlcPlayerBase MyVlc;
        public SubForm3()
        {
            InitializeComponent();
            //加载运行时文件夹的VLC库
            MyVlc = new VlcPlayer.VlcPlayerBase(Path.Combine(Environment.CurrentDirectory, "plugins"));
            //将视频流输出到指定控件的句柄
            MyVlc.SetRenderWindow(VideoPic.Handle.ToInt32());
        }

        private void uiSwitch1_ActiveChanged(object sender, EventArgs e)
        {
            uiGroupBox2.Visible = uiSwitch1.Active;
            Page3_UpDown.Enabled = uiSwitch1.Active;
            Load_Button.Enabled = uiSwitch1.Active;
        }

        private string video_path = "";
        private int video_duration = 0;
        private void Load_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择视频文件";
            dialog.Filter = "MP4(*.mp4)|*.mp4|AVI(*.avi)|*.avi|FLV(*.flv)|*.flv";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                video_path = dialog.FileName;
                MyVlc.LoadFile(video_path);
                PublicArgs.vedio_filepath = video_path;
                video_duration = (int)MyVlc.Duration;
                //本页停留时长匹配视频时长
                Page3_UpDown.Value = video_duration;
                //进度条上限
                VideoProcessBar.Maximum = video_duration;
                FullTime.Text = SecondParser(video_duration);
                BottomPanel.Enabled = true;

                PlayButton.Symbol = 61516;
                PlayTimer.Start();
                MyVlc.Play();
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (MyVlc.IsPlaying)
            {
                MyVlc.Pause();
                //PlayTimer.Stop();
            }
            else
            {
                MyVlc.Play();
            }
            PlayButton.Symbol = PlayButton.Symbol == 61515 ? 61516 : 61515;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            MyVlc.Stop();
            PlayButton.Symbol = 61515;
            VideoProcessBar.Value = 0;
        }

        private void Page3_UpDown_ValueChanged(object sender, int value)
        {
            if (Page3_UpDown.Value <= 0)
            {
                ShowWarningNotifier("第3屏停留时间设置错误！");
            }
            else
            {
                PublicArgs.page_stay[2] = Page3_UpDown.Value;
            }
        }

        private void VideoProcessBar_ValueChanged(object sender, EventArgs e)
        {
            //NowTime.Text = SecondParser(VideoProcessBar.Value);
            //MyVlc.SetPlayTime(VideoProcessBar.Value);
        }

        public static string SecondParser(int seconds)
        {
            int min = seconds / 60;
            int sec = seconds % 60;
            string m = "0";
            string s = "0";
            if (min < 10)
            {
                m += min;
            }
            else
            {
                m = min.ToString();
            }
            if (sec < 10)
            {
                s += sec;
            }
            else
            {
                s = sec.ToString();
            }
            return m + ":" + s;
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            int now_play_time = (int)MyVlc.GetPlayTime();
            NowTime.Text = SecondParser(now_play_time);
            VideoProcessBar.Value = now_play_time;
        }

        private void VolumeBar_ValueChanged(object sender, EventArgs e)
        {
            MyVlc.SetVolume(VolumeBar.Value);
            PublicArgs.volume = VolumeBar.Value;
        }

        public override bool SetParam(int fromPageIndex, params object[] objects)
        {
            if (objects.Length == 1)
            {
                if (Page3_UpDown.Value <= 0)
                {
                    return false;
                }
                //进入展示前关闭预览
                StopButton.PerformClick();
                PublicArgs.volume = VolumeBar.Value;
                PublicArgs.page_stay[2] = uiSwitch1.Active ? Page3_UpDown.Value : 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
