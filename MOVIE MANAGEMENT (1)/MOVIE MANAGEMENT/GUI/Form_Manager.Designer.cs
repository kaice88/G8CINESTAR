namespace GUI
{
    partial class Form_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Manager));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.paneltrans = new Guna.UI2.WinForms.Guna2Panel();
            this.btroom = new Guna.UI2.WinForms.Guna2Button();
            this.btreceipt = new Guna.UI2.WinForms.Guna2Button();
            this.btstaff = new Guna.UI2.WinForms.Guna2Button();
            this.btschedule = new Guna.UI2.WinForms.Guna2Button();
            this.btmovie = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttonexit = new Guna.UI2.WinForms.Guna2Button();
            this.btcustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btstatistic = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // paneltrans
            // 
            this.paneltrans.BackColor = System.Drawing.Color.Transparent;
            this.paneltrans.BorderRadius = 10;
            this.paneltrans.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.paneltrans.Location = new System.Drawing.Point(117, 31);
            this.paneltrans.Name = "paneltrans";
            this.paneltrans.Size = new System.Drawing.Size(882, 516);
            this.paneltrans.TabIndex = 56;
            // 
            // btroom
            // 
            this.btroom.BackColor = System.Drawing.Color.Transparent;
            this.btroom.BorderRadius = 10;
            this.btroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btroom.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btroom.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btroom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btroom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btroom.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btroom.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btroom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btroom.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btroom.ForeColor = System.Drawing.Color.White;
            this.btroom.Image = ((System.Drawing.Image)(resources.GetObject("btroom.Image")));
            this.btroom.ImageSize = new System.Drawing.Size(25, 25);
            this.btroom.Location = new System.Drawing.Point(42, 200);
            this.btroom.Name = "btroom";
            this.btroom.Size = new System.Drawing.Size(56, 34);
            this.btroom.TabIndex = 55;
            this.btroom.UseTransparentBackground = true;
            this.btroom.UseWaitCursor = true;
            this.btroom.CheckedChanged += new System.EventHandler(this.btroom_CheckedChanged);
            // 
            // btreceipt
            // 
            this.btreceipt.BackColor = System.Drawing.Color.Transparent;
            this.btreceipt.BorderRadius = 10;
            this.btreceipt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btreceipt.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btreceipt.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btreceipt.CheckedState.FillColor = System.Drawing.Color.White;
            this.btreceipt.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btreceipt.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btreceipt.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btreceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btreceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btreceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btreceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btreceipt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btreceipt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btreceipt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btreceipt.ForeColor = System.Drawing.Color.White;
            this.btreceipt.Image = ((System.Drawing.Image)(resources.GetObject("btreceipt.Image")));
            this.btreceipt.ImageSize = new System.Drawing.Size(25, 25);
            this.btreceipt.Location = new System.Drawing.Point(42, 249);
            this.btreceipt.Name = "btreceipt";
            this.btreceipt.Size = new System.Drawing.Size(56, 34);
            this.btreceipt.TabIndex = 54;
            this.btreceipt.UseTransparentBackground = true;
            this.btreceipt.UseWaitCursor = true;
            this.btreceipt.Click += new System.EventHandler(this.btreceipt_Click);
            // 
            // btstaff
            // 
            this.btstaff.BackColor = System.Drawing.Color.Transparent;
            this.btstaff.BorderRadius = 10;
            this.btstaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btstaff.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btstaff.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btstaff.CheckedState.FillColor = System.Drawing.Color.White;
            this.btstaff.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btstaff.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btstaff.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btstaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btstaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btstaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btstaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btstaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btstaff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btstaff.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btstaff.ForeColor = System.Drawing.Color.White;
            this.btstaff.Image = ((System.Drawing.Image)(resources.GetObject("btstaff.Image")));
            this.btstaff.ImageSize = new System.Drawing.Size(25, 25);
            this.btstaff.Location = new System.Drawing.Point(42, 301);
            this.btstaff.Name = "btstaff";
            this.btstaff.Size = new System.Drawing.Size(56, 34);
            this.btstaff.TabIndex = 52;
            this.btstaff.UseTransparentBackground = true;
            this.btstaff.UseWaitCursor = true;
            this.btstaff.CheckedChanged += new System.EventHandler(this.btstaff_CheckedChanged);
            // 
            // btschedule
            // 
            this.btschedule.BackColor = System.Drawing.Color.Transparent;
            this.btschedule.BorderRadius = 10;
            this.btschedule.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btschedule.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btschedule.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btschedule.CheckedState.FillColor = System.Drawing.Color.White;
            this.btschedule.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btschedule.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.btschedule.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btschedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btschedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btschedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btschedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btschedule.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btschedule.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btschedule.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btschedule.ForeColor = System.Drawing.Color.White;
            this.btschedule.Image = ((System.Drawing.Image)(resources.GetObject("btschedule.Image")));
            this.btschedule.ImageSize = new System.Drawing.Size(25, 25);
            this.btschedule.Location = new System.Drawing.Point(42, 150);
            this.btschedule.Name = "btschedule";
            this.btschedule.Size = new System.Drawing.Size(56, 34);
            this.btschedule.TabIndex = 51;
            this.btschedule.UseTransparentBackground = true;
            this.btschedule.UseWaitCursor = true;
            this.btschedule.CheckedChanged += new System.EventHandler(this.btschedule_CheckedChanged);
            // 
            // btmovie
            // 
            this.btmovie.BackColor = System.Drawing.Color.Transparent;
            this.btmovie.BorderRadius = 10;
            this.btmovie.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btmovie.Checked = true;
            this.btmovie.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btmovie.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btmovie.CheckedState.FillColor = System.Drawing.Color.White;
            this.btmovie.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btmovie.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.btmovie.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btmovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btmovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btmovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btmovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btmovie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btmovie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btmovie.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btmovie.ForeColor = System.Drawing.Color.White;
            this.btmovie.Image = ((System.Drawing.Image)(resources.GetObject("btmovie.Image")));
            this.btmovie.ImageSize = new System.Drawing.Size(25, 25);
            this.btmovie.Location = new System.Drawing.Point(42, 100);
            this.btmovie.Name = "btmovie";
            this.btmovie.Size = new System.Drawing.Size(56, 34);
            this.btmovie.TabIndex = 18;
            this.btmovie.UseTransparentBackground = true;
            this.btmovie.UseWaitCursor = true;
            this.btmovie.CheckedChanged += new System.EventHandler(this.btmovie_CheckedChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 8;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(35, 31);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(68, 516);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            // 
            // buttonexit
            // 
            this.buttonexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonexit.ForeColor = System.Drawing.Color.White;
            this.buttonexit.Image = ((System.Drawing.Image)(resources.GetObject("buttonexit.Image")));
            this.buttonexit.Location = new System.Drawing.Point(48, 476);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(47, 45);
            this.buttonexit.TabIndex = 0;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // btcustomer
            // 
            this.btcustomer.BackColor = System.Drawing.Color.Transparent;
            this.btcustomer.BorderRadius = 10;
            this.btcustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btcustomer.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btcustomer.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btcustomer.CheckedState.FillColor = System.Drawing.Color.White;
            this.btcustomer.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btcustomer.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btcustomer.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btcustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btcustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btcustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btcustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btcustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btcustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btcustomer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btcustomer.ForeColor = System.Drawing.Color.White;
            this.btcustomer.Image = ((System.Drawing.Image)(resources.GetObject("btcustomer.Image")));
            this.btcustomer.ImageSize = new System.Drawing.Size(25, 25);
            this.btcustomer.Location = new System.Drawing.Point(42, 355);
            this.btcustomer.Name = "btcustomer";
            this.btcustomer.Size = new System.Drawing.Size(56, 34);
            this.btcustomer.TabIndex = 57;
            this.btcustomer.UseTransparentBackground = true;
            this.btcustomer.UseWaitCursor = true;
            this.btcustomer.CheckedChanged += new System.EventHandler(this.btcustomer_CheckedChanged);
            // 
            // btstatistic
            // 
            this.btstatistic.BackColor = System.Drawing.Color.Transparent;
            this.btstatistic.BorderRadius = 10;
            this.btstatistic.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btstatistic.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btstatistic.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btstatistic.CheckedState.FillColor = System.Drawing.Color.White;
            this.btstatistic.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btstatistic.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btstatistic.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btstatistic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btstatistic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btstatistic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btstatistic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btstatistic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btstatistic.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btstatistic.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.btstatistic.ForeColor = System.Drawing.Color.White;
            this.btstatistic.Image = ((System.Drawing.Image)(resources.GetObject("btstatistic.Image")));
            this.btstatistic.ImageSize = new System.Drawing.Size(25, 25);
            this.btstatistic.Location = new System.Drawing.Point(39, 408);
            this.btstatistic.Name = "btstatistic";
            this.btstatistic.Size = new System.Drawing.Size(56, 34);
            this.btstatistic.TabIndex = 58;
            this.btstatistic.UseTransparentBackground = true;
            this.btstatistic.UseWaitCursor = true;
            this.btstatistic.CheckedChanged += new System.EventHandler(this.btstatistic_CheckedChanged);
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1033, 575);
            this.Controls.Add(this.btstatistic);
            this.Controls.Add(this.btcustomer);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.btroom);
            this.Controls.Add(this.btreceipt);
            this.Controls.Add(this.btstaff);
            this.Controls.Add(this.btschedule);
            this.Controls.Add(this.btmovie);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.paneltrans);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Manager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QL_NV";
            this.Load += new System.EventHandler(this.Form_QL_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btmovie;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2Button btstaff;
        private Guna.UI2.WinForms.Guna2Button btschedule;
        private Guna.UI2.WinForms.Guna2Button btroom;
        private Guna.UI2.WinForms.Guna2Button btreceipt;
        private Guna.UI2.WinForms.Guna2Panel paneltrans;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button buttonexit;
        private Guna.UI2.WinForms.Guna2Button btcustomer;
        private Guna.UI2.WinForms.Guna2Button btstatistic;
    }
}

