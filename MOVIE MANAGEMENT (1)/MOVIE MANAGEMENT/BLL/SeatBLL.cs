using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

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
        public int GetSeatTypeColorByRoomIDAndSeatName(int room_id, string seat_name)
        {
            return Convert.ToInt32(SeatDAL.Instance.GetSeatTypeColorByRoomIDAndSeatName(room_id, seat_name)["seat_type_color"].ToString());
        }
    }
}
