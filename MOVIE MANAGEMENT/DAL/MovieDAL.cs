using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;


namespace DAL
{
    public class MovieDAL : DataBase
    {
        private static MovieDAL _instance;
        public static MovieDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MovieDAL();
                return _instance;
            }
            set { }
        }
        public string CheckAdd(Movie movie)
        {
            string query = "Select movie_name from TBMovie where movie_name = '" + movie.Name + "'";
            if (LoadData(query).Rows.Count != 0) return "MOVIE NAME TRUNG";
            return "OK";
        }
        public string CheckUpdate(Movie movie)
        {
            string query = "Select movie_name from TBMovie where movie_name = '" + movie.Name + "' and movie_id != " + movie.ID;
            if (LoadData(query).Rows.Count != 0) return "MOVIE NAME TRUNG";
            return "OK";
        }
        public string Add(Movie movie)
        {
            string check = CheckAdd(movie);
            if (check != "OK") return check;

            // add
            string query = "Insert into TBMovie values(@movie_name, @movie_genres, @movie_description, @movie_length, @movie_release, @movie_image) ";
            // string query = "Insert into TBMovie(movie_name, movie_genres, movie_description, movie_length, movie_release , movie_image) values('"
            //+ movie.Name + "','" + movie.Genres + "','" + movie.Description + "','" + movie.Length + "','"
            // + movie.Release + "','" +movie.Image+"')";
            CommandMovie(movie, query);
            return "OK";
        }
        public string Update(Movie movie)
        {
            string check = CheckUpdate(movie);
            if (check != "OK") return check;

            // ud  
            string query = "UPDATE TBMovie set movie_name = @movie_name,movie_genres = @movie_genres, movie_description=@movie_description,movie_length= @movie_length, movie_release=@movie_release,movie_image=@movie_image where movie_id = @movie_id";
            CommandMovie(movie, query);
            return "OK";
        }
        public DataTable LoadAllMovie()
        {
            string query = "SELECT * FROM TBMovie";
            return LoadData(query);
        }
        public DataTable LoadSearchMovie(string txt)
        {
            string query = "Select  * from TBMovie where movie_name like '%" + txt + "%';";
            return LoadData(query);
        }
        public DataRow LoadMovieByID(int id)
        {
            string query = "SELECT * FROM TBMovie WHERE movie_id = " + id + ";";
            return LoadData(query).Rows[0];
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM TBMovie WHERE movie_id = " + id + ";";
            EditData(query);
        }
        public DataTable GetListMovieGenres()
        {
            string query = "SELECT movie_genres FROM TBMovie";
            return LoadData(query);
        }
    }
}
