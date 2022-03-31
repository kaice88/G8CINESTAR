using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVIE
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        

        private void formfail(string mess, int x, int y, int z, int t) // hiện thông báo lỗi
        {
            this.label1.Location = new System.Drawing.Point(574, x); // 94, 80
            this.label2.Location = new System.Drawing.Point(574, y); // 125, 111
            this.label4.Location = new System.Drawing.Point(574, z); // 160,146
            this.labelfail.Location = new System.Drawing.Point(574, t);// 187,173
            labelfail.Text = mess;
        }
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string query = "Select * from TBStaff Where username = '" + username + "'and pwd = '" + password + "'";
            
            //if (modify.accounts(query).Count != 0) // kiểm tra mk vs pwd
            //{
            //    Form1 f = new Form1();
            //    f.Show();
            //    Hide();
            //}
            if (modify.QLNV(query).Tables[0].Rows.Count != 0)
            {
                Form1 f = new Form1();
                f.Show();
                Hide();
            }
            else
            {
                formfail("The username or password is incorrect. Try again.", 94, 125, 160, 187);
                txtpassword.Text = "";
                txtusername.Text = "";
                return;            
            }
        }
        private void buttonfogot_Click(object sender, EventArgs e)
        {
            FormResetMatKhau1 f1 = new FormResetMatKhau1();
            f1.Show();
            Hide();
        }

        private void buttonsignup_Click(object sender, EventArgs e)
        {
            FormDangKi f1 = new FormDangKi();
            f1.Show();
            Hide();
        }

        private void buttoneyescl_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == false )
            {
                buttoneyes.BringToFront();
                txtpassword.UseSystemPasswordChar = true;
                txtpassword.PasswordChar = '●';
            }
        }

        private void buttoneyes_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == true)
            {
                buttoneyescl.BringToFront();
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.PasswordChar = '\0';
            }
        }
    } 
}
