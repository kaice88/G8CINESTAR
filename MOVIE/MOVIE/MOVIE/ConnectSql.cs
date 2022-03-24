using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MOVIE
{
    class ConnectSql
    {
        private static string stringConnectSql = @"Data Source=.\sqlexpress;Initial Catalog=RAPPHIM_QL;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnectSql);
        }
    }
}
