namespace GUI
{
    partial class Form_ResetMK2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ResetMK2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaChange = new Guna.UI2.WinForms.Guna2Button();
            this.labelfail = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btback = new Guna.UI2.WinForms.Guna2Button();
            this.gunaexit = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 96;
            this.label1.Text = "Enter the security code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(610, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 34);
            this.label2.TabIndex = 100;
            this.label2.Text = "Please check the code in your email. This code \r\nconsists of 6 numbers.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(610, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "_________________________";
            // 
            // gunaChange
            // 
            this.gunaChange.BorderRadius = 20;
            this.gunaChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.gunaChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaChange.ForeColor = System.Drawing.Color.White;
            this.gunaChange.Location = new System.Drawing.Point(610, 296);
            this.gunaChange.Margin = new System.Windows.Forms.Padding(2);
            this.gunaChange.Name = "gunaChange";
            this.gunaChange.Size = new System.Drawing.Size(275, 42);
            this.gunaChange.TabIndex = 105;
            this.gunaChange.Text = "CHANGE PASSWORD";
            this.gunaChange.Click += new System.EventHandler(this.gunaChange_Click);
            // 
            // labelfail
            // 
            this.labelfail.AutoSize = true;
            this.labelfail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.labelfail.Location = new System.Drawing.Point(610, 186);
            this.labelfail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfail.Name = "labelfail";
            this.labelfail.Size = new System.Drawing.Size(0, 17);
            this.labelfail.TabIndex = 116;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtcode
            // 
            this.txtcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtcode.BorderRadius = 20;
            this.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcode.DefaultText = "";
            this.txtcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcode.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtcode.IconLeft")));
            this.txtcode.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtcode.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtcode.Location = new System.Drawing.Point(610, 215);
            this.txtcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtcode.PlaceholderText = "Security code";
            this.txtcode.SelectedText = "";
            this.txtcode.Size = new System.Drawing.Size(278, 49);
            this.txtcode.TabIndex = 104;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.gunaexit);
            this.guna2Panel1.Controls.Add(this.btback);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(979, 584);
            this.guna2Panel1.TabIndex = 225;
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
            // gunaexit
            // 
            this.gunaexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.gunaexit.BorderRadius = 10;
            this.gunaexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.gunaexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gunaexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.gunaexit.Image = global::GUI.Properties.Resources.cross_free_icon_font;
            this.gunaexit.Location = new System.Drawing.Point(927, 3);
            this.gunaexit.Name = "gunaexit";
            this.gunaexit.Size = new System.Drawing.Size(32, 31);
            this.gunaexit.TabIndex = 136;
            this.gunaexit.Click += new System.EventHandler(this.gunaexit_Click);
            // 
            // Form_ResetMK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.labelfail);
            this.Controls.Add(this.gunaChange);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ResetMK2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ssss";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtcode;
        private Guna.UI2.WinForms.Guna2Button gunaChange;
        private System.Windows.Forms.Label labelfail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btback;
        private Guna.UI2.WinForms.Guna2Button gunaexit;
    }
}