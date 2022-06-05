namespace GUI
{
    partial class Form_TicketList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TicketList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btPrint = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 545);
            this.panel1.TabIndex = 43;
            // 
            // butCancel
            // 
            this.butCancel.BorderRadius = 10;
            this.butCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.butCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(884, 48);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(63, 33);
            this.butCancel.TabIndex = 118;
            this.butCancel.Text = "Cancel";
            this.butCancel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // btPrint
            // 
            this.btPrint.BorderRadius = 10;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.btPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Location = new System.Drawing.Point(889, 5);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(58, 33);
            this.btPrint.TabIndex = 117;
            this.btPrint.Text = "Print";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form_TicketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 545);
            this.Controls.Add(this.panel1);
            this.Name = "Form_TicketList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTicketList";
            this.Load += new System.EventHandler(this.FormTicketList_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button butCancel;
    }
}