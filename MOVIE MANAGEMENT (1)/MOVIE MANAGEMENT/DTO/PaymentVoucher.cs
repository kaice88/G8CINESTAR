using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaymentVoucher
    {
        public int payment_id { get; set; }
        public int receipt_id { get; set; }
        public string fullname { get; set; }
        public int number_of_ticket { get; set; }
        public int payment_price { get; set; }
        public DateTime date_payment { get; set; }
    }
}
