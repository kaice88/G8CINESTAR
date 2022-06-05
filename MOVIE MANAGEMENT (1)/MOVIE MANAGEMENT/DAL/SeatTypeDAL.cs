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
            if (LoadData("Select seat_type from TBSeatType where seat_type = '" + seattype.Name + "'").Rows.Count != 0) 
                return "Seat Type name already exists";
            if (LoadData("Select seat_type_color from TBSeatType where seat_type_color = '" + seattype.Color + "'").Rows.Count != 0) return "Seat Type color already exists";
            return "OK";
        }
        public string Add(SeatType seattype)
        {
            string check = CheckAdd(seattype);
            if (check != "OK") return check;

            // add
            EditData("Insert into TBSeatType(seat_type,seat_type_price_percent, seat_type_color ) values('"
                          + seattype.Name + "'," + seattype.Price + "," + seattype.Color + ")");
            return "ADD SUCCESSFUL";
        }
        public string CheckUpdate(SeatType seattype)
        {
            if (LoadData("Select seat_type from TBSeatType where seat_type = '" + seattype.Name + "' and seat_type_id != " + seattype.ID).Rows.Count != 0) 
                return "Seat Type name already exists";
            if (LoadData("Select seat_type_color from TBSeatType where seat_type_color = '" + seattype.Color + "' and seat_type_id != " + seattype.ID).Rows.Count != 0) 
                return "Seat Type color already exists";
            return "OK";
        }
        public string Update(SeatType seattype)
        {
            string check = CheckUpdate(seattype);
            if (check != "OK") return check;

            // ud  
            EditData("UPDATE TBSeatType set seat_type = '" + seattype.Name + "', seat_type_price_percent = '" + seattype.Price + "' , seat_type_color = '" + seattype.Color + "' where seat_type_id = " + seattype.ID);
            return "UPDATE SUCCESSFUL";
        }
        public void Delete(int id)
        {
            EditData("Delete from TBSeatType where seat_type_id =" + id);
        }
        public DataTable LoadAllSeatType()
        {
            return LoadData("SELECT * FROM TBSeatType order by seat_type");
        }
        
        public DataRow LoadSeatTypeByID(int id)
        {
            return LoadData("SELECT * FROM TBSeatType WHERE seat_type_id = " + id).Rows[0];
        }
        public DataRow LoadIDBySeatTypeColor(int color)
        {
            return LoadData("SELECT seat_type_id FROM TBSeatType WHERE seat_type_color = " + color).Rows[0];
        }
        public int LoadPriceByColour(int Seat_type_color)
        {
            return Convert.ToInt32(LoadData("select seat_type_price_percent from TBSeatType where seat_type_color =" + Seat_type_color).Rows[0][0].ToString());
        }
    }
}



