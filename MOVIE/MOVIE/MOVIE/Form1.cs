using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient ;
using System.Text.RegularExpressions;
using System.Net.Mail;
using EmailValidation;

namespace MOVIE
{
    public partial class Form1 : Form
    {
        private static readonly string _from = "g8cinestar.@gmail.com"; // Email của Sender (của bạn)
        private static readonly string _pass = "quanlirapchieuphim"; // Mật khẩu Email của Sender (của bạn)
        private static string subject = "WELCOME TO G8CINESTAR";
        public Form1()
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
            if (!CheckAccount(username)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 10-24 ký tự, với các ký tự chữ hoa, chữ thường và số."); return; } // form1
            if (!CheckAccount(password)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 10-24 ký tự, với các ký tự chữ hoa, chữ thường và số."); return; }//form5
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email"); return; }//form2
            // kiểm tra có trùng không
            if (modify.accounts("Select * from account2 where email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký, vui lòng đăng kí email khác!"); return; }//form4
            if (modify.accounts("Select * from account2 where username = '" + username + "'").Count != 0) { MessageBox.Show("Username này đã được đăng ký, vui lòng đăng kí username khác!"); return; }//form6
            // kiểm tra email có tồn tại ko

            bool check = CheckEmailExist(email);
            if (check)
            {
                string query = "Insert into account2(fullname, username, pwd, phone_number, email ) values('" + fullname + "','" + username + "','" + password + "','" + phone_number + "','" + email + "')";
                modify.Command(query);
            }
            else
            {
                MessageBox.Show("Email server replied there is no such mailbox");// form3
                return;
            }
            
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap1 fdn1 = new FormDangNhap1();
            fdn1.Show();
        }
    }
    }
