using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class BookingDAL : DataBase
    {
        private static BookingDAL _instance;
        public static BookingDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BookingDAL();
                return _instance;
            }
            set { }
        }
        public DataRow LoadTicketById(int booking_id)
        {
            return LoadData("select booking_id,TBReceipt.fullname,TBReceipt.customer_name,TBReceipt.date_booking,movie_name,seat_booking_name,schedule_date,schedule_start,room_name,booking_status,booking_price " +
                "from TBBooking, TBReceipt where  TBBooking.receipt_id = TBReceipt.receipt_id and TBBooking.booking_id = " + booking_id).Rows[0];
        }
        public DataTable LoadAllTicketByReceiptId(int receipt_id)
        {
            return LoadData("select booking_id,TBReceipt.fullname,TBReceipt.customer_name,TBReceipt.date_booking,movie_name,seat_booking_name,schedule_date,schedule_start,room_name,booking_price " +
                "from TBBooking, TBReceipt where  TBBooking.receipt_id = TBReceipt.receipt_id and TBBooking.receipt_id = " + receipt_id);
        }
       
        public void AddBooking(int schedule_id, int seat_booking_id, int price, int receipt_id)
        {
            EditData("insert into TBBooking(receipt_id,seat_booking_name,schedule_date,movie_name,room_name,schedule_start,booking_price) " +
                "select TBReceipt.receipt_id, TBSeatBooking.seat_booking_name, schedule_date, TBMovie.movie_name, TBRoom.room_name, schedule_start,"+ price +
                " from TBReceipt, (TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id inner join TBSeatBooking on TBRoom.room_id = TBSeatBooking.room_id inner join tbmovie on TBMovie.movie_id = TBSchedule.movie_id) " +
                "where TBSchedule.schedule_id = "+schedule_id+ " and TBSeatBooking.seat_booking_id = " + seat_booking_id + " and TBReceipt.receipt_id = "+receipt_id);
        }
        public void UpdateBookingStatus(int booking_id)
        {
            EditData("update tbbooking set booking_status = 0 where booking_id = "+booking_id);
        }
        public int Count(int receipt)
        {
            return LoadData("select booking_id from TBBooking where receipt_id = "+receipt+" and booking_status = 0").Rows.Count;
        }
        
    }
}
