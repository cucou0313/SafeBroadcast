namespace SafeBroadcast
{
    partial class FirstScreen
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
            this.Time_Panel = new System.Windows.Forms.Panel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Time_LedLabel = new Sunny.UI.UILedLabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.per_second_timer = new System.Windows.Forms.Timer(this.components);
            this.duty_Label = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.My_Panel = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.tright_panel = new System.Windows.Forms.Panel();
            this.tleft_panel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.mright_panel = new System.Windows.Forms.Panel();
            this.mleft_panel = new System.Windows.Forms.Panel();
            this.StartLabel = new System.Windows.Forms.Label();
            this.uiLine2 = new Sunny.UI.UILine();
            this.Time_Panel.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.My_Panel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Time_Panel
            // 
            this.Time_Panel.Controls.Add(this.DateLabel);
            this.Time_Panel.Controls.Add(this.Time_LedLabel);
            this.Time_Panel.Controls.Add(this.uiLine1);
            this.Time_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Time_Panel.Location = new System.Drawing.Point(50, 0);
            this.Time_Panel.Name = "Time_Panel";
            this.Time_Panel.Size = new System.Drawing.Size(1804, 235);
            this.Time_Panel.TabIndex = 0;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DateLabel.Font = new System.Drawing.Font("微软雅黑", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.DateLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.DateLabel.Location = new System.Drawing.Point(1711, 60);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(93, 42);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time_LedLabel
            // 
            this.Time_LedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Time_LedLabel.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold);
            this.Time_LedLabel.ForeColor = System.Drawing.Color.Aqua;
            this.Time_LedLabel.IntervalOn = 10;
            this.Time_LedLabel.Location = new System.Drawing.Point(0, 60);
            this.Time_LedLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.Time_LedLabel.Name = "Time_LedLabel";
            this.Time_LedLabel.Size = new System.Drawing.Size(1804, 175);
            this.Time_LedLabel.Style = Sunny.UI.UIStyle.Custom;
            this.Time_LedLabel.TabIndex = 9;
            this.Time_LedLabel.Text = "NOWTIME";
            this.Time_LedLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("方正姚体", 28F, System.Drawing.FontStyle.Bold);
            this.uiLine1.ForeColor = System.Drawing.Color.DarkGray;
            this.uiLine1.LineColor = System.Drawing.Color.DarkGray;
            this.uiLine1.LineSize = 5;
            this.uiLine1.Location = new System.Drawing.Point(0, 0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(1804, 60);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.Text = "当前时间";
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // per_second_timer
            // 
            this.per_second_timer.Enabled = true;
            this.per_second_timer.Interval = 1000;
            this.per_second_timer.Tick += new System.EventHandler(this.per_second_timer_Tick);
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
            this.duty_Label.TabIndex = 95;
            this.duty_Label.Text = "排班";
            this.duty_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.My_Panel);
            this.Main_Panel.Controls.Add(this.uiLine2);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(50, 235);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1804, 719);
            this.Main_Panel.TabIndex = 96;
            // 
            // My_Panel
            // 
            this.My_Panel.Controls.Add(this.panel10);
            this.My_Panel.Controls.Add(this.panel7);
            this.My_Panel.Controls.Add(this.StartLabel);
            this.My_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.My_Panel.Location = new System.Drawing.Point(0, 60);
            this.My_Panel.Name = "My_Panel";
            this.My_Panel.Size = new System.Drawing.Size(1804, 659);
            this.My_Panel.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.Controls.Add(this.TimerLabel);
            this.panel10.Controls.Add(this.tright_panel);
            this.panel10.Controls.Add(this.tleft_panel);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 186);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel10.Size = new System.Drawing.Size(1804, 116);
            this.panel10.TabIndex = 31;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerLabel.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Bold);
            this.TimerLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.TimerLabel.Location = new System.Drawing.Point(10, 30);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(229, 86);
            this.TimerLabel.TabIndex = 14;
            this.TimerLabel.Text = "正计时";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tright_panel
            // 
            this.tright_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.tright_panel.Location = new System.Drawing.Point(1794, 30);
            this.tright_panel.Name = "tright_panel";
            this.tright_panel.Size = new System.Drawing.Size(10, 86);
            this.tright_panel.TabIndex = 13;
            // 
            // tleft_panel
            // 
            this.tleft_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tleft_panel.Location = new System.Drawing.Point(0, 30);
            this.tleft_panel.Name = "tleft_panel";
            this.tleft_panel.Size = new System.Drawing.Size(10, 86);
            this.tleft_panel.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.MainLabel);
            this.panel7.Controls.Add(this.mright_panel);
            this.panel7.Controls.Add(this.mleft_panel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1804, 86);
            this.panel7.TabIndex = 30;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLabel.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Bold);
            this.MainLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.MainLabel.Location = new System.Drawing.Point(10, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(165, 86);
            this.MainLabel.TabIndex = 14;
            this.MainLabel.Text = "文本";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mright_panel
            // 
            this.mright_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mright_panel.Location = new System.Drawing.Point(1794, 0);
            this.mright_panel.Name = "mright_panel";
            this.mright_panel.Size = new System.Drawing.Size(10, 86);
            this.mright_panel.TabIndex = 13;
            // 
            // mleft_panel
            // 
            this.mleft_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mleft_panel.Location = new System.Drawing.Point(0, 0);
            this.mleft_panel.Name = "mleft_panel";
            this.mleft_panel.Size = new System.Drawing.Size(10, 86);
            this.mleft_panel.TabIndex = 0;
            // 
            // StartLabel
            // 
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartLabel.Font = new System.Drawing.Font("微软雅黑", 38F, System.Drawing.FontStyle.Bold);
            this.StartLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.StartLabel.Location = new System.Drawing.Point(0, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(1804, 100);
            this.StartLabel.TabIndex = 29;
            this.StartLabel.Text = "Date";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLine2
            // 
            this.uiLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLine2.FillColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("方正姚体", 28F, System.Drawing.FontStyle.Bold);
            this.uiLine2.ForeColor = System.Drawing.Color.DarkGray;
            this.uiLine2.LineColor = System.Drawing.Color.DarkGray;
            this.uiLine2.LineSize = 5;
            this.uiLine2.Location = new System.Drawing.Point(0, 0);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(1804, 60);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 1;
            this.uiLine2.Text = "安全播出";
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FirstScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1904, 1094);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.duty_Label);
            this.Controls.Add(this.Time_Panel);
            this.Name = "FirstScreen";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.PageIndex = 2001;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "FirstScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstScreen_FormClosing);
            this.Time_Panel.ResumeLayout(false);
            this.Time_Panel.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.My_Panel.ResumeLayout(false);
            this.My_Panel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Time_Panel;
        private System.Windows.Forms.Timer per_second_timer;
        private Sunny.UI.UILine uiLine1;
        private System.Windows.Forms.Label DateLabel;
        private Sunny.UI.UILedLabel Time_LedLabel;
        private System.Windows.Forms.Label duty_Label;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel My_Panel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Panel tright_panel;
        private System.Windows.Forms.Panel tleft_panel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Panel mright_panel;
        private System.Windows.Forms.Panel mleft_panel;
        private System.Windows.Forms.Label StartLabel;
        private Sunny.UI.UILine uiLine2;
    }
}