using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace SafeBroadcast
{
    public partial class ThirdScreen : UIPage
    {

        //private VlcPlayer.VlcPlayerBase MyVlc;
        public ThirdScreen()
        {
            InitializeComponent();
            PublicArgs.MyVlc = new VlcPlayer.VlcPlayerBase(Path.Combine(Environment.CurrentDirectory, "plugins"));
            //将视频流输出到指定控件的句柄
            PublicArgs.MyVlc.SetRenderWindow(VideoPic.Handle.ToInt32());
            PublicArgs.MyVlc.LoadFile(PublicArgs.vedio_filepath);
            //MyVlc.SetVolume(PublicArgs.volume);

            //VlcPlayerBase = new VlcPlayer.VlcPlayerBase("");
            //VlcPlayerBase.SetRenderWindow(pictureBox1.Handle.ToInt32());
            //VlcPlayerBase.LoadFile("test.mp4");
            //VlcPlayerBase.Play();
            /////VLC运行时需指定DLL库文件，代码指明的方式如下
            /////1. BeginInit -》VlcLibDirectory -》EndInit
            /////删除Designer文件中的((System.ComponentModel.ISupportInitialize)(this.vlcControl)).EndInit();
            ////加载VLC运行时文件
            //vlcControl.BeginInit();
            //VlcPlayer.VlcPlayerBase VlcPlayerBase = new VlcPlayer.VlcPlayerBase(Environment.CurrentDirectory + "\\vlc\\plugins\\");
            //DirectoryInfo vlc_path = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "vlclib"));
            //vlcControl.VlcLibDirectory = vlc_path;
            //vlcControl.EndInit();
            ////vlcControl.SetMedia(new Uri(PublicArgs.vedio_filepath));
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Title = "请选择视频文件";
            //dialog.Filter = "MP4(*.mp4)|*.mp4|AVI(*.avi)|*.avi";
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string file = dialog.FileName;
            //    vlcControl.SetMedia(new Uri(file));
            //}
            //vlcControl.Play();
        }

        //public override bool SetParam(int fromPageIndex, params object[] objects)
        //{
        //    if (objects.Length == 1)
        //    {
        //        bool is_play = (bool)objects[0];
        //        if (is_play)
        //        {
        //            PublicArgs.MyVlc.Play();
        //        }
        //        else
        //        {
        //            PublicArgs.MyVlc.Stop();
        //        }
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
