using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receipt
    {
        public int receipt_id { get; set; }
        public string customer_name { get; set; }
        public string fullname { get; set;}
        public int number_of_tickets { get; set; }
        public int total_price { get; set; }
        public DateTime date_booking { get; set; }
        public bool receipt_status { get; set; }
        public int cancellation_charges { get; set; }
    }
}
