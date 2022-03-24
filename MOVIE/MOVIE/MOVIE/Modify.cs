using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MOVIE
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand; // dùng để truy vấn các câu lệnh insert, update, ...
        SqlDataReader dataReader; // dùng để truy vẫn dữ liệu trong bảng
        public List<account> accounts(string query)
        {
            List<account> accounts = new List<account>();
            using (SqlConnection sqlConnection = ConnectSql.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new account(dataReader.GetString(2), dataReader.GetString(3)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }
        public void Command(string query) // dùng để đăng ký
        {
            using (SqlConnection sqlConnection = ConnectSql.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn
                sqlConnection.Close();

            }
        }
    }
}
