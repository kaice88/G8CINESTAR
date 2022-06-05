namespace GUI
{
    partial class Form_ResetMK1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ResetMK1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsendemail = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelfail = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btback = new Guna.UI2.WinForms.Guna2Button();
            this.btexit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(610, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 96;
            this.label1.Text = "Forgot your password ? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(607, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 34);
            this.label2.TabIndex = 100;
            this.label2.Text = "Please enter your registered email address. \nWe will send instructions to help re" +
    "set your password.";
            // 
            // buttonsendemail
            // 
            this.buttonsendemail.BorderRadius = 20;
            this.buttonsendemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsendemail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonsendemail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonsendemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonsendemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonsendemail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonsendemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsendemail.ForeColor = System.Drawing.Color.White;
            this.buttonsendemail.Location = new System.Drawing.Point(610, 288);
            this.buttonsendemail.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsendemail.Name = "buttonsendemail";
            this.buttonsendemail.Size = new System.Drawing.Size(275, 42);
            this.buttonsendemail.TabIndex = 105;
            this.buttonsendemail.Text = "SEND RESET INSTRUCTIONS";
            this.buttonsendemail.Click += new System.EventHandler(this.buttonsendemail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(610, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "_____________________________";
            // 
            // labelfail
            // 
            this.labelfail.AutoSize = true;
            this.labelfail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.labelfail.Location = new System.Drawing.Point(610, 192);
            this.labelfail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfail.Name = "labelfail";
            this.labelfail.Size = new System.Drawing.Size(0, 17);
            this.labelfail.TabIndex = 118;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtemail
            // 
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtemail.BorderRadius = 20;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtemail.IconLeft")));
            this.txtemail.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtemail.Location = new System.Drawing.Point(610, 219);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtemail.PlaceholderText = "Email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(278, 49);
            this.txtemail.TabIndex = 104;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.btback);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(972, 584);
            this.guna2Panel1.TabIndex = 224;
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.Color.Transparent;
            this.btback.BorderRadius = 21;
            this.btback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.btback.Image = ((System.Drawing.Image)(resources.GetObject("btback.Image")));
            this.btback.ImageSize = new System.Drawing.Size(40, 40);
            this.btback.Location = new System.Drawing.Point(6, 6);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(55, 45);
            this.btback.TabIndex = 135;
            this.btback.Click += new System.EventHandler(this.gunaback_Click);
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
            this.btexit.TabIndex = 225;
            this.btexit.Click += new System.EventHandler(this.gunaexit_Click);
            // 
            // Form_ResetMK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.labelfail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonsendemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ResetMK1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResetMatKhau1";
            this.Load += new System.EventHandler(this.Form_ResetMK1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2Button buttonsendemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelfail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btback;
        private Guna.UI2.WinForms.Guna2Button btexit;
    }
}