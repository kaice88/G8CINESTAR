using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SeatBookingDAL : DataBase
    {

        private static SeatBookingDAL _instance;
        public static SeatBookingDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatBookingDAL();
                return _instance;
            }
            set { }
        }
        public DataRow LoadSeatTypeColorByScheduleIDandSeatName(int Schedule_id, string seat_name)
        {
            return LoadData("select DISTINCT seat_type_color from TBSeatBooking inner join TBRoom on TBSeatBooking.room_id = TBRoom.room_id inner join TBSeat on TBRoom.room_id = TBSeat.room_id inner join TBSeatType on TBSeat.seat_type_id = TBSeatType.seat_type_id " +
                "where seat_name = '" + seat_name + "' and schedule_id = " + Schedule_id).Rows[0];
        }
        public DataRow GetSeatStatusByScheduleIDandSeatName(int Schedule_id, string seat_name)
        {
            return LoadData("select seat_status from TBSeatBooking Where schedule_id = " + Schedule_id + " and seat_booking_name = '" + seat_name + "'").Rows[0];
        }
        
        public DataTable LoadReservedSeatByScheduleId(int schedule_id)// ghe da dat cua 1 lich chua chieu
        {
            return LoadData("select seat_booking_id from (TBSeatBooking inner join TBSchedule on TBSchedule.schedule_id = TBSeatBooking.schedule_id) " +
                "where  seat_status = 1 and (TBSchedule.schedule_date > '"+DateTime.Now.ToString("yyyy-MM-dd")+ "' or (TBSchedule.schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TBSchedule.schedule_start < '" + DateTime.Now.ToString("HH:mm") + "')) and TBSchedule.schedule_id = "+schedule_id);
        }
        
        public void Add(int schedule_id)
        {
            EditData("INSERT INTO TBSeatBooking (schedule_id,room_id,seat_booking_name) " +
                "SELECT TBSchedule.schedule_id, tbroom.room_id, TBSeat.seat_name " +
                "FROM TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id inner join TBSeat on TBSeat.room_id = TBRoom.room_id " +
                "WHERE TBSchedule.schedule_id = " + schedule_id);
        }
        
        // lay bang ghi vua moi add
        
        public void UpdateSeatStatus(string seat_name, int schedule_id)
        {
            EditData("update tbseatbooking set seat_status = 'True' where seat_booking_name = '"+seat_name+"' and schedule_id = "+schedule_id);
        }
        public void UpdateSeatStatus(List<int> Booking_Id)
        {
            foreach(int id in Booking_Id)
            {
                DataRow booking = BookingDAL.Instance.LoadTicketById(id);
                EditData("update tbseatbooking set seat_status = 'False' where seat_booking_id in (select seat_booking_id from TBSeatBooking inner join TBSchedule on TBSchedule.schedule_id = TBSeatBooking.schedule_id inner " +
                    "join TBRoom on TBRoom.room_id = TBSchedule.room_id inner join TBMovie on tbmovie.movie_id = TBSchedule.movie_id where schedule_date = '"+booking["schedule_date"].ToString()+"' " +
                    "and schedule_start = '"+booking["schedule_start"].ToString() +"' and TBMovie.movie_name = '"+booking["movie_name"].ToString()+ "' and TBRoom.room_name = '" + booking["room_name"].ToString() + "' and seat_status = 1 and TBSeatBooking.seat_booking_name = '"+booking["seat_booking_name"].ToString()+"')");
            }
        }
        public int LoadIdByScheduleIdAndSeatName(int schedule_id, string Seat_name)
        {
            return Convert.ToInt32(LoadData("select seat_booking_id from TBSeatBooking where schedule_id = "+schedule_id+ " and seat_booking_name = '"+Seat_name+"'").Rows[0][0].ToString());
        }
        public DataTable Receipt(int id)
        {
            string query = " SELECT  TBBooking.movie_name, TBBooking.room_name, TBBooking.seat_booking_name, TBBooking.schedule_date, TBBooking.schedule_start, TBBooking.booking_price, TBReceipt.receipt_id, TBReceipt.fullname, TBReceipt.customer_name, TBReceipt.number_of_tickets, TBReceipt.total_price, TBReceipt.date_booking, TBBooking.booking_id, TBBooking.booking_status " +
                "FROM  TBBooking INNER JOIN  TBReceipt ON TBBooking.receipt_id = TBReceipt.receipt_id where TBReceipt.receipt_id = " + id;
            return LoadData(query);

            
        }
        public DataTable Payment(int id)
        {
            return LoadData("SELECT TBPayment.payment_id, TBPayment.receipt_id, TBPayment.fullname, TBPayment.number_of_ticket, TBPayment.payment_price, TBPayment.date_payment, TBReceipt.customer_name, TBReceipt.cancellation_charges, " +
                "TBBooking.booking_id, TBBooking.seat_booking_name, TBBooking.schedule_date, TBBooking.movie_name, TBBooking.room_name, TBBooking.schedule_start, TBBooking.booking_price FROM  TBBooking INNER JOIN TBReceipt ON TBBooking.receipt_id = TBReceipt.receipt_id INNER JOIN " +
                "TBPayment ON TBReceipt.receipt_id = TBPayment.receipt_id WHERE TBReceipt.receipt_id = " + id+ " and TBBooking.booking_status = 0");
        }
        public void Delete(int shedule_id)
        {
            EditData("delete from TBSeatBooking where schedule_id = " + shedule_id);
        }
    }
}
