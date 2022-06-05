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
    public partial class Form_Login : Form
    {
        private void formfail(string mess, int x, int y, int z, int t) // hiện thông báo lỗi
        {
            label1.Location = new System.Drawing.Point(610, x); // 74: 1 dong, 60
            label2.Location = new System.Drawing.Point(610, y); // 105 : 1 dong, 91
            label4.Location = new System.Drawing.Point(610, z); // 140: 1 dong, 126
            labelfail.Location = new System.Drawing.Point(610, t);// 161: tb 1 dòng, 147 : tb 2 dòng
            labelfail.Text = mess;
        }
        public Form_Login()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (!AccountBLL.Instance.CheckLogin(txtusername.Text, txtpassword.Text))
                formfail("The username or password is incorrect. Try again.", 94, 125, 160, 187);
            else
            {
                if(Convert.ToBoolean(AccountBLL.Instance.LoadAccountByUsername(txtusername.Text).Rows[0]["changepwd"].ToString().Trim()))
                {
                    if (AccountBLL.Instance.CheckAndSendMailToFirstLogin(txtusername.Text) == "OK")
                    {
                        MessageBox.Show("This is the first time you sign in.\nWe sent a email for you.\nPlease check your email to get OTP and change your password.");
                        Form_ResetMK2 f = new Form_ResetMK2();
                        f.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("No internet connection!");
                    }
                }
                else if (Convert.ToBoolean(AccountBLL.Instance.LoadAccountByUsername(txtusername.Text).Rows[0]["role"].ToString().Trim()))// ql
                {
                    Form_Home f = new Form_Home(txtusername.Text);
                    f.Show();
                    Hide();
                }
                else// nv
                {
                    Form_Home f = new Form_Home(txtusername.Text);
                    f.Show();
                    f.Sender();
                    Hide();
                    //Form_Booking f = new Form_Booking(txtusername.Text);                  
                    //f.Show();
                    //Hide();
                }
            }
        }

        private void buttonfogot_Click(object sender, EventArgs e)
        {
            Form_ResetMK1 f1 = new Form_ResetMK1();
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
