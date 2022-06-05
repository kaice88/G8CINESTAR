using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ReceiptDAL:DataBase
    {
        private static ReceiptDAL _instance;
        public static ReceiptDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReceiptDAL();
                return _instance;
            }
            set { }
        }
        public DataRow LoadReceiptById(int receipt_id)
        {
            return LoadData("select receipt_id, fullname,customer_name,date_booking,total_price,number_of_tickets, cancellation_charges " +
                "from TBReceipt where receipt_id = "+receipt_id).Rows[0];
        }
        
        public DataTable LoadAllReceipt()
        {
            return LoadData("select receipt_id, fullname,customer_name,date_booking,total_price,number_of_tickets, cancellation_charges from TBReceipt");
        }
        public DataTable LoadSearchReceipt(string txt)
        {
            string query;
            try
            {
                query = "select receipt_id, fullname,customer_name,date_booking,total_price,number_of_tickets, cancellation_charges from TBReceipt" +
                    " where date_booking = '" + Convert.ToDateTime(txt).ToString("yyyy-M-dd")+"'";

                LoadData(query);
            }
            catch (Exception)
            {
                query = "select receipt_id, fullname,customer_name,date_booking,total_price,number_of_tickets, cancellation_charges from TBReceipt " +
                "where receipt_id = "+txt+" or fullname like '%" + txt + "%' or customer_name like '%" + txt + "%'";
            }
            return LoadData(query);
        }
        public void UpdateReceipt(int receipt_id, int cancellation_charges)
        {
            EditData("Update TBReceipt set cancellation_charges = "+cancellation_charges+ " where receipt_id = " + receipt_id);
        }
        public void AddReceipt(Receipt receipt)
        {
            EditData("insert into TBReceipt(customer_name,fullname,  number_of_tickets, total_price, date_booking) " +
                "values('" + receipt.customer_name + "', '" + receipt.fullname + "'," + receipt.number_of_tickets + "," + receipt.total_price + ",'" + receipt.date_booking + "')");
        }
        //lay id cuoi cung dc add vao
        public int GetLastReceiptId()
        {
            return Convert.ToInt32(LoadData("SELECT MAX(receipt_id) FROM TBReceipt").Rows[0][0].ToString());

        }
        public bool CheckReceiptBeforeCancel(int receipt_id)
        {
            return Convert.ToBoolean(LoadData("select booking_id from TBBooking where booking_status = 0 and receipt_id = "+receipt_id).Rows.Count == 0);
        }
    }
}
