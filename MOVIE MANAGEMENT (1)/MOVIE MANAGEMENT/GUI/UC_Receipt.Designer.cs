namespace GUI
{
    partial class UC_Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Receipt));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.butSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btdetail = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcustomername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstaffname = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonexit = new Guna.UI2.WinForms.Guna2Button();
            this.receipt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_booking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancellation_charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
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
            this.butSearch.TabIndex = 81;
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
            this.txtSearch.Location = new System.Drawing.Point(487, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(267, 36);
            this.txtSearch.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(41, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 69);
            this.label1.TabIndex = 88;
            this.label1.Text = "Receipt !";
            // 
            // btdetail
            // 
            this.btdetail.BorderRadius = 10;
            this.btdetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btdetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btdetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btdetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btdetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btdetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btdetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btdetail.ForeColor = System.Drawing.Color.White;
            this.btdetail.Location = new System.Drawing.Point(765, 207);
            this.btdetail.Name = "btdetail";
            this.btdetail.Size = new System.Drawing.Size(109, 35);
            this.btdetail.TabIndex = 112;
            this.btdetail.Text = "Detail";
            this.btdetail.Click += new System.EventHandler(this.btdetail_Click);
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
            this.receipt_id,
            this.fullname,
            this.customer_name,
            this.number_of_tickets,
            this.total_price,
            this.date_booking,
            this.cancellation_charges});
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 272);
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
            this.dataGridView1.TabIndex = 111;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.panel2.BorderRadius = 10;
            this.panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel2.BorderThickness = 2;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtnumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.txtcustomername);
            this.panel2.Controls.Add(this.txtstaffname);
            this.panel2.Location = new System.Drawing.Point(56, 93);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.BorderRadius = 10;
            this.panel2.Size = new System.Drawing.Size(698, 149);
            this.panel2.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label7.Location = new System.Drawing.Point(27, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 117;
            this.label7.Text = "Number of ticket";
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.Transparent;
            this.txtnumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtnumber.BorderRadius = 10;
            this.txtnumber.BorderThickness = 2;
            this.txtnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumber.DefaultText = "";
            this.txtnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumber.Enabled = false;
            this.txtnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumber.Location = new System.Drawing.Point(22, 92);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.PasswordChar = '\0';
            this.txtnumber.PlaceholderText = "";
            this.txtnumber.SelectedText = "";
            this.txtnumber.Size = new System.Drawing.Size(111, 36);
            this.txtnumber.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label5.Location = new System.Drawing.Point(424, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 115;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(187, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 114;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(424, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 113;
            this.label3.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(187, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 112;
            this.label2.Text = "Staff name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.label6.Location = new System.Drawing.Point(27, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 111;
            this.label6.Text = "ID";
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
            this.txtid.Location = new System.Drawing.Point(22, 31);
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
            this.txtprice.Enabled = false;
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Location = new System.Drawing.Point(185, 92);
            this.txtprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(195, 36);
            this.txtprice.TabIndex = 56;
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
            this.buttonReset.Location = new System.Drawing.Point(644, 28);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(32, 35);
            this.buttonReset.TabIndex = 85;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.Transparent;
            this.txtdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtdate.BorderRadius = 10;
            this.txtdate.BorderThickness = 2;
            this.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdate.DefaultText = "";
            this.txtdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdate.Enabled = false;
            this.txtdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdate.Location = new System.Drawing.Point(419, 92);
            this.txtdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.PlaceholderText = "";
            this.txtdate.SelectedText = "";
            this.txtdate.Size = new System.Drawing.Size(195, 36);
            this.txtdate.TabIndex = 54;
            // 
            // txtcustomername
            // 
            this.txtcustomername.BackColor = System.Drawing.Color.Transparent;
            this.txtcustomername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtcustomername.BorderRadius = 10;
            this.txtcustomername.BorderThickness = 2;
            this.txtcustomername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcustomername.DefaultText = "";
            this.txtcustomername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcustomername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcustomername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcustomername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcustomername.Enabled = false;
            this.txtcustomername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcustomername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtcustomername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcustomername.Location = new System.Drawing.Point(419, 31);
            this.txtcustomername.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.PasswordChar = '\0';
            this.txtcustomername.PlaceholderText = "";
            this.txtcustomername.SelectedText = "";
            this.txtcustomername.Size = new System.Drawing.Size(195, 36);
            this.txtcustomername.TabIndex = 55;
            // 
            // txtstaffname
            // 
            this.txtstaffname.BackColor = System.Drawing.Color.Transparent;
            this.txtstaffname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.txtstaffname.BorderRadius = 10;
            this.txtstaffname.BorderThickness = 2;
            this.txtstaffname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstaffname.DefaultText = "";
            this.txtstaffname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstaffname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstaffname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstaffname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstaffname.Enabled = false;
            this.txtstaffname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstaffname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.txtstaffname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstaffname.Location = new System.Drawing.Point(185, 31);
            this.txtstaffname.Margin = new System.Windows.Forms.Padding(2);
            this.txtstaffname.Name = "txtstaffname";
            this.txtstaffname.PasswordChar = '\0';
            this.txtstaffname.PlaceholderText = "";
            this.txtstaffname.SelectedText = "";
            this.txtstaffname.Size = new System.Drawing.Size(195, 36);
            this.txtstaffname.TabIndex = 53;
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
            this.buttonexit.Location = new System.Drawing.Point(880, 0);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(35, 33);
            this.buttonexit.TabIndex = 113;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // receipt_id
            // 
            this.receipt_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.receipt_id.DataPropertyName = "receipt_id";
            this.receipt_id.HeaderText = "ID";
            this.receipt_id.MinimumWidth = 6;
            this.receipt_id.Name = "receipt_id";
            this.receipt_id.ReadOnly = true;
            this.receipt_id.Width = 70;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Staff name";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 150;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Customer name";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 190;
            // 
            // number_of_tickets
            // 
            this.number_of_tickets.DataPropertyName = "number_of_tickets";
            this.number_of_tickets.HeaderText = "Number of ticket";
            this.number_of_tickets.MinimumWidth = 6;
            this.number_of_tickets.Name = "number_of_tickets";
            this.number_of_tickets.ReadOnly = true;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_price.DataPropertyName = "total_price";
            this.total_price.HeaderText = "Price";
            this.total_price.MinimumWidth = 6;
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // date_booking
            // 
            this.date_booking.DataPropertyName = "date_booking";
            this.date_booking.HeaderText = "Date";
            this.date_booking.Name = "date_booking";
            this.date_booking.ReadOnly = true;
            // 
            // cancellation_charges
            // 
            this.cancellation_charges.DataPropertyName = "cancellation_charges";
            this.cancellation_charges.HeaderText = "cancellation_charges";
            this.cancellation_charges.Name = "cancellation_charges";
            this.cancellation_charges.ReadOnly = true;
            this.cancellation_charges.Visible = false;
            // 
            // UC_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.btdetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "UC_Receipt";
            this.Size = new System.Drawing.Size(915, 516);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button butSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btdetail;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Guna.UI2.WinForms.Guna2Button buttonReset;
        private Guna.UI2.WinForms.Guna2TextBox txtdate;
        private Guna.UI2.WinForms.Guna2TextBox txtcustomername;
        private Guna.UI2.WinForms.Guna2TextBox txtstaffname;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtnumber;
        private Guna.UI2.WinForms.Guna2Button buttonexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_booking;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancellation_charges;
    }
}


