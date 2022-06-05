using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class StatisticBLL
    {
        private static StatisticBLL _instance;
        public static StatisticBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StatisticBLL();
                return _instance;
            }
            set { }
        }
        public DataTable StatisticCustomer(string txt1, string txt2)
        {
            return StatisticDAL.Instance.StatisticCustomer(txt1, txt2);
        }
        public DataTable StatisticEmployee(string txt1, string txt2)
        {
            return StatisticDAL.Instance.StatisticEmployee(txt1, txt2);
        }
        public DataTable StatisticMovie(string txt1, string txt2)
        {
            return StatisticDAL.Instance.StatisticMovie(txt1, txt2);
        }
        public int Total(DataTable table)
        {
            int total = 0;
            foreach (DataRow row in table.Rows)
            {
                total += Convert.ToInt32(row["total"].ToString());
            }
            return total;
        }
    }
}
