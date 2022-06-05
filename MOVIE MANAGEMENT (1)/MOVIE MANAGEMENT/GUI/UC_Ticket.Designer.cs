namespace GUI
{
    partial class UC_Ticket
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
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbNow = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.panel1.BorderThickness = 2;
            this.panel1.Controls.Add(this.lbCancel);
            this.panel1.Controls.Add(this.lbNow);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbRoom);
            this.panel1.Controls.Add(this.lbSeat);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.lbCustomer);
            this.panel1.Controls.Add(this.lbStaff);
            this.panel1.Controls.Add(this.lbId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 234);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.Color.Red;
            this.lbCancel.Location = new System.Drawing.Point(124, 196);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(129, 31);
            this.lbCancel.TabIndex = 58;
            this.lbCancel.Text = "Canceled";
            this.lbCancel.Visible = false;
            // 
            // lbNow
            // 
            this.lbNow.Location = new System.Drawing.Point(5, 209);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(243, 21);
            this.lbNow.TabIndex = 57;
            this.lbNow.Text = "DateTime Now";
            this.lbNow.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(198, 114);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(43, 16);
            this.lbPrice.TabIndex = 56;
            this.lbPrice.Text = "Price";
            this.lbPrice.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(202, 172);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(36, 24);
            this.lbRoom.TabIndex = 55;
            this.lbRoom.Text = "Ro";
            this.lbRoom.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbSeat
            // 
            this.lbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeat.Location = new System.Drawing.Point(202, 139);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(46, 24);
            this.lbSeat.TabIndex = 54;
            this.lbSeat.Text = "Seat";
            this.lbSeat.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(43, 172);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(52, 24);
            this.lbDate.TabIndex = 53;
            this.lbDate.Text = "Date";
            this.lbDate.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(42, 139);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(57, 24);
            this.lbTime.TabIndex = 52;
            this.lbTime.Text = "Time";
            this.lbTime.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(60, 116);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(79, 13);
            this.lbCustomer.TabIndex = 51;
            this.lbCustomer.Text = "customer name";
            this.lbCustomer.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Location = new System.Drawing.Point(60, 93);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(56, 13);
            this.lbStaff.TabIndex = 50;
            this.lbStaff.Text = "staff name";
            this.lbStaff.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(169, 93);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(58, 13);
            this.lbId.TabIndex = 49;
            this.lbId.Text = "Ticket Id:  ";
            this.lbId.Click += new System.EventHandler(this.UC_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Room";
            this.label11.Click += new System.EventHandler(this.UC_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Price";
            this.label10.Click += new System.EventHandler(this.UC_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Staff";
            this.label9.Click += new System.EventHandler(this.UC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Customer";
            this.label8.Click += new System.EventHandler(this.UC_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(169, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Seat";
            this.label15.Click += new System.EventHandler(this.UC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.UC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Time";
            this.label4.Click += new System.EventHandler(this.UC_Click);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(7, 53);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(233, 42);
            this.lbName.TabIndex = 41;
            this.lbName.Text = "Movie Name";
            this.lbName.Click += new System.EventHandler(this.UC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "CINESTAR CINEMA";
            this.label2.Click += new System.EventHandler(this.UC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "MOVIE TICKET";
            this.label1.Click += new System.EventHandler(this.UC_Click);
            // 
            // UC_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Ticket";
            this.Size = new System.Drawing.Size(256, 234);
            this.Load += new System.EventHandler(this.UC_Ticket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel1;
        private System.Windows.Forms.Label lbNow;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCancel;
    }
}
