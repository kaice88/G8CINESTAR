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
    public class PaymentVoucherBLL
    {
        private static PaymentVoucherBLL _instance;
        public static PaymentVoucherBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PaymentVoucherBLL();
                return _instance;
            }
            set { }
        }
        public void Add(int receipt_id, int id_number, int price)
        {
            PaymentVoucher paymentVoucher = new PaymentVoucher();
            paymentVoucher.receipt_id = receipt_id;
            paymentVoucher.fullname = AccountDAL.Instance.LoadAccountByID(id_number)["fullname"].ToString().Trim();
            paymentVoucher.payment_price = price;
            paymentVoucher.number_of_ticket = BookingDAL.Instance.Count(receipt_id);
            paymentVoucher.date_payment = DateTime.Now;
            PaymentVoucherDAL.Instance.Add(paymentVoucher);
        }
        
        public DataRow LoadPayment(int Receipt_Id)
        {
            return PaymentVoucherDAL.Instance.LoadPayment(Receipt_Id);
        }    
    }
}
