namespace SafeBroadcast
{
    partial class FifthScreen
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
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_pic
            // 
            this.bg_pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bg_pic.Location = new System.Drawing.Point(0, 0);
            this.bg_pic.Name = "bg_pic";
            this.bg_pic.Size = new System.Drawing.Size(1920, 1080);
            this.bg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_pic.TabIndex = 3;
            this.bg_pic.TabStop = false;
            // 
            // FifthScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.bg_pic);
            this.Name = "FifthScreen";
            this.PageIndex = 2005;
            this.Text = "FifthScreen";
            ((System.ComponentModel.ISupportInitialize)(this.bg_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bg_pic;
    }
}