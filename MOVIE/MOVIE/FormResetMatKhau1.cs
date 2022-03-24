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
        private static readonly string subject = "RESET PASSWORD";
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
            // kiểm tra email có tồn tại không 
            bool check = CheckEmailExist(sendto);
            if (check)
            {
                // kt có đk chưa
                if (modify.accounts("Select * from account2 where email = '" + sendto + "'").Count == 0)
                {
                    FormFail7 f7 = new FormFail7();
                    f7.Show();
                    return;
                }

                // send email
                Random otp = new Random();
                string content = otp.Next(99999, 1000000).ToString();

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

                // truyền otp vào các form để kiểm tra
                
                FormResetMatKhau2 f2 = new FormResetMatKhau2();
                f2.d(content);
                f2.Show();

                Hide();
            }
            else
            {
                FormFail3 f3 = new FormFail3();
                f3.Show();
            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap1 f = new FormDangNhap1();
            f.Show();
            Hide();
        }
    }
}
