using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DBStatisticEmployee
    {
        public DataTable table { get; set; }
        private static DBStatisticEmployee _instance;

        public static DBStatisticEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DBStatisticEmployee();
                return _instance;
            }
            set { }
        }
        public DBStatisticEmployee()
        {
            table = new DataTable();
            table.Columns.Add("employee_name", typeof(string));
            table.Columns.Add("employee_phone_number", typeof(string));
            table.Columns.Add("sale", typeof(int));
        }
    }
}
