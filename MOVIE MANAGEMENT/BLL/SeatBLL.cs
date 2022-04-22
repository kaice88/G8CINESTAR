using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SeatBLL
    {
        private static SeatBLL _instance;
        public static SeatBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatBLL();
                return _instance;
            }
            set { }
        }
        public void Add(List<Seat> seat)
        {
            SeatDAL.Instance.Add(seat);
        }
        //THEM MOI NGAY 22_4
        public int GetSeatIDByRoomIDandSeatName(int room_id, string seat_name)
        {
            return Convert.ToInt32(SeatDAL.Instance.GetSeatIDByRoomIDandSeatName(room_id, seat_name)[0].ToString());
        }
        public int GetSeatTypeIdBySeatId(int seat_id)
        {
            return  Convert.ToInt32(SeatDAL.Instance.GetSeatTypeIdBySeatId(seat_id)[0].ToString());
        }
    }
}
