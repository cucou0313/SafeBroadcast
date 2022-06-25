﻿namespace SafeBroadcast
{
    partial class ShowForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dleft_panel = new System.Windows.Forms.Panel();
            this.per_sceond_timer = new System.Windows.Forms.Timer(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.Close_Button = new Sunny.UI.UISymbolButton();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.Switch_ProcessBar = new Sunny.UI.UIProcessBar();
            this.panel1.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Switch_ProcessBar);
            this.panel1.Controls.Add(this.dleft_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1030);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 10);
            this.panel1.TabIndex = 5;
            // 
            // dleft_panel
            // 
            this.dleft_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dleft_panel.Location = new System.Drawing.Point(0, 0);
            this.dleft_panel.Name = "dleft_panel";
            this.dleft_panel.Size = new System.Drawing.Size(0, 10);
            this.dleft_panel.TabIndex = 0;
            // 
            // per_sceond_timer
            // 
            this.per_sceond_timer.Interval = 1000;
            this.per_sceond_timer.Tick += new System.EventHandler(this.per_sceond_timer_Tick);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.Close_Button);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1920, 50);
            this.Header.TabIndex = 7;
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FillColor = System.Drawing.Color.Transparent;
            this.Close_Button.FillColor2 = System.Drawing.Color.Transparent;
            this.Close_Button.FillDisableColor = System.Drawing.Color.Transparent;
            this.Close_Button.FillHoverColor = System.Drawing.Color.Transparent;
            this.Close_Button.FillPressColor = System.Drawing.Color.Transparent;
            this.Close_Button.FillSelectedColor = System.Drawing.Color.Transparent;
            this.Close_Button.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Close_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Close_Button.ForeDisableColor = System.Drawing.Color.Transparent;
            this.Close_Button.ForeHoverColor = System.Drawing.Color.Transparent;
            this.Close_Button.ForePressColor = System.Drawing.Color.Transparent;
            this.Close_Button.ForeSelectedColor = System.Drawing.Color.Transparent;
            this.Close_Button.Location = new System.Drawing.Point(1855, 7);
            this.Close_Button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Radius = 0;
            this.Close_Button.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.Close_Button.Size = new System.Drawing.Size(57, 35);
            this.Close_Button.Style = Sunny.UI.UIStyle.Custom;
            this.Close_Button.Symbol = 61453;
            this.Close_Button.SymbolColor = System.Drawing.Color.Transparent;
            this.Close_Button.SymbolSize = 48;
            this.Close_Button.TabIndex = 92;
            this.Close_Button.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Close_Button.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 50);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1920, 980);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl1.TabIndex = 8;
            this.uiTabControl1.TabVisible = false;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Switch_ProcessBar
            // 
            this.Switch_ProcessBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Switch_ProcessBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Switch_ProcessBar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Switch_ProcessBar.Location = new System.Drawing.Point(0, 0);
            this.Switch_ProcessBar.MinimumSize = new System.Drawing.Size(70, 1);
            this.Switch_ProcessBar.Name = "Switch_ProcessBar";
            this.Switch_ProcessBar.Radius = 0;
            this.Switch_ProcessBar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.Switch_ProcessBar.ShowPercent = false;
            this.Switch_ProcessBar.ShowValue = false;
            this.Switch_ProcessBar.Size = new System.Drawing.Size(1920, 4);
            this.Switch_ProcessBar.Style = Sunny.UI.UIStyle.Custom;
            this.Switch_ProcessBar.TabIndex = 95;
            this.Switch_ProcessBar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ShowForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.CloseAskString = "是否退出？";
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.EscClose = true;
            this.MainTabControl = this.uiTabControl1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "ShowForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowFullScreen = true;
            this.ShowInTaskbar = false;
            this.ShowRadius = false;
            this.ShowRect = false;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "ShowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dleft_panel;
        private System.Windows.Forms.Timer per_sceond_timer;
        private System.Windows.Forms.Panel Header;
        private Sunny.UI.UISymbolButton Close_Button;
        private Sunny.UI.UITabControl uiTabControl1;
        private Sunny.UI.UIProcessBar Switch_ProcessBar;
    }
}