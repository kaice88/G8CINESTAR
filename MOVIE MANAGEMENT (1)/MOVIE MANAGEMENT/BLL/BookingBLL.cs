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
    public class BookingBLL
    {
        private static BookingBLL _instance;
        public static BookingBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BookingBLL();
                return _instance;
            }
            set { }
        }
        public DataRow LoadTicketById(int booking_id)
        {
            return BookingDAL.Instance.LoadTicketById(booking_id);
        }
        public DataTable LoadAllTicketByReceiptId(int receipt_id)
        {
            return BookingDAL.Instance.LoadAllTicketByReceiptId(receipt_id);
        }
        public int PriceSeat(int Schedule_id, int Seat_type_color)
        {
            int movie_price = MovieDAL.Instance.LoadPriceByScheduleID(Schedule_id);
            int room_price = RoomTypeDAL.Instance.LoadPriceByScheduleId(Schedule_id);
            int seat_type_price = SeatTypeDAL.Instance.LoadPriceByColour(Seat_type_color);
            return Convert.ToInt32(movie_price * (1 + room_price * 0.01 + seat_type_price * 0.01));
        }
        public void UpdateBookingStatus(List<int> booking_id)
        {
            foreach(int booking in booking_id)
            {
                BookingDAL.Instance.UpdateBookingStatus(booking);
            }
        }
        public string Booking(DataTable dt, string Username, int Customer_id, int total)
        {
            int account_id = Convert.ToInt32(AccountBLL.Instance.LoadAccountByUsername(Username).Rows[0]["id_number"].ToString().Trim());
            ReceiptBLL.Instance.AddReceipt(account_id, Customer_id, dt.Rows.Count, total, Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")));
            
            foreach(DataRow row in dt.Rows)
            {
                SeatBookingDAL.Instance.UpdateSeatStatus(row[1].ToString(), Convert.ToInt32(row[3].ToString()));
                int seat_booking_id = SeatBookingDAL.Instance.LoadIdByScheduleIdAndSeatName(Convert.ToInt32(row[3].ToString()), row[1].ToString());
                BookingDAL.Instance.AddBooking(Convert.ToInt32(row[3].ToString()), seat_booking_id, Convert.ToInt32(row[2].ToString()), ReceiptDAL.Instance.GetLastReceiptId());

            }
            CustomerDAL.Instance.UpdateRewardPoint(total, Customer_id);
            
            return "BOOKING SUCCESSFUL";

        }
    }
}
