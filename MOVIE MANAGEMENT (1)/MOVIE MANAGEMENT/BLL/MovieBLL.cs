using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using DAL;
using DTO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

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

        public string Add(Movie movie)
        {
            if (MovieDAL.Instance.GetMovieByMovieName(movie.movie_name).Rows.Count > 0) 
                return "Movie name is already registered!";
            MovieDAL.Instance.Add(movie);
            return "ADD SUCCESSFUL";
        }
        public string Update(Movie movie)
        {
            DataRow row = MovieDAL.Instance.LoadMovieByID(movie.movie_id);
            if (movie.movie_price.ToString() != row["movie_price"].ToString() || movie.movie_name != row["movie_name"].ToString()
                || movie.movie_length.ToString() != row["movie_length"].ToString() || movie.movie_release.ToString("yyyy-MM-dd") != Convert.ToDateTime(row["movie_release"].ToString()).ToString("yyyy-MM-dd"))
            {
                if (MovieDAL.Instance.LoadMovieNameByNameAndId(movie).Rows.Count > 0)
                    return "Movie name is already registered!";
                if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsByMovieId(movie.movie_id).Rows.Count > 0)
                    return "Can't update because some unfinished schedules have this movie.";
            }
            MovieDAL.Instance.Update(movie);
            return "UPDATE SUCCESSFUL";

        }
        public List<int> Delete(List<int> movie_id)
        {
            List<int> list = new List<int>();
            foreach (int i in movie_id)
            {
                if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsByMovieId(i).Rows.Count == 0)
                {
                    MovieDAL.Instance.Delete(i);
                }
                else
                {
                    list.Add(i);
                }
            }
            return list;
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
        public DataTable GetMovieByMovieName(string movie_name)
        {
            return MovieDAL.Instance.GetMovieByMovieName(movie_name);
        }

        public List<string> GetListMovieGenres()
        {
            List<string> list = new List<string>();
            foreach (DataRow row in MovieGenresDAL.Instance.LoadAllMovieGenresName().Rows)
            {
                list.Add(row["movie_genres"].ToString().Trim());
            }
            return list;
        }
        public List<string> GetListMovieName()
        {
            List<string> list = new List<string>();
            foreach (DataRow row in MovieDAL.Instance.GetListMovieName().Rows)
            {
                list.Add(row["movie_name"].ToString().Trim());
            }
            return list;
        }
        public DataTable LoadAllMovieNowPlaying()
        {
            return MovieDAL.Instance.LoadAllMovieNowPlaying();
        }
        public DataTable LoadAllMovieComingSoon()
        {
            return MovieDAL.Instance.LoadAllMovieComingSoon();
        }
    }
}
