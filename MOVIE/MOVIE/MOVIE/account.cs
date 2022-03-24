using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE
{
     class account
    {
        private string username;
        private string password;

        public account()
        {

        }
        public account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username { get; set; }
            public string Password { get; set; }

    }
}
