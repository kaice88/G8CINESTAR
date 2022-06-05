using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Booking
    {
        public int booking_id { get; set; }
        public int receipt_id { get; set; }
        public string seat_booking_name { get; set; }
        public DateTime schedule_date { get; set; }
        public string movie_name { get; set; }
        public string room_name { get; set; }
        public DateTime schedule_start { get; set; }
        public bool booking_status { get; set; }
        public int booking_price { get; set; }
    }
}
