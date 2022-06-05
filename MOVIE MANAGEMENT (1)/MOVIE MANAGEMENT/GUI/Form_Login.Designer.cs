namespace GUI
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.buttonfogot = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonlogin = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelfail = new System.Windows.Forms.Label();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.buttoneyescl = new Guna.UI2.WinForms.Guna2Button();
            this.buttoneyes = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.buttoneyes1 = new Guna.UI2.WinForms.Guna2Button();
            this.buttoneyes2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btexit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonfogot
            // 
            this.buttonfogot.BorderRadius = 10;
            this.buttonfogot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfogot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonfogot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonfogot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonfogot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonfogot.FillColor = System.Drawing.Color.White;
            this.buttonfogot.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfogot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonfogot.Location = new System.Drawing.Point(660, 448);
            this.buttonfogot.Name = "buttonfogot";
            this.buttonfogot.Size = new System.Drawing.Size(180, 24);
            this.buttonfogot.TabIndex = 78;
            this.buttonfogot.Text = "Forgot your password?";
            this.buttonfogot.Click += new System.EventHandler(this.buttonfogot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(610, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 34);
            this.label2.TabIndex = 77;
            this.label2.Text = "If you are already a member you can login \r\nwith your username and password.";
            // 
            // buttonlogin
            // 
            this.buttonlogin.BorderRadius = 20;
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(610, 354);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(275, 42);
            this.buttonlogin.TabIndex = 75;
            this.buttonlogin.Text = "LOG IN";
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(610, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "_____________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(610, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 69;
            this.label1.Text = "Account Login";
            // 
            // txtusername
            // 
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtusername.BorderRadius = 20;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtusername.IconLeft")));
            this.txtusername.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtusername.IconLeftSize = new System.Drawing.Size(22, 22);
            this.txtusername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtusername.Location = new System.Drawing.Point(610, 209);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtusername.PlaceholderText = "Username";
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(278, 49);
            this.txtusername.TabIndex = 91;
            // 
            // labelfail
            // 
            this.labelfail.AutoSize = true;
            this.labelfail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.labelfail.Location = new System.Drawing.Point(610, 160);
            this.labelfail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfail.Name = "labelfail";
            this.labelfail.Size = new System.Drawing.Size(0, 17);
            this.labelfail.TabIndex = 95;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtpassword.BorderRadius = 20;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpassword.IconLeft")));
            this.txtpassword.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtpassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtpassword.Location = new System.Drawing.Point(610, 276);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(278, 49);
            this.txtpassword.TabIndex = 93;
            this.txtpassword.UseSystemPasswordChar = true;
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
            this.buttoneyescl.Location = new System.Drawing.Point(859, 290);
            this.buttoneyescl.Name = "buttoneyescl";
            this.buttoneyescl.Size = new System.Drawing.Size(21, 21);
            this.buttoneyescl.TabIndex = 96;
            // 
            // buttoneyes
            // 
            this.buttoneyes.Animated = true;
            this.buttoneyes.BackColor = System.Drawing.Color.Transparent;
            this.buttoneyes.BorderRadius = 8;
            this.buttoneyes.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttoneyes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttoneyes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttoneyes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttoneyes.FillColor = System.Drawing.Color.White;
            this.buttoneyes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttoneyes.ForeColor = System.Drawing.Color.White;
            this.buttoneyes.ImageSize = new System.Drawing.Size(25, 25);
            this.buttoneyes.Location = new System.Drawing.Point(859, 290);
            this.buttoneyes.Name = "buttoneyes";
            this.buttoneyes.Size = new System.Drawing.Size(21, 21);
            this.buttoneyes.TabIndex = 97;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label8.Location = new System.Drawing.Point(610, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "_____________________________";
            // 
            // buttoneyes1
            // 
            this.buttoneyes1.Animated = true;
            this.buttoneyes1.BackColor = System.Drawing.Color.Transparent;
            this.buttoneyes1.BorderRadius = 8;
            this.buttoneyes1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.buttoneyes1.Location = new System.Drawing.Point(849, 285);
            this.buttoneyes1.Name = "buttoneyes1";
            this.buttoneyes1.Size = new System.Drawing.Size(31, 30);
            this.buttoneyes1.TabIndex = 126;
            this.buttoneyes1.Click += new System.EventHandler(this.buttoneyes1_Click);
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
            this.buttoneyes2.Location = new System.Drawing.Point(849, 285);
            this.buttoneyes2.Name = "buttoneyes2";
            this.buttoneyes2.Size = new System.Drawing.Size(31, 30);
            this.buttoneyes2.TabIndex = 127;
            this.buttoneyes2.Click += new System.EventHandler(this.buttoneyes2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.btexit);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(980, 584);
            this.guna2Panel1.TabIndex = 225;
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btexit.BorderRadius = 10;
            this.btexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.btexit.Image = global::GUI.Properties.Resources.cross_free_icon_font;
            this.btexit.Location = new System.Drawing.Point(927, 3);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(32, 31);
            this.btexit.TabIndex = 226;
            this.btexit.Click += new System.EventHandler(this.gunaexit_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.buttoneyes1);
            this.Controls.Add(this.buttoneyes2);
            this.Controls.Add(this.buttoneyes);
            this.Controls.Add(this.buttoneyescl);
            this.Controls.Add(this.labelfail);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.buttonfogot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap1";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button buttonfogot;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private System.Windows.Forms.Label labelfail;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button buttoneyescl;
        private Guna.UI2.WinForms.Guna2Button buttoneyes;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button buttoneyes1;
        private Guna.UI2.WinForms.Guna2Button buttoneyes2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btexit;
    }
}