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
    public class MovieGenresBLL
    {
        private static MovieGenresBLL _instance;
        public static MovieGenresBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MovieGenresBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllMovieGenres()
        {
            return  MovieGenresDAL.Instance.LoadAllMovieGenres();
        }
        public DataRow LoadMovieGenresByID(int id)
        {
            return  MovieGenresDAL.Instance.LoadMovieGenresByID(id);
        }
        public int GetMovieGenreByMovieGenres(string movie_genres)
        {
            return Convert.ToInt32(MovieGenresDAL.Instance.GetMovieGenreByMovieGenres(movie_genres).Rows[0]["movie_genres_id"].ToString());
            
        }        
        public string Add(MovieGenres  MovieGenres)
        {
            if (MovieGenres.movie_genres == "") return "Invalid Movie Type name. Please enter Movie Type name.";
            if (MovieGenresDAL.Instance.GetMovieGenreByMovieGenres(MovieGenres.movie_genres).Rows.Count > 0) return "Movie Type name already exists";
            
            MovieGenresDAL.Instance.Add(MovieGenres);
            return "ADD SUCCESSFUL";
        }
        public string Update(MovieGenres  MovieGenres)
        {
            if (MovieGenres.movie_genres == "") return "Invalid Movie Type name. Please enter Movie Type name.";
            if (MovieGenresDAL.Instance.LoadMovieGenres(MovieGenres).Rows.Count > 0) return "Movie Type name already exists";

            MovieGenresDAL.Instance.Update(MovieGenres);
            return "UPDATE SUCCESSFUL";
        }
        public void Delete(List<int> id)
        {
            foreach (int i in id)
            {
                 MovieGenresDAL.Instance.Delete(i);
            }
        }
    }
}
