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
    public partial class Form_ResetMK1 : Form
    {
        private void formfail(string mess, int x, int y, int z, int t) // hiện thông báo lỗi
        {
            label1.Location = new System.Drawing.Point(610, x); // 124,110
            label2.Location = new System.Drawing.Point(610, y); // 163,149
            label4.Location = new System.Drawing.Point(610, z); // 198,184
            labelfail.Location = new System.Drawing.Point(610, t);// 226,212
            labelfail.Text = mess;
        }
        public Form_ResetMK1()
        {
            InitializeComponent();
        }

        private void buttonsendemail_Click(object sender, EventArgs e)
        {
            string checkmail = AccountBLL.Instance.CheckAndSendMailToReset(txtemail.Text);
            if (checkmail == "OK")
            {
                Form_ResetMK2 f = new Form_ResetMK2();
                f.Show();
                Hide();
            }else formfail(checkmail, 124, 163, 198, 226);  
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.Show();
            Hide();
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_ResetMK1_Load(object sender, EventArgs e)
        {

        }
    }
}
