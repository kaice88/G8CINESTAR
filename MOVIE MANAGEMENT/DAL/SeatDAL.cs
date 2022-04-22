using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SeatDAL:DataBase
    {
        private static SeatDAL _instance;
        public static SeatDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatDAL();
                return _instance;
            }
            set { }
        }
        public void Add(List<Seat> seat)
        {
            string query;
            foreach (Seat s in seat)
            {
                query = "insert into TBSeat(seat_type_id, room_id, seat_name) values('" + s.seat_type_ID+ "', '"+s.room_ID+"','"+s.Name+"')";
                EditData(query);
            }
        }
        //them moi ngay 22_4
        public DataRow GetSeatIDByRoomIDandSeatName(int room_id, string seat_name)
        {
            string query = "SELECT seat_id FROM TBSeat Where room_id =" + room_id + "and seat_name ='" + seat_name +"'" ;
            return LoadData(query).Rows[0];
        }
         public DataRow GetSeatTypeIdBySeatId(int seat_id)
        {
            string query = "SELECT seat_type_id FROM TBSeat Where seat_id ="+seat_id+";";
            return LoadData(query).Rows[0];
        }
    }
}
