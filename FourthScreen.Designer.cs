namespace SafeBroadcast
{
    partial class FourthScreen
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
            this.bg_pic = new System.Windows.Forms.PictureBox();
            this.status_pic = new System.Windows.Forms.PictureBox();
            this.days = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_pic
            // 
            this.bg_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_pic.Image = global::SafeBroadcast.Properties.Resources.二十大背景;
            this.bg_pic.Location = new System.Drawing.Point(0, 0);
            this.bg_pic.Name = "bg_pic";
            this.bg_pic.Size = new System.Drawing.Size(1920, 1080);
            this.bg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_pic.TabIndex = 0;
            this.bg_pic.TabStop = false;
            // 
            // status_pic
            // 
            this.status_pic.BackColor = System.Drawing.Color.Transparent;
            this.status_pic.Image = global::SafeBroadcast.Properties.Resources.倒计时;
            this.status_pic.Location = new System.Drawing.Point(187, 420);
            this.status_pic.Name = "status_pic";
            this.status_pic.Size = new System.Drawing.Size(310, 102);
            this.status_pic.TabIndex = 1;
            this.status_pic.TabStop = false;
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.BackColor = System.Drawing.Color.Transparent;
            this.days.Font = new System.Drawing.Font("点字倔强黑", 200F, System.Drawing.FontStyle.Bold);
            this.days.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.days.Location = new System.Drawing.Point(580, 600);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(1091, 347);
            this.days.TabIndex = 2;
            this.days.Text = "label1";
            // 
            // FourthScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.days);
            this.Controls.Add(this.status_pic);
            this.Controls.Add(this.bg_pic);
            this.Name = "FourthScreen";
            this.PageIndex = 2004;
            this.Text = "FourthScreen";
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg_pic;
        private System.Windows.Forms.PictureBox status_pic;
        private System.Windows.Forms.Label days;
    }
}