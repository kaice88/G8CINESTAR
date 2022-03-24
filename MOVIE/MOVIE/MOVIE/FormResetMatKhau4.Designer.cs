namespace MOVIE
{
    partial class FormResetMatKhau4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResetMatKhau4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaback = new Guna.UI2.WinForms.Guna2Button();
            this.gunaChange = new Guna.UI2.WinForms.Guna2Button();
            this.txtcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // gunaback
            // 
            this.gunaback.BorderRadius = 10;
            this.gunaback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaback.FillColor = System.Drawing.Color.White;
            this.gunaback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.gunaback.Location = new System.Drawing.Point(423, 43);
            this.gunaback.Name = "gunaback";
            this.gunaback.Size = new System.Drawing.Size(78, 26);
            this.gunaback.TabIndex = 113;
            this.gunaback.Text = "< Back";
            this.gunaback.Click += new System.EventHandler(this.gunaback_Click);
            // 
            // gunaChange
            // 
            this.gunaChange.BorderRadius = 20;
            this.gunaChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(90)))), ((int)(((byte)(70)))));
            this.gunaChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaChange.ForeColor = System.Drawing.Color.White;
            this.gunaChange.Location = new System.Drawing.Point(546, 378);
            this.gunaChange.Margin = new System.Windows.Forms.Padding(2);
            this.gunaChange.Name = "gunaChange";
            this.gunaChange.Size = new System.Drawing.Size(275, 42);
            this.gunaChange.TabIndex = 112;
            this.gunaChange.Text = "CHANGE PASSWORD";
            this.gunaChange.Click += new System.EventHandler(this.gunaChange_Click);
            // 
            // txtcode
            // 
            this.txtcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
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
            this.txtcode.Location = new System.Drawing.Point(546, 297);
            this.txtcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.txtcode.PlaceholderText = "Security code";
            this.txtcode.SelectedText = "";
            this.txtcode.Size = new System.Drawing.Size(278, 49);
            this.txtcode.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.label4.Location = new System.Drawing.Point(546, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "_________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(546, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 34);
            this.label2.TabIndex = 109;
            this.label2.Text = "Please check the code in your email. This code \r\nconsists of 6 numbers.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(45)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(546, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 27);
            this.label1.TabIndex = 108;
            this.label1.Text = "Enter the security code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(546, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 17);
            this.label5.TabIndex = 115;
            this.label5.Text = "The security code is incorrect. Try again.";
            // 
            // FormResetMatKhau4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaback);
            this.Controls.Add(this.gunaChange);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormResetMatKhau4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResetMatKhau4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button gunaback;
        private Guna.UI2.WinForms.Guna2Button gunaChange;
        private Guna.UI2.WinForms.Guna2TextBox txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}