using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DB
    {
        public DataTable table { get; set; }    
        private static DB _instance;

        public static DB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DB();
                return _instance;
            }
            set { }
        }
        public DB()
        {
            table = new DataTable();
            table.Columns.Add("movie_name", typeof(string));
            table.Columns.Add("seat_name", typeof(string));
            table.Columns.Add("seat_price", typeof(int));
            table.Columns.Add("schedule_id", typeof(int));
        }     
    }
}
