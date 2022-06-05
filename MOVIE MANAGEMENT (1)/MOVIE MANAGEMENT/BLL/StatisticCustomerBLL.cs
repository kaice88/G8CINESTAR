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
    public class StatisticCustomerBLL
    {
        private static StatisticCustomerBLL _instance;
        public static StatisticCustomerBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StatisticCustomerBLL();
                return _instance;
            }
            set { }
        }
        public DataTable StatisticCustomer(string txt1, string txt2)
        {
            return StatisticCustomerDAL.Instance.StatisticCustomer(txt1, txt2);
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
