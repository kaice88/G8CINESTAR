using EmailValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVIE
{
    public partial class FormResetMatKhau1 : Form
    {
        private static readonly string _from = "g8cinestar.@gmail.com"; // Email của Sender (của bạn)
        private static readonly string _pass = "quanlirapchieuphim"; // Mật khẩu Email của Sender (của bạn)
        private static string subject = "RESET PASSWORD";
        Modify modify = new Modify();
        public FormResetMatKhau1()
        {
            InitializeComponent();
        }
        public bool CheckEmailExist(string em)
        {
            EmailValidator emailValidator = new EmailValidator();
            EmailValidationResult result;

            emailValidator.Validate(em, out result) ;
            

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
        private void buttonsendemail_Click(object sender, EventArgs e)
        {
            string sendto = txtemail.Text;
            // kiểm tra có tồn tại
            bool check = CheckEmailExist(sendto);
            if (check)
            {
                Random otp = new Random();

                string content = otp.Next(99999, 1000000).ToString();

                // kt có đk chưa
                if (modify.accounts("Select * from account2 where email = '" + sendto + "'").Count == 0)
                {
                    MessageBox.Show("Email này chưa được đăng ký, vui lòng nhập email đã đăng kí!");//form7
                    return;
                }

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");


                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                FormResetMatKhau2 f2 = new FormResetMatKhau2();
                f2.Show();
                f2.d(content);

                FormResetMatKhau4 f4 = new FormResetMatKhau4();
                f4.d(content);

                Hide();
            }
            else
            {
                MessageBox.Show("Email server replied there is no such mailbox");//form3
                return;
                // hiện form
                // show bang sai xong hide
            }

        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }
    }
}
