using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AccountDAL:DataBase
    {
        private static AccountDAL _instance;
        public static AccountDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountDAL();
                return _instance;
            }
            set { }
        }
        
        public string CheckEmailAndUsernameAdd(Account account)
        {
            if (LoadData("Select email from TBStaff where email = '" + account.email + "'").Rows.Count != 0) 
                return "Email address is already registered!";
            if (LoadData("Select username from TBStaff where username = '" + account.username + "'").Rows.Count != 0) 
                return "Username is already being used!";
            return "OK";
        }
        public string CheckEmailAndUsernameUpdate(Account account) 
        {
            if (LoadData("Select email from TBStaff where email = '" + account.email + "' and id_number != " + account.id_number).Rows.Count != 0) 
                return "Email address is already registered!";
            if (LoadData("Select username from TBStaff where username = '" + account.username + "' and id_number != " + account.id_number).Rows.Count != 0) 
                return "Username is already being used!";
            return "OK";
        }
        public void Add(Account account)
        {
            EditData("Insert into TBStaff(fullname, username, pwd, phone_number, email,role) values('"
                          + account.fullname + "','" + account.username + "','" + account.pwd + "','" + account.phone_number + "','"
                          + account.email + "','" + account.role + "')");
        }
        
        public void Update(Account account)
        {
            EditData("UPDATE TBStaff set fullname = '" + account.fullname + "', username = '" + account.username +
              "', phone_number = '" + account.phone_number + "', email = '" + account.email + "', role = '" + account.role + "' where id_number = " + account.id_number);
        }
        public DataTable LoadAllAccount()
        {
            return LoadData("SELECT id_number,fullname,username,phone_number,email,role FROM TBStaff ");
        }
        public DataTable LoadSearchAccount(string txt)
        {
            return LoadData("Select  id_number,fullname,username,phone_number,email,role from TBStaff where username = '" + txt + "' or fullname like '%" + txt
                + "%' or phone_number = '" + txt + "' or email = '" + txt + "';");
        }
        public DataRow LoadAccountByID(int id)
        {
            return LoadData("SELECT id_number,fullname,username,phone_number,email,role FROM TBStaff WHERE id_number = " + id).Rows[0];
        }
        public DataTable LoadAccountByUsername(string username)
        {
            return LoadData("select * from TBStaff where username = '" + username + "'");
        }
        public bool CheckLogin(string username, string password)
        {
            return (LoadData("Select * from TBStaff Where username = '" + username + "'and pwd = '" + password + "'").Rows.Count > 0) ;
        }
        public DataTable LoadAccountByEmail(string email)
        {
            return LoadData("Select * from TBStaff where email = '" + email + "'");
        }
        public void ResetPass(string newpass, string email)
        {
            EditData("Update TBStaff Set pwd = '" + newpass + "',changepwd = 'false' where email = '" + email + "'");
        }
        public void Delete(int id)
        {
            EditData("DELETE FROM TBStaff WHERE id_number = " + id);
        }
        public void ChangePass(string newpass, string username)
        {
            string query = "Update TBStaff Set pwd = '" + newpass + "' Where username = '" + username + "';";
            EditData(query);
        }
    }
}
