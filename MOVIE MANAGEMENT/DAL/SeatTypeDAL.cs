using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SeatTypeDAL : DataBase
    {
        private static SeatTypeDAL _instance;
        public static SeatTypeDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatTypeDAL();
                return _instance;
            }
            set { }
        }
        public string CheckAdd(SeatType seattype)
        {
            string query = "Select seat_type from TBSeatType where seat_type = '" + seattype.Name + "'";
            if (LoadData(query).Rows.Count != 0) return "Seat Type name already exists";
            return "OK";
        }
        public string Add(SeatType seattype)
        {
            string check = CheckAdd(seattype);
            if (check != "OK") return check;

            // add
            string query = "Insert into TBSeatType(seat_type,seat_price ) values('"
                          + seattype.Name + "'," + seattype.Price + ")";
            EditData(query);
            return "OK";
        }
        public string CheckUpdate(SeatType seattype)
        {
            string query = "Select seat_type from TBSeatType where seat_type = '" + seattype.Name + "' and seat_type_id != " + seattype.ID;
            if (LoadData(query).Rows.Count != 0) return "Seat Type name already exists";
            return "OK";
        }
        public string Update(SeatType seattype)
        {
            string check = CheckUpdate(seattype);
            if (check != "OK") return check;

            // ud  
            string query = "UPDATE TBSeatType set seat_type = '" + seattype.Name + "', seat_price = '" + seattype.Price + "' where seat_type_id = " + seattype.ID;
            EditData(query);
            return "OK";
        }
        public void Delete(int id)
        {
            string query = "Delete from TBSeatType where seat_type_id =" + id + ";";
            EditData(query);
        }
        public DataTable LoadAllSeatType()
        {
            string query = "SELECT * FROM TBSeatType";
            return LoadData(query);
        }
        public DataTable LoadSearchSeatType(string txt)
        {
            string query = "SELECT * FROM TBSeatType where seat_type like '%" + txt + "%'";
            return LoadData(query);
        }
        public DataRow LoadSeatTypeByID(int id)
        {
            string query = "SELECT * FROM TBSeatType WHERE seat_type_id = " + id + ";";
            return LoadData(query).Rows[0];
        }
    }
}



