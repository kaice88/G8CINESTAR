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
    public partial class FormDangNhap : Form
    {
        //AccountBLL accountBLL = new AccountBLL();
        private void formfail(string mess, int x, int y, int z, int t) // hiện thông báo lỗi
        {
            this.label1.Location = new System.Drawing.Point(574, x); // 74: 1 dong, 60
            this.label2.Location = new System.Drawing.Point(574, y); // 105 : 1 dong, 91
            this.label4.Location = new System.Drawing.Point(574, z); // 140: 1 dong, 126
            this.labelfail.Location = new System.Drawing.Point(574, t);// 161: tb 1 dòng, 147 : tb 2 dòng
            labelfail.Text = mess;
        }
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            
            if (!AccountBLL.Instance.CheckLogin(username, password))
                formfail("The username or password is incorrect. Try again.", 94, 125, 160, 187);
            else
            {
                if(AccountBLL.Instance.CheckChangePass(username))
                {
                    MessageBox.Show("This is the first time you sign in.\nWe sent a email for you.\nPlease check your email to get OTP and change your password.");
                    AccountBLL.Instance.CheckAndSendMailToFirstLogin(username);

                    FormResetMK2 f = new FormResetMK2();
                    f.Show();
                    Hide();
                }
                else if (AccountBLL.Instance.CheckRole(username))
                {
                    Form_QL f = new Form_QL();
                    f.Show();
                    Hide();
                }
                else
                {
                    Form_NV f = new Form_NV();
                    f.Show();
                    Hide();
                }
            }
        }

        private void buttonfogot_Click(object sender, EventArgs e)
        {
            FormResetMK1 f1 = new FormResetMK1();
            f1.Show();
            Hide();
        }


        private void gunaexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttoneyes2_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == false)
            {
                buttoneyes1.BringToFront();
                txtpassword.UseSystemPasswordChar = true;
                txtpassword.PasswordChar = '●';
            }
        }

        private void buttoneyes1_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == true)
            {
                buttoneyes2.BringToFront();
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.PasswordChar = '\0';

            }
        }


    }
}
