using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace DAL
{
    public class PaymentVoucherDAL:DataBase
    {
        private static PaymentVoucherDAL _instance;
        public static PaymentVoucherDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PaymentVoucherDAL();
                return _instance;
            }
            set { }
        }
        public void Add(PaymentVoucher payment)
        {
            EditData("insert into TBPayment(receipt_id,fullname,number_of_ticket,payment_price,date_payment) " +
                "values(" + payment.receipt_id + ",'" + payment.fullname + "',"+payment.number_of_ticket+"," + payment.payment_price + ",'" + payment.date_payment + "')");
        }
        //////// kt ni duoi sql
        public DataRow LoadPayment(int Receipt_Id)
        {
            return LoadData("select payment_id,TBPayment.fullname,TBReceipt.customer_name,payment_price,date_payment,count (TBBooking.booking_status) as \"amount\"  from TBReceipt, TBPayment,tbbooking " +
                "where TBPayment.receipt_id = "+Receipt_Id+" and TBReceipt.receipt_id = TBPayment.receipt_id and tbbooking.receipt_id = TBReceipt.receipt_id and booking_status = 0 " +
                "group by payment_id, TBPayment.fullname, TBReceipt.customer_name, payment_price, date_payment").Rows[0];
        }
    }
}
