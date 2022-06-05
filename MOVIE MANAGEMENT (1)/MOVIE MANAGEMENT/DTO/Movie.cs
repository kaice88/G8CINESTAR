using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class Movie
    {
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public int movie_genres_id { get; set; }
        public string movie_description { get; set; }
        public int movie_length { get; set; }
        public DateTime movie_release { get; set; }
        public Byte[] movie_image { get; set; }
        public int movie_price { get; set; }

    }
}
