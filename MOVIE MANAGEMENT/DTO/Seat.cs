using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Seat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int seat_type_ID { get; set; }
        public int room_ID { get; set; }
    }
}
