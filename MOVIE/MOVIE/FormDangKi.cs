using EmailValidation;
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
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{10,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        public bool CheckPhoneNumber(string pn)
        {
            return Regex.IsMatch(pn, "^[0-9]{10}$");
        }
        public bool CheckEmailExist(string em)
        {
            EmailValidator emailValidator = new EmailValidator();
            EmailValidationResult result;

            emailValidator.Validate(em, out result);
            switch (result)
            {
                case EmailValidationResult.OK:
                    return true;
                case EmailValidationResult.MailboxUnavailable:
                    return false;

                default:
                    return false;
            }
        }
        private void gunacreate_Click(object sender, EventArgs e)
        {
            string fullname = txtfullname.Text;
            string username = txtusername.Text;
            string phone_number = txtphonenumber.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;

            // kiểm tra định dạng
            if(fullname =="") { FormFail8 f8 = new FormFail8(); f8.Show(); return; }
            if (!CheckAccount(username)) { FormFail1 f1 = new FormFail1();f1.Show(); return; } // form1
            if (!CheckPhoneNumber(phone_number)) { FormFail9 f9 = new FormFail9(); f9.Show(); return; }
            if (!CheckEmail(email)) { FormFail2 f2 = new FormFail2(); f2.Show(); return; }//form2
            if (!CheckAccount(password)) { FormFail5 f5 = new FormFail5(); f5.Show(); return; }//form5
            
            
            // kiểm tra có trùng không
            if (modify.accounts("Select * from account2 where email = '" + email + "'").Count != 0) { FormFail4 f4 = new FormFail4(); f4.Show(); return; }//form4
            if (modify.accounts("Select * from account2 where username = '" + username + "'").Count != 0) { FormFail6 f6 = new FormFail6(); f6.Show(); ; return; }//form6
            
            // kiểm tra email có tồn tại ko
            bool check = CheckEmailExist(email);
            if (check)
            {
                string query = "Insert into account2(fullname, username, pwd, phone_number, email ) values('" + fullname + "','" + username + "','" + password + "','" + phone_number + "','" + email + "')";
                modify.Command(query);

                FormSuccess f = new FormSuccess();
                f.Show();
            }
            else
            {
                FormFail3 f3 = new FormFail3(); 
                f3.Show();
            }

        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap1 f1 = new FormDangNhap1();
            f1.Show();
            Hide();
        }
    }
}

