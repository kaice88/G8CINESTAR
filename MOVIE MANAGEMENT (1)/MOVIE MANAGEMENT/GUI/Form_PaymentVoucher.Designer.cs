namespace GUI
{
    partial class Form_PaymentVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PaymentVoucher));
            this.lbPayment = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btPrint = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbPayment
            // 
            this.lbPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPayment.Location = new System.Drawing.Point(12, 9);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(290, 250);
            this.lbPayment.TabIndex = 115;
            this.lbPayment.Text = resources.GetString("lbPayment.Text");
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            this.btPrint.Location = new System.Drawing.Point(222, 264);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(79, 33);
            this.btPrint.TabIndex = 117;
            this.btPrint.Text = "Print";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // Form_PaymentVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 304);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.lbPayment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_PaymentVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPaymentVoucher";
            this.Load += new System.EventHandler(this.Form_PaymentVoucher_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2Button btPrint;
    }
}