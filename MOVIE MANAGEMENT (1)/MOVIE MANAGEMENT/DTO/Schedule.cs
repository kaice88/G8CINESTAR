using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Schedule
    {
        public int schedule_id { get; set; }
        public DateTime schedule_date { get; set; }
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public int room_id { get; set; }
        public string room_name { get; set; }
        
        public DateTime schedule_start { get; set; }
        public DateTime schedule_end { get; set; }
    }
}
