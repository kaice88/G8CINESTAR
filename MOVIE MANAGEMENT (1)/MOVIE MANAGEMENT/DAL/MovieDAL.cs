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
        
        public void Add(Movie movie)
        {
            CommandMovie(movie, "Insert into TBMovie values(@movie_name, @movie_genres_id, @movie_description, @movie_length, @movie_release, @movie_image,@movie_price) ");
        }
        public void Update(Movie movie)
        { 
            CommandMovie(movie, "UPDATE TBMovie set movie_name = @movie_name,movie_genres_id = @movie_genres_id, movie_description=@movie_description,movie_length= @movie_length, movie_release=@movie_release,movie_image=@movie_image,movie_price=@movie_price where movie_id = @movie_id");
        }
        public void Delete(int id)
        {
            EditData("DELETE FROM TBMovie WHERE movie_id = " + id);
        }
        public DataTable LoadAllMovie()
        {
            return LoadData("select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres,'NULL') as movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image from TBMovie left join TBMovieGenres " +
                "on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id");
        }
        public int LoadPriceByScheduleID(int schedule_id)
        {
            return Convert.ToInt32(LoadData("select movie_price from TBMovie inner join TBSchedule on TBMovie.movie_id = TBSchedule.movie_id where TBSchedule.schedule_id ="+schedule_id).Rows[0]["movie_price"].ToString());
        }
        public DataTable LoadSearchMovie(string txt)
        {
            if(txt.ToUpper() != "NULL")
            {
                return LoadData("select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres, TBMovie.movie_description, TBMovie.movie_length, TBMovie.movie_release, TBMovie.movie_price, TBMovie.movie_image from TBMovie left join TBMovieGenres " +

                     "on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id where movie_name like '%" + txt + "%'" + " or TBMovieGenres.movie_genres like '%" + txt + "%'");
            }
            else
            {
                return LoadData("select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres, TBMovie.movie_description, TBMovie.movie_length, TBMovie.movie_release, TBMovie.movie_price, TBMovie.movie_image from TBMovie left join TBMovieGenres " +

                     "on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id where TBMovieGenres.movie_genres is NULL");
            }
            
        }
        public DataRow LoadMovieByID(int id)
        {
            return LoadData("select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image from TBMovie left join TBMovieGenres " +
                "on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id where TBMovie.movie_id = " + id).Rows[0];
        }
        
        public DataTable LoadMovieNameByNameAndId(Movie movie)
        {
            return LoadData("Select movie_name from TBMovie where movie_name = '" + movie.movie_name + "' and movie_id != " + movie.movie_id);
        }

        public DataTable GetListMovieName()
        {
            return LoadData("SELECT movie_name FROM TBMovie order by movie_name");
        }

        public DataTable GetMovieByMovieName(string movie_name)
        {
            return LoadData("SELECT * FROM TBMovie WHERE movie_name = '" + movie_name + "';");
        }
        public DataTable LoadAllMovieNowPlaying()
        {
            return LoadData("select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres,TBMovie.movie_length,TBMovie.movie_release,movie_image from TBMovie left join TBMovieGenres on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id " +
                "where TBMovie.movie_release <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and TBMovie.movie_id in (select distinct movie_id from TBSchedule where (schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_end < '" + DateTime.Now.ToString("HH:mm") + "')) and tbschedule.movie_id is not null)");
        }
        public DataTable LoadAllMovieComingSoon()
        {
            return LoadData("select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres,TBMovie.movie_length,TBMovie.movie_release,movie_image, iif(TBMovie.movie_release <= '" + DateTime.Now.AddDays(3).ToString("yyyy-MM-dd") + "','YES','NO') as \"status\" from TBMovie left join TBMovieGenres " +
               "on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id where TBMovie.movie_release > '" + DateTime.Now.ToString("yyyy-MM-dd") + "' order by TBMovie.movie_release");
        }
    }
}
