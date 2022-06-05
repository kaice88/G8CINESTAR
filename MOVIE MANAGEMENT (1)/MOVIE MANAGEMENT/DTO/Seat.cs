using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Seat
    {
        public int seat_id { get; set; }
        
        public int seat_type_id { get; set; }
        public int room_id { get; set; }
        public string seat_name { get; set; }
    }
}
