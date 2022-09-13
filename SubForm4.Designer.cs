namespace SafeBroadcast
{
    partial class SubForm4
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
            this.components = new System.ComponentModel.Container();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.days = new System.Windows.Forms.Label();
            this.status_pic = new System.Windows.Forms.PictureBox();
            this.bg_pic = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Load_Button = new Sunny.UI.UISymbolButton();
            this.Page4_UpDown = new Sunny.UI.UIIntegerUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.uiSwitch1 = new Sunny.UI.UISwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiSwitch2 = new Sunny.UI.UISwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayTimer
            // 
            this.PlayTimer.Interval = 500;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.days);
            this.panel1.Controls.Add(this.status_pic);
            this.panel1.Controls.Add(this.bg_pic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(80, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 527);
            this.panel1.TabIndex = 49;
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.BackColor = System.Drawing.Color.Transparent;
            this.days.Font = new System.Drawing.Font("点字倔强黑", 140F, System.Drawing.FontStyle.Bold);
            this.days.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.days.Location = new System.Drawing.Point(168, 180);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(328, 243);
            this.days.TabIndex = 62;
            this.days.Text = "30";
            // 
            // status_pic
            // 
            this.status_pic.BackColor = System.Drawing.Color.Transparent;
            this.status_pic.Image = global::SafeBroadcast.Properties.Resources.倒计时;
            this.status_pic.Location = new System.Drawing.Point(39, 384);
            this.status_pic.Name = "status_pic";
            this.status_pic.Size = new System.Drawing.Size(224, 74);
            this.status_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.status_pic.TabIndex = 61;
            this.status_pic.TabStop = false;
            // 
            // bg_pic
            // 
            this.bg_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_pic.Image = global::SafeBroadcast.Properties.Resources.二十大背景;
            this.bg_pic.Location = new System.Drawing.Point(0, 0);
            this.bg_pic.Name = "bg_pic";
            this.bg_pic.Size = new System.Drawing.Size(1034, 527);
            this.bg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_pic.TabIndex = 60;
            this.bg_pic.TabStop = false;
            // 
            // Load_Button
            // 
            this.Load_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_Button.Enabled = false;
            this.Load_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.Load_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load_Button.Location = new System.Drawing.Point(227, 86);
            this.Load_Button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.Load_Button.Size = new System.Drawing.Size(91, 35);
            this.Load_Button.Symbol = 361896;
            this.Load_Button.SymbolSize = 26;
            this.Load_Button.TabIndex = 119;
            this.Load_Button.Text = "加载";
            this.Load_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Load_Button.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip1.SetToolTip(this.Load_Button, "加载视频文件");
            this.Load_Button.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // Page4_UpDown
            // 
            this.Page4_UpDown.Enabled = false;
            this.Page4_UpDown.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Page4_UpDown.Location = new System.Drawing.Point(610, 92);
            this.Page4_UpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Page4_UpDown.MinimumSize = new System.Drawing.Size(100, 0);
            this.Page4_UpDown.Name = "Page4_UpDown";
            this.Page4_UpDown.ShowText = false;
            this.Page4_UpDown.Size = new System.Drawing.Size(158, 29);
            this.Page4_UpDown.Step = 10;
            this.Page4_UpDown.TabIndex = 61;
            this.Page4_UpDown.Text = "uiIntegerUpDown1";
            this.Page4_UpDown.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.Page4_UpDown, "可按视频长度设置");
            this.Page4_UpDown.Value = 20;
            this.Page4_UpDown.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Page4_UpDown.ValueChanged += new Sunny.UI.UIIntegerUpDown.OnValueChanged(this.Page4_UpDown_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("微软雅黑", 12F);
            this.dateTimePicker1.CustomFormat = "yyyy年MM月dd日   HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 29);
            this.dateTimePicker1.TabIndex = 123;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "开始时间");
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.panel1);
            this.uiGroupBox2.Controls.Add(this.pictureBox5);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold);
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 144);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(80, 32, 80, 5);
            this.uiGroupBox2.Radius = 20;
            this.uiGroupBox2.RectSize = 2;
            this.uiGroupBox2.Size = new System.Drawing.Size(1194, 564);
            this.uiGroupBox2.TabIndex = 63;
            this.uiGroupBox2.Text = "预览";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.Visible = false;
            this.uiGroupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::SafeBroadcast.Properties.Resources.视频;
            this.pictureBox5.Location = new System.Drawing.Point(13, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // uiSwitch1
            // 
            this.uiSwitch1.ActiveText = "启用";
            this.uiSwitch1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSwitch1.InActiveText = "停用";
            this.uiSwitch1.Location = new System.Drawing.Point(227, 40);
            this.uiSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch1.Name = "uiSwitch1";
            this.uiSwitch1.Size = new System.Drawing.Size(91, 32);
            this.uiSwitch1.TabIndex = 121;
            this.uiSwitch1.Text = "uiSwitch1";
            this.uiSwitch1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSwitch1.ActiveChanged += new System.EventHandler(this.uiSwitch1_ActiveChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(85, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 120;
            this.label5.Text = "是否启用本页：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 118;
            this.label1.Text = "加载背景图片：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(398, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 26);
            this.label3.TabIndex = 62;
            this.label3.Text = "本页面停留时间（秒）：";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiSwitch2);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.dateTimePicker1);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.uiSwitch1);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.Load_Button);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.Page4_UpDown);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.pictureBox1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Radius = 20;
            this.uiGroupBox1.RectSize = 2;
            this.uiGroupBox1.Size = new System.Drawing.Size(1194, 144);
            this.uiGroupBox1.TabIndex = 62;
            this.uiGroupBox1.Text = "设置";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSwitch2
            // 
            this.uiSwitch2.Active = true;
            this.uiSwitch2.ActiveText = "启用";
            this.uiSwitch2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSwitch2.InActiveText = "停用";
            this.uiSwitch2.Location = new System.Drawing.Point(975, 89);
            this.uiSwitch2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitch2.Name = "uiSwitch2";
            this.uiSwitch2.Size = new System.Drawing.Size(91, 32);
            this.uiSwitch2.TabIndex = 125;
            this.uiSwitch2.Text = "uiSwitch2";
            this.uiSwitch2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSwitch2.ActiveChanged += new System.EventHandler(this.uiSwitch2_ActiveChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(833, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 124;
            this.label4.Text = "是否使用计时：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(398, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 122;
            this.label2.Text = "开始时间：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SafeBroadcast.Properties.Resources.时间;
            this.pictureBox1.Location = new System.Drawing.Point(13, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // SubForm4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1194, 708);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "SubForm4";
            this.PageIndex = 1004;
            this.Text = "SubForm4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bg_pic;
        private Sunny.UI.UISymbolButton Load_Button;
        private Sunny.UI.UIIntegerUpDown Page4_UpDown;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Sunny.UI.UISwitch uiSwitch1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.PictureBox status_pic;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UISwitch uiSwitch2;
        private System.Windows.Forms.Label label4;
    }
}