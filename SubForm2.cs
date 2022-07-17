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
    public partial class SubForm2 : UIPage
    {
        public SubForm2()
        {
            InitializeComponent();
            Align_ComboBox.SelectedIndex = 1;
            Encode_ComboBox.SelectedIndex = 1;
        }

        string file = "";
        private void Txt_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择文本文件";
            dialog.Filter = "文本文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                header_label.Visible = true;
                Rtf_Button.ShowTips = false;
                PublicArgs.rtf_filepath = "";
                file = dialog.FileName;
                //richTextBox1.Text = File.ReadAllText(file);
                /*UTF8
                Default
                GB2312
                Unicode
                ASCII*/
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                StreamReader sr = null;
                switch (Encode_ComboBox.SelectedIndex)
                {
                    case 0:
                        sr = new StreamReader(fs, Encoding.UTF8);
                        break;
                    case 1:
                        sr = new StreamReader(fs, Encoding.Default);
                        break;
                    case 2:
                        sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                        break;
                    case 3:
                        sr = new StreamReader(fs, Encoding.Unicode);
                        break;
                    case 4:
                        sr = new StreamReader(fs, Encoding.ASCII);
                        break;
                }
                inform_richtext.Text = sr.ReadToEnd();
                Txt_Button.ShowTips = true;
                PublicArgs.content_text = inform_richtext.Text;
            }
        }

        private void Header_TextBox_TextChanged(object sender, EventArgs e)
        {
            header_label.Visible = true;
            header_label.Text = Header_TextBox.Text;
            if (Rtf_Button.ShowTips == true)
            {
                Rtf_Button.ShowTips = false;
                inform_richtext.Text = PublicArgs.content_text;
                PublicArgs.rtf_filepath = "";
            }
        }

        private void Header_ColorPicker_ValueChanged(object sender, Color value)
        {
            header_label.ForeColor = Header_ColorPicker.Value;
        }

        private void Main_ColorPicker_ValueChanged_1(object sender, Color value)
        {
            inform_richtext.ForeColor = Main_ColorPicker.Value;
        }

        private void Align_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            header_label.Visible = true;
            header_label.Text = Header_TextBox.Text;
            inform_richtext.Text = PublicArgs.content_text;
            Rtf_Button.ShowTips = false;
            PublicArgs.rtf_filepath = "";
            switch (Align_ComboBox.SelectedIndex)
            {
                case 0:
                    header_label.TextAlign = PublicArgs.header_align = HorizontalAlignment.Left;
                    break;
                case 1:
                    header_label.TextAlign = PublicArgs.header_align = HorizontalAlignment.Center;
                    break;
                case 2:
                    header_label.TextAlign = PublicArgs.header_align = HorizontalAlignment.Right;
                    break;
            }
        }

        private void Rtf_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择富文本文件";
            dialog.Filter = "文本文件(*.rtf)|*.rtf";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                header_label.Visible = false;
                string file = dialog.FileName;
                PublicArgs.rtf_filepath = file;
                inform_richtext.LoadFile(file, RichTextBoxStreamType.RichText);

                Txt_Button.ShowTips = false;
                Rtf_Button.ShowTips = true;
            }
        }

        private void Page2_UpDown_ValueChanged(object sender, int value)
        {
            if (Page2_UpDown.Value <= 0)
            {
                ShowWarningNotifier("第2屏停留时间设置错误！");
            }
            else
            {
                PublicArgs.page_stay[1] = Page2_UpDown.Value;
            }
        }

        private void Header_UpDown_ValueChanged(object sender, int value)
        {
            header_label.Visible = true;
            header_label.Text = Header_TextBox.Text;
            inform_richtext.Text = PublicArgs.content_text;
            Rtf_Button.ShowTips = false;
            PublicArgs.rtf_filepath = "";
            if (Header_UpDown.Value < 0)
            {
                ShowWarningNotifier("标题间距设置错误！");
            }
            else
            {
                PublicArgs.header_top = Header_UpDown.Value;
                panel1.Padding = new Padding(0, Header_UpDown.Value, 0, 0);
            }
        }

        private void uiSwitch1_ActiveChanged(object sender, EventArgs e)
        {
            uiGroupBox3.Visible = uiSwitch1.Active;
            Header_TextBox.Enabled = uiSwitch1.Active;
            header_font_btn.Enabled = uiSwitch1.Active;
            Header_ColorPicker.Enabled = uiSwitch1.Active;
            Header_UpDown.Enabled = uiSwitch1.Active;
            Align_ComboBox.Enabled = uiSwitch1.Active;
            Txt_Button.Enabled = uiSwitch1.Active;
            main_font_btn.Enabled = uiSwitch1.Active;
            Main_ColorPicker.Enabled = uiSwitch1.Active;
            Encode_ComboBox.Enabled = uiSwitch1.Active;
            Rtf_Button.Enabled = uiSwitch1.Active;
            Page2_UpDown.Enabled = uiSwitch1.Active;
        }

        public override bool SetParam(int fromPageIndex, params object[] objects)
        {
            if (objects.Length == 1)
            {
                if (fromPageIndex == 1001)
                {
                    duty_label.Visible = (bool)objects[0];
                    return true;
                }
                else
                {
                    if (Header_UpDown.Value < 0)
                    {
                        return false;
                    }
                    if (Page2_UpDown.Value <= 0)
                    {
                        return false;
                    }
                    PublicArgs.page_stay[1] = uiSwitch1.Active ? Page2_UpDown.Value : 0;
                    PublicArgs.header_text = header_label.Text;
                    PublicArgs.header_color = header_label.ForeColor;
                    PublicArgs.header_font = header_label.Font;
                    PublicArgs.content_text = inform_richtext.Text;
                    PublicArgs.content_color = inform_richtext.ForeColor;
                    PublicArgs.content_font = inform_richtext.Font;

                    //PublicArgs.is_use_second_screen = uiSwitch1.Active;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void header_font_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                header_label.Font = fontDialog1.Font;
            }
        }

        private void main_font_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                inform_richtext.Font = fontDialog1.Font;
            }
        }

        private void Encode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (file != "")
            {
                header_label.Visible = true;
                PublicArgs.rtf_filepath = "";
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                StreamReader sr = null;
                switch (Encode_ComboBox.SelectedIndex)
                {
                    case 0:
                        sr = new StreamReader(fs, Encoding.UTF8);
                        break;
                    case 1:
                        sr = new StreamReader(fs, Encoding.Default);
                        break;
                    case 2:
                        sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                        break;
                    case 3:
                        sr = new StreamReader(fs, Encoding.Unicode);
                        break;
                    case 4:
                        sr = new StreamReader(fs, Encoding.ASCII);
                        break;
                }
                inform_richtext.Text = sr.ReadToEnd();
                Txt_Button.ShowTips = true;
                PublicArgs.content_text = inform_richtext.Text;
            }
        }
    }
}
