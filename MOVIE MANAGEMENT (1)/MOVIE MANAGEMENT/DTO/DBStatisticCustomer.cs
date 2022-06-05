using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DBStatisticCustomer
    {
        public DataTable table { get; set; }
        private static DBStatisticCustomer _instance;

        public static DBStatisticCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DBStatisticCustomer();
                return _instance;
            }
            set { }
        }
        public DBStatisticCustomer()
        {
            table = new DataTable();
            table.Columns.Add("customer_name", typeof(string));
            table.Columns.Add("phone_number", typeof(string));
            table.Columns.Add("spending", typeof(int));
        }
    }
}
