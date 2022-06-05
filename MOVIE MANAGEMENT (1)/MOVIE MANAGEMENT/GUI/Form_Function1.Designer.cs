namespace GUI
{
    partial class Form_Function1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Function1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbfullname = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btManagement = new Guna.UI2.WinForms.Guna2Button();
            this.gunaexit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            // 
            // lbfullname
            // 
            this.lbfullname.AutoSize = true;
            this.lbfullname.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.lbfullname.Location = new System.Drawing.Point(80, 144);
            this.lbfullname.Name = "lbfullname";
            this.lbfullname.Size = new System.Drawing.Size(0, 19);
            this.lbfullname.TabIndex = 131;
            this.lbfullname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ErrorImage = null;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(84, 60);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 130;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btBooking
            // 
            this.btBooking.BackColor = System.Drawing.Color.Transparent;
            this.btBooking.BorderRadius = 8;
            this.btBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btBooking.ForeColor = System.Drawing.Color.White;
            this.btBooking.Location = new System.Drawing.Point(48, 279);
            this.btBooking.Name = "btBooking";
            this.btBooking.Size = new System.Drawing.Size(147, 61);
            this.btBooking.TabIndex = 129;
            this.btBooking.Text = "Booking";
            this.btBooking.Click += new System.EventHandler(this.btBooking_Click);
            // 
            // btManagement
            // 
            this.btManagement.BackColor = System.Drawing.Color.Transparent;
            this.btManagement.BorderRadius = 8;
            this.btManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btManagement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btManagement.ForeColor = System.Drawing.Color.White;
            this.btManagement.Location = new System.Drawing.Point(48, 214);
            this.btManagement.Name = "btManagement";
            this.btManagement.Size = new System.Drawing.Size(147, 58);
            this.btManagement.TabIndex = 128;
            this.btManagement.Text = "Management";
            this.btManagement.Click += new System.EventHandler(this.btManagement_Click);
            // 
            // gunaexit
            // 
            this.gunaexit.BorderRadius = 10;
            this.gunaexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaexit.FillColor = System.Drawing.Color.White;
            this.gunaexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.gunaexit.Image = ((System.Drawing.Image)(resources.GetObject("gunaexit.Image")));
            this.gunaexit.Location = new System.Drawing.Point(220, 5);
            this.gunaexit.Name = "gunaexit";
            this.gunaexit.Size = new System.Drawing.Size(32, 31);
            this.gunaexit.TabIndex = 127;
            this.gunaexit.Click += new System.EventHandler(this.gunaexit_Click);
            // 
            // Form_Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 414);
            this.Controls.Add(this.lbfullname);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btBooking);
            this.Controls.Add(this.btManagement);
            this.Controls.Add(this.gunaexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Function";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Function";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label lbfullname;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btBooking;
        private Guna.UI2.WinForms.Guna2Button btManagement;
        private Guna.UI2.WinForms.Guna2Button gunaexit;
    }
}