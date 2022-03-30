using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE
{
     class account
    {
        private string fullname;
        private string username;
        private string password;
        private string phonenumber;
        private string email;
        private bool role;

        public account()
        {

        }
        public account(string fullname, string username, string password,  string phonenumber, string email, bool role)
        {
            this.username = username;
            this.password = password;
            this.fullname = fullname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.role = role;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public bool Role { get; set; }


    }
}
