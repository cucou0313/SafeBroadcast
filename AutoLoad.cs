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
    public partial class AutoLoad : UIForm
    {
        public AutoLoad()
        {
            InitializeComponent();
        }
        private int survival_time = 19;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (survival_time > 0)
            {
                ok_btn.Text = "确认 " + survival_time;
                survival_time--;
            }
            else
            //默认结束时加载,且自动进入展示（用于夜间自启）
            {
                PublicArgs.is_auto_load = true;
                PublicArgs.is_auto_show = true;
                this.Close();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            PublicArgs.is_auto_load = true;
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
