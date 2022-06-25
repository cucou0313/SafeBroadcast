namespace SafeBroadcast
{
    partial class ThirdScreen
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
            this.VideoPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoPic
            // 
            this.VideoPic.BackColor = System.Drawing.SystemColors.ControlText;
            this.VideoPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPic.Location = new System.Drawing.Point(0, 0);
            this.VideoPic.Name = "VideoPic";
            this.VideoPic.Size = new System.Drawing.Size(1053, 578);
            this.VideoPic.TabIndex = 2;
            this.VideoPic.TabStop = false;
            // 
            // ThirdScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1053, 578);
            this.Controls.Add(this.VideoPic);
            this.Name = "ThirdScreen";
            this.PageIndex = 2003;
            this.Text = "ThirdScreen";
            ((System.ComponentModel.ISupportInitialize)(this.VideoPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox VideoPic;
    }
}