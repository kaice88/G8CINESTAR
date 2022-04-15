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
    public class SeatTypeBLL
    {
        private static SeatTypeBLL _instance;
        public static SeatTypeBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatTypeBLL();
                return _instance;
            }
            set { }
        }
        public string CheckSeatType(SeatType seattype)
        {
            if (seattype.Name == "") return "Invalid Seat Type name. Please enter Seat Type name.";
            if (seattype.Price == 0) return "Invalid Seat Type price. Please enter Seat Type price.";
            return "OK";
        }
        public string Add(SeatType seattype)
        {
            string check = CheckSeatType(seattype);
            if (check != "OK") return check;
            check = SeatTypeDAL.Instance.Add(seattype);
            return check;
        }
        public string Update(SeatType seattype)
        {
            string check = CheckSeatType(seattype);
            if (check != "OK") return check;
            check = SeatTypeDAL.Instance.Update(seattype);
            return check;
        }
        public void Delete(List<int> id)
        {
           foreach(int  i in id)
            {
                SeatTypeDAL.Instance.Delete(i);
            }
        }
        public DataTable LoadAllSeatType()
        {
            return SeatTypeDAL.Instance.LoadAllSeatType();
        }
        public DataTable LoadSearchSeatType(string txt)
        {
            return SeatTypeDAL.Instance.LoadSearchSeatType(txt);
        }
        public DataRow LoadSeatTypeByID(int id)
        {
            return SeatTypeDAL.Instance.LoadSeatTypeByID(id);
        }
    }
}
