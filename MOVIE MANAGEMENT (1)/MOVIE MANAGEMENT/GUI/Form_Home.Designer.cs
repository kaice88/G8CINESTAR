namespace GUI
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panelDropDown = new Guna.UI2.WinForms.Guna2Panel();
            this.btaccountname = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btbooking = new Guna.UI2.WinForms.Guna2Button();
            this.btmanage = new Guna.UI2.WinForms.Guna2Button();
            this.panelDropDown.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Button2.Location = new System.Drawing.Point(0, 31);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(220, 28);
            this.guna2Button2.TabIndex = 222;
            this.guna2Button2.Text = "CHANGE PASSWORD";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Button3.Location = new System.Drawing.Point(0, 59);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(220, 30);
            this.guna2Button3.TabIndex = 223;
            this.guna2Button3.Text = "EXIT";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.guna2Button3);
            this.panelDropDown.Controls.Add(this.guna2Button2);
            this.panelDropDown.Controls.Add(this.btaccountname);
            this.panelDropDown.Location = new System.Drawing.Point(738, 12);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(220, 89);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(220, 35);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(220, 35);
            this.panelDropDown.TabIndex = 220;
            // 
            // btaccountname
            // 
            this.btaccountname.BorderColor = System.Drawing.Color.White;
            this.btaccountname.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btaccountname.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btaccountname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btaccountname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btaccountname.Dock = System.Windows.Forms.DockStyle.Top;
            this.btaccountname.FillColor = System.Drawing.Color.Transparent;
            this.btaccountname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btaccountname.ForeColor = System.Drawing.Color.White;
            this.btaccountname.Image = global::GUI.Properties.Resources.comment_user_free_icon_font;
            this.btaccountname.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btaccountname.ImageSize = new System.Drawing.Size(25, 25);
            this.btaccountname.Location = new System.Drawing.Point(0, 0);
            this.btaccountname.Margin = new System.Windows.Forms.Padding(2);
            this.btaccountname.Name = "btaccountname";
            this.btaccountname.Size = new System.Drawing.Size(220, 31);
            this.btaccountname.TabIndex = 221;
            this.btaccountname.Text = "LOG IN";
            this.btaccountname.Click += new System.EventHandler(this.btaccountname_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.btbooking);
            this.guna2Panel1.Controls.Add(this.btmanage);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(968, 584);
            this.guna2Panel1.TabIndex = 222;
            // 
            // btbooking
            // 
            this.btbooking.BackColor = System.Drawing.Color.Transparent;
            this.btbooking.BorderColor = System.Drawing.Color.White;
            this.btbooking.BorderThickness = 2;
            this.btbooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbooking.FillColor = System.Drawing.Color.Transparent;
            this.btbooking.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbooking.ForeColor = System.Drawing.Color.White;
            this.btbooking.Location = new System.Drawing.Point(789, 520);
            this.btbooking.Margin = new System.Windows.Forms.Padding(2);
            this.btbooking.Name = "btbooking";
            this.btbooking.Size = new System.Drawing.Size(140, 38);
            this.btbooking.TabIndex = 132;
            this.btbooking.Text = "BOOKING";
            this.btbooking.Click += new System.EventHandler(this.btbooking_Click);
            // 
            // btmanage
            // 
            this.btmanage.BackColor = System.Drawing.Color.Transparent;
            this.btmanage.BorderColor = System.Drawing.Color.White;
            this.btmanage.BorderThickness = 2;
            this.btmanage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btmanage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btmanage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btmanage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btmanage.FillColor = System.Drawing.Color.Transparent;
            this.btmanage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmanage.ForeColor = System.Drawing.Color.White;
            this.btmanage.Location = new System.Drawing.Point(619, 520);
            this.btmanage.Margin = new System.Windows.Forms.Padding(2);
            this.btmanage.Name = "btmanage";
            this.btmanage.Size = new System.Drawing.Size(140, 38);
            this.btmanage.TabIndex = 131;
            this.btmanage.Text = "MANAGEMENT";
            this.btmanage.Click += new System.EventHandler(this.btmanage_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFunction";
            this.Load += new System.EventHandler(this.FormFunction_Load);
            this.panelDropDown.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btmanage;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel panelDropDown;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btaccountname;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btbooking;
    }
}