namespace SafeBroadcast
{
    partial class SecondScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.duty_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inform_richtext = new System.Windows.Forms.RichTextBox();
            this.header_label = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(66, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // duty_Label
            // 
            this.duty_Label.BackColor = System.Drawing.Color.Transparent;
            this.duty_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.duty_Label.Font = new System.Drawing.Font("微软雅黑", 34F, System.Drawing.FontStyle.Bold);
            this.duty_Label.ForeColor = System.Drawing.Color.Cyan;
            this.duty_Label.Location = new System.Drawing.Point(50, 954);
            this.duty_Label.Name = "duty_Label";
            this.duty_Label.Size = new System.Drawing.Size(1804, 140);
            this.duty_Label.TabIndex = 96;
            this.duty_Label.Text = "排班";
            this.duty_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inform_richtext);
            this.panel1.Controls.Add(this.header_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(50, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(100, 0, 50, 0);
            this.panel1.Size = new System.Drawing.Size(1804, 954);
            this.panel1.TabIndex = 97;
            // 
            // inform_richtext
            // 
            this.inform_richtext.BackColor = System.Drawing.SystemColors.ControlText;
            this.inform_richtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inform_richtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inform_richtext.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inform_richtext.ForeColor = System.Drawing.Color.Crimson;
            this.inform_richtext.Location = new System.Drawing.Point(100, 85);
            this.inform_richtext.Margin = new System.Windows.Forms.Padding(4);
            this.inform_richtext.Name = "inform_richtext";
            this.inform_richtext.ReadOnly = true;
            this.inform_richtext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.inform_richtext.Size = new System.Drawing.Size(1654, 869);
            this.inform_richtext.TabIndex = 59;
            this.inform_richtext.Text = "";
            // 
            // header_label
            // 
            this.header_label.BackColor = System.Drawing.SystemColors.ControlText;
            this.header_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.header_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_label.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Bold);
            this.header_label.ForeColor = System.Drawing.Color.Crimson;
            this.header_label.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.header_label.Location = new System.Drawing.Point(100, 0);
            this.header_label.Name = "header_label";
            this.header_label.ReadOnly = true;
            this.header_label.Size = new System.Drawing.Size(1654, 85);
            this.header_label.TabIndex = 58;
            this.header_label.Text = "重要保障期通知";
            this.header_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1904, 1094);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.duty_Label);
            this.Controls.Add(this.button1);
            this.Name = "SecondScreen";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.PageIndex = 2002;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "SecondScreen";
            this.Load += new System.EventHandler(this.SecondScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label duty_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox inform_richtext;
        private System.Windows.Forms.TextBox header_label;
    }
}