namespace GUI
{
    partial class Form_SeatMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SeatMap));
            this.btSeatType = new Guna.UI2.WinForms.Guna2Button();
            this.cbbRoomName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoghe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsohang = new Guna.UI2.WinForms.Guna2TextBox();
            this.butsetup = new Guna.UI2.WinForms.Guna2Button();
            this.btOK = new Guna.UI2.WinForms.Guna2Button();
            this.gunaexit = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSeatType
            // 
            this.btSeatType.BackColor = System.Drawing.Color.Transparent;
            this.btSeatType.BorderRadius = 8;
            this.btSeatType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeatType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSeatType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSeatType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSeatType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSeatType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btSeatType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btSeatType.ForeColor = System.Drawing.Color.White;
            this.btSeatType.Location = new System.Drawing.Point(21, 78);
            this.btSeatType.Name = "btSeatType";
            this.btSeatType.Size = new System.Drawing.Size(102, 38);
            this.btSeatType.TabIndex = 90;
            this.btSeatType.Text = "Seat Type";
            this.btSeatType.Click += new System.EventHandler(this.btSeatType_Click);
            // 
            // cbbRoomName
            // 
            this.cbbRoomName.BackColor = System.Drawing.Color.Transparent;
            this.cbbRoomName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.cbbRoomName.BorderRadius = 10;
            this.cbbRoomName.BorderThickness = 2;
            this.cbbRoomName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoomName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.cbbRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbRoomName.ItemHeight = 29;
            this.cbbRoomName.Location = new System.Drawing.Point(295, 46);
            this.cbbRoomName.Name = "cbbRoomName";
            this.cbbRoomName.Size = new System.Drawing.Size(160, 35);
            this.cbbRoomName.TabIndex = 91;
            this.cbbRoomName.SelectedIndexChanged += new System.EventHandler(this.cbbRoomName_SelectedIndexChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(295, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "Room Name";
            // 
            // txtsoghe
            // 
            this.txtsoghe.BackColor = System.Drawing.Color.Transparent;
            this.txtsoghe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtsoghe.BorderRadius = 10;
            this.txtsoghe.BorderThickness = 2;
            this.txtsoghe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoghe.DefaultText = "";
            this.txtsoghe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsoghe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsoghe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsoghe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsoghe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsoghe.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtsoghe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsoghe.Location = new System.Drawing.Point(502, 43);
            this.txtsoghe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsoghe.Name = "txtsoghe";
            this.txtsoghe.PasswordChar = '\0';
            this.txtsoghe.PlaceholderText = "";
            this.txtsoghe.SelectedText = "";
            this.txtsoghe.Size = new System.Drawing.Size(159, 36);
            this.txtsoghe.TabIndex = 94;
            // 
            // txtsohang
            // 
            this.txtsohang.BackColor = System.Drawing.Color.Transparent;
            this.txtsohang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtsohang.BorderRadius = 10;
            this.txtsohang.BorderThickness = 2;
            this.txtsohang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsohang.DefaultText = "";
            this.txtsohang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsohang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsohang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsohang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsohang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsohang.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtsohang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsohang.Location = new System.Drawing.Point(708, 43);
            this.txtsohang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsohang.Name = "txtsohang";
            this.txtsohang.PasswordChar = '\0';
            this.txtsohang.PlaceholderText = "";
            this.txtsohang.SelectedText = "";
            this.txtsohang.Size = new System.Drawing.Size(159, 36);
            this.txtsohang.TabIndex = 95;
            // 
            // butsetup
            // 
            this.butsetup.BackColor = System.Drawing.Color.Transparent;
            this.butsetup.BorderRadius = 8;
            this.butsetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butsetup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butsetup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butsetup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butsetup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butsetup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butsetup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.butsetup.ForeColor = System.Drawing.Color.White;
            this.butsetup.Location = new System.Drawing.Point(914, 43);
            this.butsetup.Name = "butsetup";
            this.butsetup.Size = new System.Drawing.Size(88, 36);
            this.butsetup.TabIndex = 96;
            this.butsetup.Text = "Set Up";
            this.butsetup.Click += new System.EventHandler(this.butsetup_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Transparent;
            this.btOK.BorderRadius = 8;
            this.btOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btOK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btOK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btOK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(12, 504);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(88, 36);
            this.btOK.TabIndex = 97;
            this.btOK.Text = "OK";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
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
            this.gunaexit.Location = new System.Drawing.Point(984, 6);
            this.gunaexit.Name = "gunaexit";
            this.gunaexit.Size = new System.Drawing.Size(32, 31);
            this.gunaexit.TabIndex = 123;
            this.gunaexit.Click += new System.EventHandler(this.gunaexit_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderColor = System.Drawing.Color.White;
            this.panel2.BorderRadius = 10;
            this.panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel2.BorderThickness = 2;
            this.panel2.Location = new System.Drawing.Point(18, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 327);
            this.panel2.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 129);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(233, 345);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Location = new System.Drawing.Point(271, 101);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(745, 455);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.guna2Panel3.Location = new System.Drawing.Point(15, 5);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(716, 32);
            this.guna2Panel3.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 30);
            this.label1.TabIndex = 93;
            this.label1.Text = "SCREEN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 10;
            this.panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel1.BorderThickness = 2;
            this.panel1.Location = new System.Drawing.Point(286, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 399);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(500, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 124;
            this.label2.Text = "Number of seat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(708, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 125;
            this.label4.Text = "Number of row";
            // 
            // Form_SeatMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1033, 575);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbRoomName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaexit);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.butsetup);
            this.Controls.Add(this.btSeatType);
            this.Controls.Add(this.txtsohang);
            this.Controls.Add(this.txtsoghe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SeatMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeatMap";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btSeatType;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRoomName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtsohang;
        private Guna.UI2.WinForms.Guna2TextBox txtsoghe;
        private Guna.UI2.WinForms.Guna2Button btOK;
        private Guna.UI2.WinForms.Guna2Button butsetup;
        private Guna.UI2.WinForms.Guna2Button gunaexit;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}