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
    public class ReceiptBLL
    {
        private static ReceiptBLL _instance;
        public static ReceiptBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReceiptBLL();
                return _instance;
            }
            set { }
        }
        public DataRow LoadReceiptById(int receipt_id)
        {
            return ReceiptDAL.Instance.LoadReceiptById(receipt_id);
        }
        public DataTable LoadAllReceipt()
        {
            return ReceiptDAL.Instance.LoadAllReceipt();
        }
        public DataTable LoadSearchReceipt(string txt)
        {
            return ReceiptDAL.Instance.LoadSearchReceipt(txt);
        }
        public void UpdateReceipt(int receipt_id, List<int> booking_id)
        {
            int cancellation_charges = 0;
            foreach (int i in booking_id)
            {
                cancellation_charges+= Convert.ToInt32(BookingDAL.Instance.LoadTicketById(i)["booking_price"].ToString()) /10;
            }
            ReceiptDAL.Instance.UpdateReceipt(receipt_id, cancellation_charges);
        }
        public bool CheckReceiptBeforeCancel(int receipt_id)
        {
            return ReceiptDAL.Instance.CheckReceiptBeforeCancel(receipt_id);
        }
        public bool CheckTimeBeforeCancel(List<int> booking_id)
        {
            foreach(int i in booking_id)
            {
                if (Convert.ToDateTime(BookingDAL.Instance.LoadTicketById(i)["schedule_date"]).Date < DateTime.Now.Date) 
                    return false;
                else if (Convert.ToDateTime(BookingDAL.Instance.LoadTicketById(i)["schedule_date"]).Date == DateTime.Now.Date
                    && Convert.ToDateTime(BookingDAL.Instance.LoadTicketById(i)["schedule_start"].ToString()).AddHours(-2) < DateTime.Now) 
                    // truoc 2 tieng la -2, th ngay chieu trung voi ngay huy ve
                return false;
            }
            return true;
        }
        public void AddReceipt(int account_id, int customer_id, int number_of_ticket, int total_price, DateTime date_booking)
        {
            Receipt receipt = new Receipt();
            receipt.fullname = AccountDAL.Instance.LoadAccountByID(account_id)["fullname"].ToString().Trim();
            if (customer_id == 0) customer_id = 1000;
            receipt.customer_name = CustomerDAL.Instance.LoadCustomerByID(customer_id)["customer_name"].ToString();
            receipt.number_of_tickets = number_of_ticket;
            receipt.total_price = total_price;
            receipt.date_booking = date_booking;
            ReceiptDAL.Instance.AddReceipt(receipt);
        }
        public int GetLastReceiptId()
        {
            return ReceiptDAL.Instance.GetLastReceiptId();
        }
    }
}
