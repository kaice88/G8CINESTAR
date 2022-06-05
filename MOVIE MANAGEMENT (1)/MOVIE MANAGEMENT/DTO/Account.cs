using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public int id_number { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string pwd { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public bool role { get; set; }
        public bool changepwd { get; set; }
    }
}
