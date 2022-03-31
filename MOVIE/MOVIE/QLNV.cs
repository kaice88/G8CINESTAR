using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EmailValidation;
using System.Text.RegularExpressions;

namespace MOVIE
{
     class QLNV
    {
        public QLNV() { }
        SqlCommand sqlCommand; // dùng để truy vấn các câu lệnh insert, update, ...
        SqlDataReader dataReader; // dùng để truy vẫn dữ liệu trong bảng
        DataTable TBStaff = new DataTable();
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
        public void Add(string query) // dùng để them
        {
            using (SqlConnection sqlConnection = ConnectSql.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn
                sqlConnection.Close();

            }
        }

        public DataTable DTNV(string query) // hien thi ra datagridview
        {
            using (SqlConnection sqlConnection = ConnectSql.GetSqlConnection())
            {
                sqlConnection.Open();
                //sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                TBStaff.TableName = "TBStaff";
                TBStaff.Rows.Clear();
                dataAdapter.Fill(TBStaff);
                sqlConnection.Close();
            }
            return TBStaff;
        }
    }
    
}
