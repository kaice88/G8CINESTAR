using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MOVIE
{
    class Modify
    {
        public Modify(){}

        SqlCommand sqlCommand; // dùng để truy vấn các câu lệnh insert, update, ...
        SqlDataReader dataReader; // dùng để truy vẫn dữ liệu trong bảng
        DataSet data = new DataSet();
        DataTable TBStaff = new DataTable();
 
        /*public List<account> accounts(string query) 
        {
            List<account> accounts = new List<account>();
            using (SqlConnection sqlConnection = ConnectSql.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new account(dataReader.GetString(1),dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetBoolean(6)));
                }
                sqlConnection.Close();
            }
            return accounts;
        }*/
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
        public void ResetPass(string query) // dùng để reset pass
        {
            using (SqlConnection sqlConnection = ConnectSql.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn
                sqlConnection.Close();

            }
        }
        public DataSet QLNV(string query) // 
        {
            using (SqlConnection sqlConnection = ConnectSql.GetSqlConnection())
            {
                sqlConnection.Open();
                //sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                TBStaff.TableName = "TBStaff";
                
                bool check = true;
                for (int i = 0; i < data.Tables.Count; i++)
                {
                    if(data.Tables[i].TableName == "TBStaff")
                    {
                        TBStaff.Rows.Clear();
                        dataAdapter.Fill(TBStaff);
                        check = false;
                    }
                }
                if (check)
                {
                    dataAdapter.Fill(TBStaff);
                    data.Tables.Add(TBStaff);
                }

                sqlConnection.Close();
            }
            return data;
        }
    }
}
