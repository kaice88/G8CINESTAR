
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DBStatisticMovie
    {
        public DataTable table { get; set; }
        private static DBStatisticMovie _instance;

        public static DBStatisticMovie Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DBStatisticMovie();
                return _instance;
            }
            set { }
        }
        public DBStatisticMovie()
        {
            table = new DataTable();
            table.Columns.Add("movie_name", typeof(string));
            table.Columns.Add("number_of_tickets", typeof(int));
            table.Columns.Add("income", typeof(string));
        }
    }
}
