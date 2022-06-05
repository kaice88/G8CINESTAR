using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class CancelTicketsBLL
    {
        private static CancelTicketsBLL _instance;
        public static CancelTicketsBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CancelTicketsBLL();
                return _instance;
            }
            set { }
        }
        public void CancelTicket(int Receipt_Id,string username, List<int> Booking_Id)
        {
            ReceiptBLL.Instance.UpdateReceipt(Receipt_Id, Booking_Id);
            BookingBLL.Instance.UpdateBookingStatus(Booking_Id);
            PaymentVoucherBLL.Instance.Add(Receipt_Id, Convert.ToInt32(AccountBLL.Instance.LoadAccountByUsername(username).Rows[0]["id_number"].ToString().Trim()), CalculatePaymentPrice(Receipt_Id, Booking_Id));
            SeatBookingBLL.Instance.UpdateSeatStatus(Booking_Id);
        }
        public int CalculatePaymentPrice(int Receipt_Id, List<int> Booking_Id)
        {
            int price = 0;
            foreach(int booking in Booking_Id)
            {
                price+=Convert.ToInt32(BookingBLL.Instance.LoadTicketById(booking)["booking_price"]);
            }
            price -=Convert.ToInt32(ReceiptBLL.Instance.LoadReceiptById(Receipt_Id)["cancellation_charges"].ToString());

            return price;
        }
    }
}
