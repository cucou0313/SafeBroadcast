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
    public partial class SecondScreen : UIPage
    {
        public SecondScreen()
        {
            InitializeComponent();

            duty_Label.Visible = PublicArgs.is_use_duty;
            duty_Label.ForeColor = PublicArgs.duty_color;
            duty_Label.Text = PublicArgs.day_in_week();

            if (PublicArgs.rtf_filepath == "")
            {
                panel1.Padding = new Padding(50, PublicArgs.header_top, 50, 0);

                header_label.Font = PublicArgs.header_font;
                header_label.ForeColor = PublicArgs.header_color;
                header_label.TextAlign = PublicArgs.header_align;
                header_label.Text = PublicArgs.header_text;

                inform_richtext.Font = PublicArgs.content_font;
                inform_richtext.ForeColor = PublicArgs.content_color;
                inform_richtext.Text = PublicArgs.content_text;
            }
            else
            {
                header_label.Visible = false;
            }
        }

        private void SecondScreen_Load(object sender, EventArgs e)
        {
            if (PublicArgs.rtf_filepath != "")
            {
                inform_richtext.LoadFile(PublicArgs.rtf_filepath, RichTextBoxStreamType.RichText);
            }
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
