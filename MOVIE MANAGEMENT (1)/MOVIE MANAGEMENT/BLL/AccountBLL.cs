using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EmailValidation;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;
using DAL;
using DTO;

namespace BLL
{
    public class AccountBLL
    {
        private static AccountBLL _instance;
        public static AccountBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountBLL();
                return _instance;
            }
            set { }
        }
        private static readonly string _from = "g8cinestar.@gmail.com"; // Email của Sender (của bạn)
        private static readonly string _pass = "quanlirapchieuphim"; // Mật khẩu Email của Sender (của bạn)
        private static string content;
        public string email_employee { get; set; }
        public bool CheckFormatUsernamePass(string un)
        {
            return Regex.IsMatch(un, "^[a-zA-Z0-9]{10,24}$");
        }
        public bool CheckFormatEmail(string em)
        {
            return Regex.IsMatch(em, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        public bool CheckFormatPhoneNumber(string pn)
        {
            return Regex.IsMatch(pn, "^[0-9]{10}$");
        }

        public string CheckFormatAccount(Account account)
        {
            if (account.fullname == "") return "Invalid Fullname. Please enter your fullname.";
            if (!CheckFormatUsernamePass(account.username)) return "Invalid Username! Minimum 10 characters.\nMust not contain symbols.";
            if (!CheckFormatPhoneNumber(account.phone_number)) return "Invalid phone number! Your phone number.\nmust contain 10 characters.";
            if (!CheckFormatEmail(account.email)) return "Invalid Email!\nThe format of the email address is:username@gmail.com.\nUsername must not contain symbols";
    
            return "OK";
        }
        public bool CheckLogin(string username, string password)
        {
            if (!(CheckFormatUsernamePass(username) && CheckFormatUsernamePass(password))) return false;
            return AccountDAL.Instance.CheckLogin(username, HashPass(password));
        }
        public string CheckAndSendMailToReset(string email)
        {
            if (!CheckFormatEmail(email) || AccountDAL.Instance.LoadAccountByEmail(email).Rows.Count == 0) 
                return "Invalid Email! Email address is not registered!";

            email_employee = email;
            content = RandomNumber(99999, 1000000).ToString();
            
            try
            {
                SendEmail(email_employee, content, "RESET PASSWORD");
            }
            catch
            {
                return "No internet connection!";
            }
            return "OK";
            
        }
        public string CheckAndSendMailToFirstLogin(string username)
        {
            content = RandomNumber(99999, 1000000).ToString();
            try
            {
                SendEmail(GetEmailByUsername(username), content, "FIRST LOGIN");
            }
            catch
            {
                return "No internet connection!";
            }
            return "OK";
        }
        public string RandomPassword() //abcd1234AB
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        public string HashPass(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        
        public string Add(Account account)
        {
            string check = CheckFormatAccount(account);
            if (check != "OK") return check;

            check = AccountDAL.Instance.CheckEmailAndUsernameAdd(account);
            if (check != "OK") return check;

            string pwd = RandomPassword();
            account.pwd = HashPass(pwd);
            email_employee = account.email;
            content = "Welcome to CINESTAR CINEMA.<br>We create a new account for you.<br>Username: " + account.username + "<br>Password: " + pwd;
            try
            {
                SendEmail(email_employee, content, "YOUR NEW ACCOUNT AT CINESTAR CINEMA.");
                AccountDAL.Instance.Add(account);
            }
            catch
            {
                return "No internet connection! Can't add new account !";
            }
            return "ADD SUCCESSFUL";
        }
        public string GetEmailByUsername(string username)
        {
            email_employee = AccountDAL.Instance.LoadAccountByUsername(username).Rows[0]["email"].ToString().Trim();
            return email_employee;
        }
        public string Update(Account account)
        {
            string check = CheckFormatAccount(account);
            if (check != "OK") return check;
            check = AccountDAL.Instance.CheckEmailAndUsernameUpdate(account);
            if(check !="OK") return check;
            
            AccountDAL.Instance.Update(account);
            return "UPDATE SUCCESSFUL";
        }
        public DataTable LoadAllAccount()
        {
            return AccountDAL.Instance.LoadAllAccount();
        }
        public DataTable LoadSearchAccount(string txt)
        {
            return AccountDAL.Instance.LoadSearchAccount(txt);
        }
        public DataRow LoadAccountByID(int id)
        {
            return AccountDAL.Instance.LoadAccountByID(id);
        }
        public DataTable LoadAccountByUsername(string username)
        {
            return AccountDAL.Instance.LoadAccountByUsername(username);
        }
        public void SendEmail(string email, string content, string subject)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(_from);
            mail.To.Add(email);
            mail.IsBodyHtml = true;
            mail.Body = content;
            mail.Subject = subject;
            mail.Priority = MailPriority.High;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public bool CheckOTP(string otp)
        {
            return (otp == content);
        }
        public string ResetPass(string newpass, string confirmpass)
        {
            if (CheckFormatUsernamePass(newpass))
            {
                if (confirmpass == newpass)
                {
                    AccountDAL.Instance.ResetPass(HashPass(newpass), email_employee);
                    return  "OK";
                }
                else return "Your confirm password doesn't match your new password";

            }
            else return "Invalid Password! Minimum 10 characters.\r\nMust not contain symbols.";
        }
        public void Delete(List<int> id)
        {
            foreach (int i in id)
            {
                AccountDAL.Instance.Delete(i);
            }
        }
        public string ChangePass(string username, string currentpass, string newpass, string confirmpass)
        {
            string check;
            if (CheckLogin(username, currentpass))
            {
                if (CheckFormatUsernamePass(newpass))
                {
                    if (confirmpass == newpass)
                    {
                        AccountDAL.Instance.ChangePass(HashPass(newpass), username);
                        check = "OK";
                    }
                    else check = "Your confirm password doesn't match your new password";
                }
                else check = "Invalid Password! Minimum 10 characters.\r\nMust not contain symbols.";
            }
            else check = "Your current password is incorrect";
            return check;
        }
    }
}
