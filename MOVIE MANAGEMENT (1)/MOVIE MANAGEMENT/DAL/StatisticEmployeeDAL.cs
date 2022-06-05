using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class StatisticEmployeeDAL : DataBase
    {
        private static StatisticEmployeeDAL _instance;
        public static StatisticEmployeeDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StatisticEmployeeDAL();
                return _instance;
            }
            set { }
        }
        public DataTable StatisticEmployee(string txt1, string txt2)
        {
            if (txt1 == "YEAR")
            {
                return LoadData("select fullname , count(fullname) as \"amount\", sum(booking_price) as \"total\" from TBBooking inner join TBReceipt " +
                    "on TBBooking.receipt_id = TBReceipt.receipt_id where YEAR(TBReceipt.date_booking) = '" + txt2 + "' and booking_status = 1 group by fullname order by total DESC");
            }
            else // txt1 == MONTH
            {
                return LoadData("select fullname , count(fullname) as \"amount\", sum(booking_price) as \"total\" from TBBooking inner join TBReceipt " +
                    "on TBBooking.receipt_id = TBReceipt.receipt_id where MONTH(TBReceipt.date_booking) = '" + txt2 + "' and YEAR(TBReceipt.date_booking) = '" + DateTime.Now.Year + "' and booking_status = 1 group by fullname order by total DESC");
            }
        }
    }
}
