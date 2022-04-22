namespace GUI
{
    partial class FormSeatMap
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
            this.butsetup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsohang = new System.Windows.Forms.TextBox();
            this.txtsoghe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // butsetup
            // 
            this.butsetup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butsetup.Location = new System.Drawing.Point(221, 42);
            this.butsetup.Name = "butsetup";
            this.butsetup.Size = new System.Drawing.Size(50, 36);
            this.butsetup.TabIndex = 26;
            this.butsetup.Text = "set up";
            this.butsetup.UseVisualStyleBackColor = false;
            this.butsetup.Click += new System.EventHandler(this.butsetup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Số hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Số ghế";
            // 
            // txtsohang
            // 
            this.txtsohang.Location = new System.Drawing.Point(85, 65);
            this.txtsohang.Name = "txtsohang";
            this.txtsohang.Size = new System.Drawing.Size(100, 20);
            this.txtsohang.TabIndex = 23;
            // 
            // txtsoghe
            // 
            this.txtsoghe.Location = new System.Drawing.Point(85, 40);
            this.txtsoghe.Name = "txtsoghe";
            this.txtsoghe.Size = new System.Drawing.Size(100, 20);
            this.txtsoghe.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(289, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 503);
            this.panel1.TabIndex = 28;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(18, 421);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 30;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // group
            // 
            this.group.Location = new System.Drawing.Point(3, 3);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(65, 263);
            this.group.TabIndex = 31;
            this.group.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.group);
            this.panel2.Location = new System.Drawing.Point(18, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 266);
            this.panel2.TabIndex = 32;
            // 
            // FormSeatMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butsetup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsohang);
            this.Controls.Add(this.txtsoghe);
            this.Name = "FormSeatMap";
            this.Text = "FormSeatMap";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butsetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsohang;
        private System.Windows.Forms.TextBox txtsoghe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Panel panel2;
    }
}