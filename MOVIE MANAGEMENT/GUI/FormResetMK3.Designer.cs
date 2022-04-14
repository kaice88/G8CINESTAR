namespace GUI
{
    partial class FormResetMK3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResetMK3));
            this.txtconfirmpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnewpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonreset = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelfail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaback = new Guna.UI2.WinForms.Guna2Button();
            this.buttoneyescl = new Guna.UI2.WinForms.Guna2Button();
            this.gunacheck = new Guna.UI2.WinForms.Guna2Button();
            this.buttoneyes2 = new Guna.UI2.WinForms.Guna2Button();
            this.buttoneyes1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gunaexit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtconfirmpass.BorderRadius = 20;
            this.txtconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirmpass.DefaultText = "";
            this.txtconfirmpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtconfirmpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtconfirmpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirmpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfirmpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirmpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtconfirmpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfirmpass.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtconfirmpass.Location = new System.Drawing.Point(574, 316);
            this.txtconfirmpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.PasswordChar = '●';
            this.txtconfirmpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtconfirmpass.PlaceholderText = "Confirm  password";
            this.txtconfirmpass.SelectedText = "";
            this.txtconfirmpass.Size = new System.Drawing.Size(278, 49);
            this.txtconfirmpass.TabIndex = 104;
            this.txtconfirmpass.UseSystemPasswordChar = true;
            this.txtconfirmpass.TextChanged += new System.EventHandler(this.txtconfirmpass_TextChanged);
            // 
            // txtnewpass
            // 
            this.txtnewpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtnewpass.BorderRadius = 20;
            this.txtnewpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnewpass.DefaultText = "";
            this.txtnewpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnewpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnewpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnewpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnewpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnewpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnewpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnewpass.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtnewpass.Location = new System.Drawing.Point(574, 240);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '●';
            this.txtnewpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtnewpass.PlaceholderText = "New password";
            this.txtnewpass.SelectedText = "";
            this.txtnewpass.Size = new System.Drawing.Size(278, 49);
            this.txtnewpass.TabIndex = 103;
            this.txtnewpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(574, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 34);
            this.label2.TabIndex = 99;
            this.label2.Text = "Minimum 10 characters. Must contain upper \r\nand lowercase, numbers and symbols.";
            // 
            // buttonreset
            // 
            this.buttonreset.BorderRadius = 20;
            this.buttonreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonreset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreset.ForeColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(574, 413);
            this.buttonreset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(275, 42);
            this.buttonreset.TabIndex = 97;
            this.buttonreset.Text = "RESET PASSWORD";
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(574, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "___________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(574, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 27);
            this.label1.TabIndex = 95;
            this.label1.Text = "Reset your password";
            // 
            // labelfail
            // 
            this.labelfail.AutoSize = true;
            this.labelfail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.labelfail.Location = new System.Drawing.Point(576, 203);
            this.labelfail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfail.Name = "labelfail";
            this.labelfail.Size = new System.Drawing.Size(0, 17);
            this.labelfail.TabIndex = 117;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // gunaback
            // 
            this.gunaback.BorderRadius = 21;
            this.gunaback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaback.FillColor = System.Drawing.Color.White;
            this.gunaback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.gunaback.Image = ((System.Drawing.Image)(resources.GetObject("gunaback.Image")));
            this.gunaback.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaback.Location = new System.Drawing.Point(448, 39);
            this.gunaback.Name = "gunaback";
            this.gunaback.Size = new System.Drawing.Size(55, 45);
            this.gunaback.TabIndex = 120;
            this.gunaback.Click += new System.EventHandler(this.gunaback_Click);
            // 
            // buttoneyescl
            // 
            this.buttoneyescl.Animated = true;
            this.buttoneyescl.BackColor = System.Drawing.Color.Transparent;
            this.buttoneyescl.BorderRadius = 8;
            this.buttoneyescl.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttoneyescl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyescl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyescl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttoneyescl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttoneyescl.FillColor = System.Drawing.Color.White;
            this.buttoneyescl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttoneyescl.ForeColor = System.Drawing.Color.White;
            this.buttoneyescl.ImageSize = new System.Drawing.Size(25, 25);
            this.buttoneyescl.Location = new System.Drawing.Point(822, 254);
            this.buttoneyescl.Name = "buttoneyescl";
            this.buttoneyescl.Size = new System.Drawing.Size(21, 21);
            this.buttoneyescl.TabIndex = 122;
            // 
            // gunacheck
            // 
            this.gunacheck.Animated = true;
            this.gunacheck.BackColor = System.Drawing.Color.Transparent;
            this.gunacheck.BorderRadius = 8;
            this.gunacheck.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunacheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunacheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunacheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunacheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunacheck.FillColor = System.Drawing.Color.White;
            this.gunacheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunacheck.ForeColor = System.Drawing.Color.White;
            this.gunacheck.Image = ((System.Drawing.Image)(resources.GetObject("gunacheck.Image")));
            this.gunacheck.ImageSize = new System.Drawing.Size(25, 25);
            this.gunacheck.Location = new System.Drawing.Point(812, 325);
            this.gunacheck.Name = "gunacheck";
            this.gunacheck.Size = new System.Drawing.Size(31, 30);
            this.gunacheck.TabIndex = 123;
            this.gunacheck.Visible = false;
            // 
            // buttoneyes2
            // 
            this.buttoneyes2.Animated = true;
            this.buttoneyes2.BackColor = System.Drawing.Color.Transparent;
            this.buttoneyes2.BorderRadius = 8;
            this.buttoneyes2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttoneyes2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyes2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyes2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttoneyes2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttoneyes2.FillColor = System.Drawing.Color.White;
            this.buttoneyes2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttoneyes2.ForeColor = System.Drawing.Color.White;
            this.buttoneyes2.Image = ((System.Drawing.Image)(resources.GetObject("buttoneyes2.Image")));
            this.buttoneyes2.ImageSize = new System.Drawing.Size(25, 25);
            this.buttoneyes2.Location = new System.Drawing.Point(812, 249);
            this.buttoneyes2.Name = "buttoneyes2";
            this.buttoneyes2.Size = new System.Drawing.Size(31, 30);
            this.buttoneyes2.TabIndex = 124;
            this.buttoneyes2.Click += new System.EventHandler(this.buttoneyes2_Click);
            // 
            // buttoneyes1
            // 
            this.buttoneyes1.Animated = true;
            this.buttoneyes1.BackColor = System.Drawing.Color.Transparent;
            this.buttoneyes1.BorderRadius = 8;
            this.buttoneyes1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttoneyes1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyes1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyes1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttoneyes1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttoneyes1.FillColor = System.Drawing.Color.White;
            this.buttoneyes1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttoneyes1.ForeColor = System.Drawing.Color.White;
            this.buttoneyes1.Image = ((System.Drawing.Image)(resources.GetObject("buttoneyes1.Image")));
            this.buttoneyes1.ImageSize = new System.Drawing.Size(25, 25);
            this.buttoneyes1.Location = new System.Drawing.Point(812, 249);
            this.buttoneyes1.Name = "buttoneyes1";
            this.buttoneyes1.Size = new System.Drawing.Size(31, 30);
            this.buttoneyes1.TabIndex = 125;
            this.buttoneyes1.Click += new System.EventHandler(this.buttoneyes1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
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
            this.gunaexit.Location = new System.Drawing.Point(924, 8);
            this.gunaexit.Name = "gunaexit";
            this.gunaexit.Size = new System.Drawing.Size(32, 31);
            this.gunaexit.TabIndex = 126;
            this.gunaexit.Click += new System.EventHandler(this.gunaexit_Click);
            // 
            // FormResetMK3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.gunaexit);
            this.Controls.Add(this.buttoneyes1);
            this.Controls.Add(this.buttoneyes2);
            this.Controls.Add(this.gunacheck);
            this.Controls.Add(this.buttoneyescl);
            this.Controls.Add(this.gunaback);
            this.Controls.Add(this.labelfail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResetMK3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResetMatKhau3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtconfirmpass;
        private Guna.UI2.WinForms.Guna2TextBox txtnewpass;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonreset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelfail;
        private Guna.UI2.WinForms.Guna2Button gunaback;
        private Guna.UI2.WinForms.Guna2Button buttoneyescl;
        private Guna.UI2.WinForms.Guna2Button gunacheck;
        private Guna.UI2.WinForms.Guna2Button buttoneyes2;
        private Guna.UI2.WinForms.Guna2Button buttoneyes1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button gunaexit;
    }
}