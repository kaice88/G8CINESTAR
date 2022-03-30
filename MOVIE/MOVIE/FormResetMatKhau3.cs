using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVIE
{
    public partial class FormResetMatKhau3 : Form
    {
        public delegate void MyDel(string code, string email);
        public MyDel d;
        string otp,email;
        Modify modify = new Modify();
        public FormResetMatKhau3()
        {
            InitializeComponent();
            d = new MyDel(getemail);
        }
        public void getemail( string code,string xemail)
        {
            otp = code;
            email = xemail;
        }
        public bool CheckPass(string p)
        {
            return Regex.IsMatch(p, "^[a-zA-Z0-9]{10,24}$");
        }
        private void buttonreset_Click(object sender, EventArgs e)
        {
            if(CheckPass(txtnewpass.Text)) {
                if (txtconfirmpass.Text == txtnewpass.Text)
                {
                    labelfail.Text = "";
                    string password = txtconfirmpass.Text;
                    string query = "Update account2 Set pwd = '" + password + "' Where email = '" + email + "';";
                    modify.ResetPass(query);

                    FormDangNhap f = new FormDangNhap();
                    f.Show();
                    Hide();
                }
                else
                {
                    labelfail.Text = "Your confirm password doesn't match your new password";
                    txtconfirmpass.Text = "";
                    return;
                }
            }
            else
            {
                labelfail.Text = "Invalid Password! Minimum 10 characters.\r\nMust not contain symbols.";
                txtconfirmpass.Text = "";
                return;
            }
            
            

        }

        private void buttoneyes_Click(object sender, EventArgs e)
        {
            if (txtnewpass.UseSystemPasswordChar == true)
            {
                buttoneyescl.BringToFront();
                txtnewpass.UseSystemPasswordChar = false;
                txtnewpass.PasswordChar = '\0';
                
            }
        }

        private void buttoneyescl_Click(object sender, EventArgs e)
        {
            if (txtnewpass.UseSystemPasswordChar == false)
            {
                buttoneyes.BringToFront();
                txtnewpass.UseSystemPasswordChar = true;
                txtnewpass.PasswordChar = '●';
            }
        }

        private void txtconfirmpass_TextChanged(object sender, EventArgs e)
        {
            if(txtconfirmpass.Text == txtnewpass.Text)
            {
                gunacheck.Visible = true;
            }
            else gunacheck.Visible = false;
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap1 = new FormDangNhap();
            formDangNhap1.Show();
            Hide();
        }
    }
}
