using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SeatDAL : DataBase
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
        public void AddSeat(List<Seat> seat)
        {
            foreach (Seat s in seat)
            {
                EditData("insert into TBSeat(seat_type_id, room_id, seat_name) values('" + s.seat_type_id + "', '" + s.room_id + "','" + s.seat_name + "')");
            }
        }
        public void UpdateSeat(List<Seat> seat)
        {
            foreach (Seat s in seat)
            {
                EditData("UPDATE TBSeat set seat_type_id = '" + s.seat_type_id + "' where room_id = " + s.room_id + " and seat_name = '" + s.seat_name + "'");
            }
        }
        
        public void DeleteSeatByRoomID(int room_id)
        {
            EditData("delete from TBSeat where room_id = " + room_id);
        }
        public DataRow GetSeatTypeColorByRoomIDAndSeatName(int room_id, string seat_name)
        {
            return LoadData("select isnull(TBSeatType.seat_type_color, '-8355712') as seat_type_color from TBSeat left join TBSeatType on TBSeatType.seat_type_id = TBSeat.seat_type_id " +
                "where TBSeat.room_id ="+ room_id+ " and TBSeat.seat_name = '"+seat_name+"'").Rows[0];
        }
        public int CountSeatTypeIdNullByRoomId(int room_id)
        {
            return LoadData("select seat_type_id from TBSeat where seat_type_id is NULL and room_id = " + room_id).Rows.Count;
        }
    }
}
