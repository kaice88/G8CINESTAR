namespace GUI
{
    partial class Form_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChangePassword));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttoneyescl = new Guna.UI2.WinForms.Guna2Button();
            this.labelfail = new System.Windows.Forms.Label();
            this.txtconfirmpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnewpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonchange = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.txtcurrentpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttoneyes1 = new Guna.UI2.WinForms.Guna2Button();
            this.buttoneyes2 = new Guna.UI2.WinForms.Guna2Button();
            this.gunacheck = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaback = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
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
            this.buttoneyescl.Location = new System.Drawing.Point(863, 326);
            this.buttoneyescl.Name = "buttoneyescl";
            this.buttoneyescl.Size = new System.Drawing.Size(21, 21);
            this.buttoneyescl.TabIndex = 136;
            // 
            // labelfail
            // 
            this.labelfail.AutoSize = true;
            this.labelfail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.labelfail.Location = new System.Drawing.Point(612, 214);
            this.labelfail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfail.Name = "labelfail";
            this.labelfail.Size = new System.Drawing.Size(0, 17);
            this.labelfail.TabIndex = 134;
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
            this.txtconfirmpass.Location = new System.Drawing.Point(613, 365);
            this.txtconfirmpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.PasswordChar = '●';
            this.txtconfirmpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtconfirmpass.PlaceholderText = "Confirm  password";
            this.txtconfirmpass.SelectedText = "";
            this.txtconfirmpass.Size = new System.Drawing.Size(278, 49);
            this.txtconfirmpass.TabIndex = 132;
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
            this.txtnewpass.Location = new System.Drawing.Point(613, 308);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '●';
            this.txtnewpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtnewpass.PlaceholderText = "New password";
            this.txtnewpass.SelectedText = "";
            this.txtnewpass.Size = new System.Drawing.Size(278, 49);
            this.txtnewpass.TabIndex = 131;
            this.txtnewpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(610, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 34);
            this.label2.TabIndex = 130;
            this.label2.Text = "Minimum 10 characters. Must contain upper \r\nand lowercase, numbers and symbols.";
            // 
            // buttonchange
            // 
            this.buttonchange.BorderRadius = 20;
            this.buttonchange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonchange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonchange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonchange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonchange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonchange.ForeColor = System.Drawing.Color.White;
            this.buttonchange.Location = new System.Drawing.Point(613, 433);
            this.buttonchange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(275, 42);
            this.buttonchange.TabIndex = 129;
            this.buttonchange.Text = "CHANGE PASSWORD";
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(610, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "___________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(610, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 127;
            this.label1.Text = "Change your password";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            // 
            // txtcurrentpass
            // 
            this.txtcurrentpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtcurrentpass.BorderRadius = 20;
            this.txtcurrentpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcurrentpass.DefaultText = "";
            this.txtcurrentpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcurrentpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcurrentpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcurrentpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcurrentpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcurrentpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtcurrentpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcurrentpass.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtcurrentpass.Location = new System.Drawing.Point(613, 251);
            this.txtcurrentpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcurrentpass.Name = "txtcurrentpass";
            this.txtcurrentpass.PasswordChar = '●';
            this.txtcurrentpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtcurrentpass.PlaceholderText = "Current password";
            this.txtcurrentpass.SelectedText = "";
            this.txtcurrentpass.Size = new System.Drawing.Size(278, 49);
            this.txtcurrentpass.TabIndex = 140;
            this.txtcurrentpass.UseSystemPasswordChar = true;
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
            this.buttoneyes1.Location = new System.Drawing.Point(853, 321);
            this.buttoneyes1.Name = "buttoneyes1";
            this.buttoneyes1.Size = new System.Drawing.Size(31, 30);
            this.buttoneyes1.TabIndex = 139;
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
            this.buttoneyes2.Location = new System.Drawing.Point(853, 321);
            this.buttoneyes2.Name = "buttoneyes2";
            this.buttoneyes2.Size = new System.Drawing.Size(31, 30);
            this.buttoneyes2.TabIndex = 138;
            this.buttoneyes2.Click += new System.EventHandler(this.buttoneyes2_Click);
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
            this.gunacheck.Location = new System.Drawing.Point(851, 374);
            this.gunacheck.Name = "gunacheck";
            this.gunacheck.Size = new System.Drawing.Size(31, 30);
            this.gunacheck.TabIndex = 137;
            this.gunacheck.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.gunaback);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(973, 584);
            this.guna2Panel1.TabIndex = 223;
            // 
            // gunaback
            // 
            this.gunaback.BackColor = System.Drawing.Color.Transparent;
            this.gunaback.BorderRadius = 21;
            this.gunaback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.gunaback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.gunaback.Image = ((System.Drawing.Image)(resources.GetObject("gunaback.Image")));
            this.gunaback.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaback.Location = new System.Drawing.Point(6, 6);
            this.gunaback.Name = "gunaback";
            this.gunaback.Size = new System.Drawing.Size(55, 45);
            this.gunaback.TabIndex = 135;
            this.gunaback.Click += new System.EventHandler(this.gunaback_Click_1);
            // 
            // Form_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.txtcurrentpass);
            this.Controls.Add(this.buttoneyes1);
            this.Controls.Add(this.buttoneyes2);
            this.Controls.Add(this.gunacheck);
            this.Controls.Add(this.buttoneyescl);
            this.Controls.Add(this.labelfail);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonchange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangePassword";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button buttoneyes1;
        private Guna.UI2.WinForms.Guna2Button buttoneyes2;
        private Guna.UI2.WinForms.Guna2Button gunacheck;
        private Guna.UI2.WinForms.Guna2Button buttoneyescl;
        private Guna.UI2.WinForms.Guna2Button gunaback;
        private System.Windows.Forms.Label labelfail;
        private Guna.UI2.WinForms.Guna2TextBox txtconfirmpass;
        private Guna.UI2.WinForms.Guna2TextBox txtnewpass;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button buttonchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox txtcurrentpass;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}