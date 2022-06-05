using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAL
{
    public class MovieGenresDAL : DataBase
    {
        private static MovieGenresDAL _instance;
        public static MovieGenresDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new  MovieGenresDAL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllMovieGenres()
        {
            return LoadData("SELECT * FROM TBMovieGenres order by movie_genres");
        }
        public DataRow LoadMovieGenresByID(int id)
        {
            return LoadData("SELECT * FROM TBMovieGenres WHERE movie_genres_id = " + id).Rows[0];
        }
        public DataTable GetMovieGenreByMovieGenres(string movie_genres)
        {
            return LoadData("SELECT * FROM TBMovieGenres WHERE movie_genres = '" + movie_genres + "'");
        }
        public DataTable LoadAllMovieGenresName()
        {
            return LoadData("SELECT movie_genres FROM TBMovieGenres order by movie_genres");
        }
        public DataTable LoadMovieGenres( MovieGenres  MovieGenres)
        {
            return LoadData("Select movie_genres from TBMovieGenres where movie_genres = '" + MovieGenres.movie_genres + "' and  movie_genres_id != " + MovieGenres.movie_genres_id);
        }
        public void Add( MovieGenres  MovieGenres)
        {
            EditData("Insert into TBMovieGenres(movie_genres) values('" + MovieGenres.movie_genres + "')");
        }
        public void Update( MovieGenres  MovieGenres)
        {
            EditData("UPDATE TBMovieGenres set movie_genres = '" + MovieGenres.movie_genres + "' where movie_genres_id = " + MovieGenres.movie_genres_id);
        }
        public void Delete(int id)
        {
            EditData("Delete from TBMovieGenres where movie_genres_id =" + id);
        }
    }
}
