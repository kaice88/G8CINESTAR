using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class MovieBLL
    {
        private static MovieBLL _instance;
        public static MovieBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MovieBLL();
                return _instance;
            }
            set { }
        }
        public string CheckMovie(Movie movie)
        {
            if (movie.Name == "") return "Invalid Movie name. Please enter your movie name.";
            if (movie.Genres == "") return "Invalid Movie genres. Please enter your movie genres.";
            if (movie.Description == "") return "Invalid Movie description. Please enter your movie description.";
            if ((movie.Length).ToString() == "") return "Invalid Movie length. Please enter your movie length.";
            if (movie.Genres == "") return "Invalid Movie genres. Please enter your movie genres.";
            return "OK";
        }
        public string Add(Movie movie)
        {
            string check = CheckMovie(movie);
            if (check != "OK") return check;
            check = MovieDAL.Instance.Add(movie);
            return check;
        }
        public string Update(Movie movie)
        {
            string check = CheckMovie(movie);
            if (check != "OK") return check;
            return MovieDAL.Instance.Update(movie);
        }
        public DataTable LoadAllMovie()
        {
            return MovieDAL.Instance.LoadAllMovie();
        }
        public DataTable LoadSearchMovie(string txt)
        {
            return MovieDAL.Instance.LoadSearchMovie(txt);
        }
        public DataRow LoadMovieByID(int id)
        {
            return MovieDAL.Instance.LoadMovieByID(id);
        }
        public void Delete(List<int> id)
        {
            foreach (int i in id)
            {
                MovieDAL.Instance.Delete(i);
            }
        }
    }
}
