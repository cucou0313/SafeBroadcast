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
    public partial class FifthScreen : UIPage
    {
        public FifthScreen()
        {
            InitializeComponent();
            if (PublicArgs.info_bg != "")
                bg_pic.Image = Image.FromFile(PublicArgs.info_bg);
            else
                bg_pic.Image = null;
        }
    }
}
