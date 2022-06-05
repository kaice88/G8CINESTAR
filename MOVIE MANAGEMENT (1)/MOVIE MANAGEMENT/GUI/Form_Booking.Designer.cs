namespace GUI
{
    partial class Form_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Booking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.buttonexit = new Guna.UI2.WinForms.Guna2Button();
            this.page2 = new System.Windows.Forms.TabPage();
            this.panelbooking = new Guna.UI2.WinForms.Guna2Panel();
            this.butCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lbrewardpoint = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtpoint = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btbooking = new Guna.UI2.WinForms.Guna2Button();
            this.txttotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsub = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.movie_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seat_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedule_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.paneltrans = new Guna.UI2.WinForms.Guna2Panel();
            this.tab1.SuspendLayout();
            this.page1.SuspendLayout();
            this.panelbooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.page1);
            this.tab1.Controls.Add(this.page2);
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Location = new System.Drawing.Point(22, 33);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(956, 605);
            this.tab1.TabIndex = 113;
            // 
            // page1
            // 
            this.page1.AutoScroll = true;
            this.page1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.page1.Controls.Add(this.buttonexit);
            this.page1.ForeColor = System.Drawing.Color.Black;
            this.page1.Location = new System.Drawing.Point(4, 36);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(948, 565);
            this.page1.TabIndex = 0;
            this.page1.Text = "NOW PLAYING";
            // 
            // buttonexit
            // 
            this.buttonexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonexit.ForeColor = System.Drawing.Color.White;
            this.buttonexit.Image = ((System.Drawing.Image)(resources.GetObject("buttonexit.Image")));
            this.buttonexit.Location = new System.Drawing.Point(895, 6);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(47, 45);
            this.buttonexit.TabIndex = 109;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // page2
            // 
            this.page2.AutoScroll = true;
            this.page2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.page2.Location = new System.Drawing.Point(4, 36);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(3);
            this.page2.Size = new System.Drawing.Size(948, 565);
            this.page2.TabIndex = 1;
            this.page2.Text = "COMING SOON";
            // 
            // panelbooking
            // 
            this.panelbooking.Controls.Add(this.butCancel);
            this.panelbooking.Controls.Add(this.lbrewardpoint);
            this.panelbooking.Controls.Add(this.lbPhone);
            this.panelbooking.Controls.Add(this.lbName);
            this.panelbooking.Controls.Add(this.txtpoint);
            this.panelbooking.Controls.Add(this.txtphone);
            this.panelbooking.Controls.Add(this.label12);
            this.panelbooking.Controls.Add(this.guna2CheckBox1);
            this.panelbooking.Controls.Add(this.label9);
            this.panelbooking.Controls.Add(this.label8);
            this.panelbooking.Controls.Add(this.btbooking);
            this.panelbooking.Controls.Add(this.txttotal);
            this.panelbooking.Controls.Add(this.label7);
            this.panelbooking.Controls.Add(this.txtdiscount);
            this.panelbooking.Controls.Add(this.label6);
            this.panelbooking.Controls.Add(this.txtsub);
            this.panelbooking.Controls.Add(this.label2);
            this.panelbooking.Controls.Add(this.dataGridView1);
            this.panelbooking.Location = new System.Drawing.Point(987, 26);
            this.panelbooking.Name = "panelbooking";
            this.panelbooking.Size = new System.Drawing.Size(288, 618);
            this.panelbooking.TabIndex = 115;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Transparent;
            this.butCancel.BorderRadius = 8;
            this.butCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(181, 7);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(101, 42);
            this.butCancel.TabIndex = 182;
            this.butCancel.Text = "Cancel Ticket";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // lbrewardpoint
            // 
            this.lbrewardpoint.AutoSize = true;
            this.lbrewardpoint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrewardpoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbrewardpoint.Location = new System.Drawing.Point(159, 160);
            this.lbrewardpoint.Name = "lbrewardpoint";
            this.lbrewardpoint.Size = new System.Drawing.Size(65, 21);
            this.lbrewardpoint.TabIndex = 181;
            this.lbrewardpoint.Text = "Name :";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbPhone.Location = new System.Drawing.Point(171, 130);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(65, 21);
            this.lbPhone.TabIndex = 180;
            this.lbPhone.Text = "Name :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lbName.Location = new System.Drawing.Point(102, 100);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(70, 21);
            this.lbName.TabIndex = 179;
            this.lbName.Text = "Name : ";
            // 
            // txtpoint
            // 
            this.txtpoint.AutoSize = true;
            this.txtpoint.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtpoint.Location = new System.Drawing.Point(5, 159);
            this.txtpoint.Name = "txtpoint";
            this.txtpoint.Size = new System.Drawing.Size(118, 19);
            this.txtpoint.TabIndex = 178;
            this.txtpoint.Text = "Reward Point :";
            // 
            // txtphone
            // 
            this.txtphone.AutoSize = true;
            this.txtphone.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtphone.Location = new System.Drawing.Point(5, 129);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(133, 19);
            this.txtphone.TabIndex = 177;
            this.txtphone.Text = "Phone Number :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label12.Location = new System.Drawing.Point(5, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 176;
            this.label12.Text = "Name :";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.Brown;
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.Brown;
            this.guna2CheckBox1.Location = new System.Drawing.Point(10, 57);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(218, 24);
            this.guna2CheckBox1.TabIndex = 175;
            this.guna2CheckBox1.Text = "G8CINESTAR Membership";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Brown;
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 2;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label9.Location = new System.Drawing.Point(4, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 36);
            this.label9.TabIndex = 174;
            this.label9.Text = "CUSTOMER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(52, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 22);
            this.label8.TabIndex = 173;
            // 
            // btbooking
            // 
            this.btbooking.BackColor = System.Drawing.Color.Transparent;
            this.btbooking.BorderRadius = 8;
            this.btbooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btbooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btbooking.ForeColor = System.Drawing.Color.White;
            this.btbooking.Location = new System.Drawing.Point(195, 570);
            this.btbooking.Name = "btbooking";
            this.btbooking.Size = new System.Drawing.Size(77, 35);
            this.btbooking.TabIndex = 172;
            this.btbooking.Text = "Booking";
            this.btbooking.Click += new System.EventHandler(this.btbooking_Click);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.Transparent;
            this.txttotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txttotal.BorderRadius = 10;
            this.txttotal.BorderThickness = 2;
            this.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotal.DefaultText = "0";
            this.txttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttotal.Location = new System.Drawing.Point(131, 526);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttotal.Name = "txttotal";
            this.txttotal.PasswordChar = '\0';
            this.txttotal.PlaceholderText = "";
            this.txttotal.SelectedText = "";
            this.txttotal.Size = new System.Drawing.Size(141, 36);
            this.txttotal.TabIndex = 170;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label7.Location = new System.Drawing.Point(6, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 171;
            this.label7.Text = "Total :";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.Color.Transparent;
            this.txtdiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtdiscount.BorderRadius = 10;
            this.txtdiscount.BorderThickness = 2;
            this.txtdiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiscount.DefaultText = "0";
            this.txtdiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtdiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiscount.Location = new System.Drawing.Point(131, 484);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.PasswordChar = '\0';
            this.txtdiscount.PlaceholderText = "";
            this.txtdiscount.SelectedText = "";
            this.txtdiscount.Size = new System.Drawing.Size(141, 36);
            this.txtdiscount.TabIndex = 168;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label6.Location = new System.Drawing.Point(6, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 169;
            this.label6.Text = "Discount :";
            // 
            // txtsub
            // 
            this.txtsub.BackColor = System.Drawing.Color.Transparent;
            this.txtsub.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtsub.BorderRadius = 10;
            this.txtsub.BorderThickness = 2;
            this.txtsub.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsub.DefaultText = "0";
            this.txtsub.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsub.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsub.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsub.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtsub.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsub.Location = new System.Drawing.Point(131, 442);
            this.txtsub.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsub.Name = "txtsub";
            this.txtsub.PasswordChar = '\0';
            this.txtsub.PlaceholderText = "";
            this.txtsub.SelectedText = "";
            this.txtsub.Size = new System.Drawing.Size(141, 36);
            this.txtsub.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(6, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 167;
            this.label2.Text = "Sub Total :";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movie_name,
            this.seat_name,
            this.seat_price,
            this.schedule_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(5, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(267, 241);
            this.dataGridView1.TabIndex = 165;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            this.dataGridView1.ThemeStyle.ReadOnly = true;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.VirtualMode = true;
            // 
            // movie_name
            // 
            this.movie_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.movie_name.DataPropertyName = "movie_name";
            this.movie_name.HeaderText = "Movie Name";
            this.movie_name.Name = "movie_name";
            this.movie_name.ReadOnly = true;
            this.movie_name.Width = 95;
            // 
            // seat_name
            // 
            this.seat_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seat_name.DataPropertyName = "seat_name";
            this.seat_name.HeaderText = "Seat Type";
            this.seat_name.MinimumWidth = 6;
            this.seat_name.Name = "seat_name";
            this.seat_name.ReadOnly = true;
            this.seat_name.Width = 95;
            // 
            // seat_price
            // 
            this.seat_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seat_price.DataPropertyName = "seat_price";
            this.seat_price.HeaderText = "Price";
            this.seat_price.MinimumWidth = 6;
            this.seat_price.Name = "seat_price";
            this.seat_price.ReadOnly = true;
            this.seat_price.Width = 80;
            // 
            // schedule_id
            // 
            this.schedule_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.schedule_id.DataPropertyName = "schedule_id";
            this.schedule_id.HeaderText = "Schedule_id";
            this.schedule_id.Name = "schedule_id";
            this.schedule_id.ReadOnly = true;
            this.schedule_id.Width = 50;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // paneltrans
            // 
            this.paneltrans.Location = new System.Drawing.Point(12, 26);
            this.paneltrans.Name = "paneltrans";
            this.paneltrans.Size = new System.Drawing.Size(977, 618);
            this.paneltrans.TabIndex = 114;
            // 
            // Form_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1282, 656);
            this.Controls.Add(this.panelbooking);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.paneltrans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Booking";
            this.Load += new System.EventHandler(this.Form_Booking_Load);
            this.tab1.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.panelbooking.ResumeLayout(false);
            this.panelbooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.TabPage page2;
        private Guna.UI2.WinForms.Guna2Panel panelbooking;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel paneltrans;
        private System.Windows.Forms.Label lbrewardpoint;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label txtpoint;
        private System.Windows.Forms.Label txtphone;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btbooking;
        private Guna.UI2.WinForms.Guna2TextBox txttotal;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtdiscount;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtsub;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule_id;
        private Guna.UI2.WinForms.Guna2Button buttonexit;
        private Guna.UI2.WinForms.Guna2Button butCancel;
    }
}