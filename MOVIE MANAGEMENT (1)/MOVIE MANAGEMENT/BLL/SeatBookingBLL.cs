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
    public class SeatBookingBLL
    {
        private static SeatBookingBLL _instance;
        public static SeatBookingBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatBookingBLL();
                return _instance;
            }
            set { }
        }
        
        public int LoadSeatTypeColorByScheduleIDandSeatName(int Schedule_id, string seat_name)
        {
            return Convert.ToInt32(SeatBookingDAL.Instance.LoadSeatTypeColorByScheduleIDandSeatName(Schedule_id, seat_name)[0].ToString());
        }
        public void Add(int schedule_id)
        {
            SeatBookingDAL.Instance.Add(schedule_id);
        }
        public bool GetSeatStatusByByScheduleIDandSeatName(int Schedule_id, string seat_name)
        {
            return Convert.ToBoolean(SeatBookingDAL.Instance.GetSeatStatusByScheduleIDandSeatName(Schedule_id, seat_name)[0].ToString());
        }
        public void UpdateSeatStatus(List<int> Booking_Id)
        {
            SeatBookingDAL.Instance.UpdateSeatStatus(Booking_Id);
        }
        public DataTable Receipt(int id)
        {            
            return SeatBookingDAL.Instance.Receipt(id);
        }
        public DataTable Payment(int id)
        {
            return SeatBookingDAL.Instance.Payment(id);
        }
    }
}

