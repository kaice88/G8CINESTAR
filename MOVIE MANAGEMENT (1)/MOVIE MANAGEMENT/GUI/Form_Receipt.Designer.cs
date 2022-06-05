namespace GUI
{
    partial class Form_Receipt
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Detail = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.DocumentMapWidth = 12;
            this.reportViewer2.Location = new System.Drawing.Point(4, 38);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(997, 417);
            this.reportViewer2.TabIndex = 1;
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.Transparent;
            this.Detail.BorderRadius = 8;
            this.Detail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Detail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Detail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.Detail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Detail.ForeColor = System.Drawing.Color.White;
            this.Detail.Location = new System.Drawing.Point(12, 479);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(109, 35);
            this.Detail.TabIndex = 88;
            this.Detail.Text = "Detail";
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // FormReceipt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 534);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.reportViewer2);
            this.Name = "FormReceipt1";
            this.Text = "Form_Receipt";
            this.Load += new System.EventHandler(this.FormReceipt1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Guna.UI2.WinForms.Guna2Button Detail;
    }
}