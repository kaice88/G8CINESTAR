using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormResetMK1 : Form
    {
        private void formfail(string mess, int x, int y, int z, int t) // hiện thông báo lỗi
        {
            this.label1.Location = new System.Drawing.Point(574, x); // 124,110
            this.label2.Location = new System.Drawing.Point(574, y); // 163,149
            this.label4.Location = new System.Drawing.Point(574, z); // 198,184
            this.labelfail.Location = new System.Drawing.Point(574, t);// 226,212
            labelfail.Text = mess;
        }
        public FormResetMK1()
        {
            InitializeComponent();
        }

        private void buttonsendemail_Click(object sender, EventArgs e)
        {
            string sendto = txtemail.Text;
            string checkmail;
            checkmail = AccountBLL.Instance.CheckAndSendMailToReset(sendto);
            switch (checkmail)
            {
                case "OK":
                    FormResetMK2 f = new FormResetMK2();
                    f.Show();
                    Hide();
                    break;
                default:
                    formfail(checkmail, 124, 163, 198, 226);
                    break;
            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            Hide();
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
