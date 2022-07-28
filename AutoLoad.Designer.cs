namespace SafeBroadcast
{
    partial class AutoLoad
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ok_btn = new Sunny.UI.UIButton();
            this.cancel_btn = new Sunny.UI.UIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ok_btn
            // 
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ok_btn.Font = new System.Drawing.Font("点字倔强黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok_btn.Location = new System.Drawing.Point(2, 2);
            this.ok_btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(197, 58);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = "确认 20";
            this.ok_btn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ok_btn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel_btn.Font = new System.Drawing.Font("点字倔强黑", 15.75F);
            this.cancel_btn.Location = new System.Drawing.Point(201, 2);
            this.cancel_btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(197, 58);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_btn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancel_btn);
            this.panel2.Controls.Add(this.ok_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(400, 62);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 153);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("点字倔强黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "检测到存在上一次配置，是否加载？";
            // 
            // AutoLoad
            // 
            this.AcceptButton = this.ok_btn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoLoad";
            this.Text = "提示";
            this.TitleFont = new System.Drawing.Font("点字倔强黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIButton ok_btn;
        private Sunny.UI.UIButton cancel_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}