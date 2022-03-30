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

        public bool CheckAccount(string un)
        {
            return Regex.IsMatch(un, "^[a-zA-Z0-9]{10,24}$");
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
        private void formfail(string mess,int x, int y, int z, int t ) // hiện thông báo lỗi
        {
            this.label1.Location = new System.Drawing.Point(574, x); // 74: 1 dong, 60
            this.label2.Location = new System.Drawing.Point(574, y); // 105 : 1 dong, 91
            this.label4.Location = new System.Drawing.Point(574, z); // 140: 1 dong, 126
            this.labelfail.Location = new System.Drawing.Point(574, t);// 161: tb 1 dòng, 147 : tb 2 dòng
            labelfail.Text = mess;
        }
        private void gunacreate_Click(object sender, EventArgs e)
        {
            string fullname = txtfullname.Text;
            string username = txtusername.Text;
            string phone_number = txtphonenumber.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;

            // kiểm tra định dạng
            if(fullname =="") { formfail("Invalid Fullname. Please enter your fullname.",74,105,140,161); return; }
            if (!CheckAccount(username)) { formfail("Invalid Username! Minimum 10 characters.\r\nMust not contain symbols.",60,91,126,147); return; } // form1
            if (!CheckPhoneNumber(phone_number)) { formfail("Invalid phone number! Your phone number \r\nmust contain 10 characters.", 60, 91, 126, 147); return; }
            if (!CheckEmail(email)) { formfail("Invalid Email! The format of the email address is:\r\nusername@gmail.com. Username must not contain symbols.", 60, 91, 126, 147); return; }//form2
            if (!CheckAccount(password)) { formfail("Invalid Password! Minimum 10 characters.\r\nMust not contain symbols.", 60, 91, 126, 147); return; }//form5
          

            // kiểm tra có trùng không
            //if (modify.accounts("Select * from TBStaff where email = '" + email + "'").Count != 0) { formfail("Invalid Email! Email address is already registered!", 74, 105, 140, 161); return; }//form4 
            //if (modify.accounts("Select * from TBStaff where username = '" + username + "'").Count != 0) { formfail("Invalid Username! Username is already being used!", 74, 105, 140, 161); return; }//form6 

            if (modify.QLNV("Select * from TBStaff where email = '" + email + "'").Tables[0].Rows.Count != 0)
            {
                formfail("Invalid Email! Email address is already registered!", 74, 105, 140, 161); 
                return;
            }
            if (modify.QLNV("Select * from TBStaff where username = '" + username + "'").Tables[0].Rows.Count != 0)
            {
                formfail("Invalid Username! Username is already being used!", 74, 105, 140, 161); 
                return;
            }

            // kiểm tra email có tồn tại ko
            bool check = CheckEmailExist(email);
            if (check)
            {
                string query = "Insert into TBStaff(fullname, username, pwd, phone_number, email ) values('" + fullname + "','" + username + "','" + password + "','" + phone_number + "','" + email + "')";
                modify.Command(query);

                
                FormDangNhap f1 = new FormDangNhap();
                f1.Show();
                
                FormSuccess f = new FormSuccess();
                f.Show();
                Hide();

            }
            else
            {
                formfail("Invalid Email! Email address does not exist!", 74, 105, 140, 161);
                return;
            }

        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap f1 = new FormDangNhap();
            f1.Show();
            Hide();
        }
    }
}

