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
    public class SeatMapBLL
    {
        private static SeatMapBLL _instance;
        public static SeatMapBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatMapBLL();
                return _instance;
            }
            set { }
        }
        private bool CheckRowAndSeatChange(int number_seat, int number_row, int Room_ID)
        {
            if (number_seat == Convert.ToInt32(RoomBLL.Instance.LoadRoomByID(Room_ID)["room_number_of_seat"].ToString())
                && number_row == Convert.ToInt32(RoomBLL.Instance.LoadRoomByID(Room_ID)["room_number_of_row"].ToString()))
                return false;
            return true;
        }
        public string SetSeatMap(string room_name,int number_seat,int number_row, List<Seat> seat)
        {
            int Room_ID = Convert.ToInt32(RoomBLL.Instance.LoadRoomByRoomName(room_name).Rows[0]["room_id"].ToString());
            if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsByRoomId(Room_ID).Rows.Count == 0)
            {
                if (CheckRowAndSeatChange(number_seat, number_row, Room_ID))
                {
                    SeatDAL.Instance.DeleteSeatByRoomID(Room_ID);
                    SeatDAL.Instance.AddSeat(seat);
                    RoomDAL.Instance.UpdateNumberOfSeatAndNumberOfRow(number_seat, number_row, Room_ID);
                }
                else
                {
                    SeatDAL.Instance.UpdateSeat(seat);
                }

                return "SET UP SUCCESSFUL !";
            }
            else return "Can't set up! Because this room has schedules which are not finished ";
        }
    }
}
