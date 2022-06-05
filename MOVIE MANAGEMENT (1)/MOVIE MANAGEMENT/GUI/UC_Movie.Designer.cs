namespace GUI
{
    partial class UC_Movie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Movie));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbgenres = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtlength = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtrelease = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butGenres = new Guna.UI2.WinForms.Guna2Button();
            this.buttonReset = new Guna.UI2.WinForms.Guna2Button();
            this.butSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btimage = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picbox_imagemovie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.movie_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_genres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_release = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_imagemovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(41, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 69);
            this.label1.TabIndex = 89;
            this.label1.Text = "Movie !";
            // 
            // gunaDelete
            // 
            this.gunaDelete.BackColor = System.Drawing.Color.Transparent;
            this.gunaDelete.BorderRadius = 8;
            this.gunaDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.gunaDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaDelete.ForeColor = System.Drawing.Color.White;
            this.gunaDelete.Location = new System.Drawing.Point(765, 205);
            this.gunaDelete.Name = "gunaDelete";
            this.gunaDelete.Size = new System.Drawing.Size(109, 35);
            this.gunaDelete.TabIndex = 95;
            this.gunaDelete.Text = "Delete";
            this.gunaDelete.Click += new System.EventHandler(this.gunaDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.BorderRadius = 8;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(765, 93);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(109, 35);
            this.buttonUpdate.TabIndex = 93;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BorderRadius = 8;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(765, 150);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 35);
            this.buttonAdd.TabIndex = 92;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.panel2.BorderRadius = 10;
            this.panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel2.BorderThickness = 2;
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.txtdescription);
            this.panel2.Controls.Add(this.cbbgenres);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtlength);
            this.panel2.Controls.Add(this.dtrelease);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.butGenres);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Location = new System.Drawing.Point(56, 75);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.BorderRadius = 10;
            this.panel2.Size = new System.Drawing.Size(539, 226);
            this.panel2.TabIndex = 94;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Transparent;
            this.txtid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtid.BorderRadius = 10;
            this.txtid.BorderThickness = 2;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.Enabled = false;
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.Location = new System.Drawing.Point(14, 22);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderText = "";
            this.txtid.SelectedText = "";
            this.txtid.Size = new System.Drawing.Size(111, 36);
            this.txtid.TabIndex = 57;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.Transparent;
            this.txtprice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtprice.BorderRadius = 10;
            this.txtprice.BorderThickness = 2;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Location = new System.Drawing.Point(139, 22);
            this.txtprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(111, 36);
            this.txtprice.TabIndex = 100;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtname.BorderRadius = 10;
            this.txtname.BorderThickness = 2;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Location = new System.Drawing.Point(266, 22);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(181, 36);
            this.txtname.TabIndex = 53;
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.Transparent;
            this.txtdescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtdescription.BorderRadius = 10;
            this.txtdescription.BorderThickness = 2;
            this.txtdescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdescription.DefaultText = "";
            this.txtdescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtdescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdescription.Location = new System.Drawing.Point(14, 77);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.PasswordChar = '\0';
            this.txtdescription.PlaceholderText = "";
            this.txtdescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdescription.SelectedText = "";
            this.txtdescription.Size = new System.Drawing.Size(236, 141);
            this.txtdescription.TabIndex = 87;
            // 
            // cbbgenres
            // 
            this.cbbgenres.BackColor = System.Drawing.Color.Transparent;
            this.cbbgenres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.cbbgenres.BorderRadius = 10;
            this.cbbgenres.BorderThickness = 2;
            this.cbbgenres.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbgenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbgenres.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbgenres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbgenres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbgenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbgenres.ItemHeight = 30;
            this.cbbgenres.Location = new System.Drawing.Point(266, 77);
            this.cbbgenres.Name = "cbbgenres";
            this.cbbgenres.Size = new System.Drawing.Size(181, 36);
            this.cbbgenres.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label8.Location = new System.Drawing.Point(266, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 117;
            this.label8.Text = "Movie Genres";
            // 
            // txtlength
            // 
            this.txtlength.BackColor = System.Drawing.Color.Transparent;
            this.txtlength.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtlength.BorderRadius = 10;
            this.txtlength.BorderThickness = 2;
            this.txtlength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlength.DefaultText = "";
            this.txtlength.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtlength.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtlength.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlength.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtlength.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlength.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtlength.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlength.Location = new System.Drawing.Point(266, 129);
            this.txtlength.Margin = new System.Windows.Forms.Padding(2);
            this.txtlength.Name = "txtlength";
            this.txtlength.PasswordChar = '\0';
            this.txtlength.PlaceholderText = "";
            this.txtlength.SelectedText = "";
            this.txtlength.Size = new System.Drawing.Size(181, 36);
            this.txtlength.TabIndex = 56;
            // 
            // dtrelease
            // 
            this.dtrelease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.dtrelease.BorderRadius = 10;
            this.dtrelease.Checked = true;
            this.dtrelease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.dtrelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtrelease.ForeColor = System.Drawing.Color.White;
            this.dtrelease.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtrelease.Location = new System.Drawing.Point(266, 182);
            this.dtrelease.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtrelease.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtrelease.Name = "dtrelease";
            this.dtrelease.Size = new System.Drawing.Size(181, 36);
            this.dtrelease.TabIndex = 88;
            this.dtrelease.Value = new System.DateTime(2022, 4, 15, 19, 48, 26, 660);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(266, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 116;
            this.label4.Text = "Release";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label7.Location = new System.Drawing.Point(266, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 19);
            this.label7.TabIndex = 115;
            this.label7.Text = "Movie length (minute)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(19, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 114;
            this.label5.Text = "Movie description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(266, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 112;
            this.label3.Text = "Movie name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(139, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 111;
            this.label2.Text = "Movie price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label6.Location = new System.Drawing.Point(19, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "ID";
            // 
            // butGenres
            // 
            this.butGenres.BackColor = System.Drawing.Color.Transparent;
            this.butGenres.BorderRadius = 8;
            this.butGenres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGenres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butGenres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butGenres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butGenres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butGenres.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butGenres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.butGenres.ForeColor = System.Drawing.Color.White;
            this.butGenres.Location = new System.Drawing.Point(455, 75);
            this.butGenres.Name = "butGenres";
            this.butGenres.Size = new System.Drawing.Size(70, 35);
            this.butGenres.TabIndex = 99;
            this.butGenres.Text = "Genres";
            this.butGenres.Click += new System.EventHandler(this.butGenres_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Transparent;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonReset.BorderRadius = 8;
            this.buttonReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonReset.FillColor = System.Drawing.Color.Transparent;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonReset.Location = new System.Drawing.Point(481, 14);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(32, 35);
            this.buttonReset.TabIndex = 85;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // butSearch
            // 
            this.butSearch.BorderRadius = 10;
            this.butSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.butSearch.ForeColor = System.Drawing.Color.White;
            this.butSearch.Location = new System.Drawing.Point(765, 32);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(109, 35);
            this.butSearch.TabIndex = 91;
            this.butSearch.Text = "Search";
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(487, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(267, 36);
            this.txtSearch.TabIndex = 90;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btimage
            // 
            this.btimage.BackColor = System.Drawing.Color.Transparent;
            this.btimage.BorderRadius = 8;
            this.btimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btimage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btimage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btimage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btimage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btimage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btimage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btimage.ForeColor = System.Drawing.Color.White;
            this.btimage.Location = new System.Drawing.Point(629, 246);
            this.btimage.Name = "btimage";
            this.btimage.Size = new System.Drawing.Size(109, 35);
            this.btimage.TabIndex = 97;
            this.btimage.Text = "Image";
            this.btimage.Click += new System.EventHandler(this.btimage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picbox_imagemovie
            // 
            this.picbox_imagemovie.BorderRadius = 10;
            this.picbox_imagemovie.ImageRotate = 0F;
            this.picbox_imagemovie.Location = new System.Drawing.Point(611, 75);
            this.picbox_imagemovie.Name = "picbox_imagemovie";
            this.picbox_imagemovie.Size = new System.Drawing.Size(142, 165);
            this.picbox_imagemovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_imagemovie.TabIndex = 98;
            this.picbox_imagemovie.TabStop = false;
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
            this.movie_id,
            this.dataGridViewTextBoxColumn1,
            this.movie_genres,
            this.movie_description,
            this.movie_length,
            this.movie_release,
            this.movie_price,
            this.movie_image});
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 317);
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
            this.dataGridView1.Size = new System.Drawing.Size(811, 244);
            this.dataGridView1.TabIndex = 108;
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
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // movie_id
            // 
            this.movie_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.movie_id.DataPropertyName = "movie_id";
            this.movie_id.HeaderText = "ID";
            this.movie_id.MinimumWidth = 6;
            this.movie_id.Name = "movie_id";
            this.movie_id.ReadOnly = true;
            this.movie_id.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "movie_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Movie name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // movie_genres
            // 
            this.movie_genres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.movie_genres.DataPropertyName = "movie_genres";
            this.movie_genres.HeaderText = "Movie genres";
            this.movie_genres.MinimumWidth = 6;
            this.movie_genres.Name = "movie_genres";
            this.movie_genres.ReadOnly = true;
            this.movie_genres.Width = 150;
            // 
            // movie_description
            // 
            this.movie_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.movie_description.DataPropertyName = "movie_description";
            this.movie_description.HeaderText = "Movie description";
            this.movie_description.MinimumWidth = 6;
            this.movie_description.Name = "movie_description";
            this.movie_description.ReadOnly = true;
            this.movie_description.Width = 170;
            // 
            // movie_length
            // 
            this.movie_length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.movie_length.DataPropertyName = "movie_length";
            this.movie_length.HeaderText = "Movie length";
            this.movie_length.MinimumWidth = 6;
            this.movie_length.Name = "movie_length";
            this.movie_length.ReadOnly = true;
            this.movie_length.Width = 110;
            // 
            // movie_release
            // 
            this.movie_release.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.movie_release.DataPropertyName = "movie_release";
            this.movie_release.HeaderText = "Movie release";
            this.movie_release.MinimumWidth = 6;
            this.movie_release.Name = "movie_release";
            this.movie_release.ReadOnly = true;
            this.movie_release.Width = 110;
            // 
            // movie_price
            // 
            this.movie_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.movie_price.DataPropertyName = "movie_price";
            this.movie_price.HeaderText = "Movie price";
            this.movie_price.MinimumWidth = 6;
            this.movie_price.Name = "movie_price";
            this.movie_price.ReadOnly = true;
            this.movie_price.Width = 110;
            // 
            // movie_image
            // 
            this.movie_image.DataPropertyName = "movie_image";
            this.movie_image.HeaderText = "Image";
            this.movie_image.MinimumWidth = 6;
            this.movie_image.Name = "movie_image";
            this.movie_image.ReadOnly = true;
            this.movie_image.Visible = false;
            // 
            // UC_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picbox_imagemovie);
            this.Controls.Add(this.btimage);
            this.Controls.Add(this.gunaDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UC_Movie";
            this.Size = new System.Drawing.Size(915, 516);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_imagemovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button gunaDelete;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtlength;
        private Guna.UI2.WinForms.Guna2Button buttonReset;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private Guna.UI2.WinForms.Guna2Button butSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtdescription;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtrelease;
        private Guna.UI2.WinForms.Guna2Button btimage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_imagemovie;
        private Guna.UI2.WinForms.Guna2ComboBox cbbgenres;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button butGenres;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_genres;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_release;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_image;
    }
}
