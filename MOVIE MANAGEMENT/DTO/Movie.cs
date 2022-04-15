using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genres { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
        public DateTime Release { get; set; }
    }
}
