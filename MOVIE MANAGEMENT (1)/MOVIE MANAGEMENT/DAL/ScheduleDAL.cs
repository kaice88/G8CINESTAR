using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ScheduleDAL : DataBase
    {
        private static ScheduleDAL _instance;
        public static ScheduleDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScheduleDAL();
                return _instance;
            }
            set { }
        }
        public int CountScheduleConflictAdd(Schedule schedule)
        {   return Convert.ToInt32(LoadData("select count (schedule_id) as \"amount\" " +
                            " from TBSchedule where room_id = '" + schedule.room_id + "' and schedule_date = '" + schedule.schedule_date +
                            "' and (('" + schedule.schedule_start + "' between schedule_start and schedule_end) or ('" + schedule.schedule_end + "' between schedule_start and schedule_end)" +
                            "or (schedule_start between '" + schedule.schedule_start + "' and '" + schedule.schedule_end + "') or (schedule_end between '" + schedule.schedule_start + "' and '" + schedule.schedule_end + "'))")
                .Rows[0][0].ToString());
        }
        public int CountScheduleConflictUpdate(Schedule schedule)
        {
            return Convert.ToInt32(LoadData("select count (schedule_id) as \"amount\" " +
                            " from TBSchedule where room_id = '" + schedule.room_id + "' and schedule_date = '" + schedule.schedule_date +
                            "' and (('" + schedule.schedule_start + "' between schedule_start and schedule_end) or ('" + schedule.schedule_end + "' between schedule_start and schedule_end)" +
                            "or (schedule_start between '" + schedule.schedule_start + "' and '" + schedule.schedule_end + "') or (schedule_end between '" + schedule.schedule_start + "' and '" + schedule.schedule_end + "'))"
                            + " and schedule_id != " + schedule.schedule_id).Rows[0][0].ToString());
        }
        public bool CheckScheduleFinished(Schedule schedule)
        {
            if (LoadData("select count (schedule_id) as \"amount\" from TBSchedule where schedule_id = "+schedule.schedule_id + " and (schedule_date < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or (schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start > '" + DateTime.Now.ToString("HH:mm") + "'))").Rows[0][0].ToString().Trim() == "1")
                return true;
            return false;
        }
        public DataTable LoadAllSchedule()
        {
            return LoadData("select schedule_id,movie_name,room_name,schedule_date,schedule_start,schedule_end from TBSchedule");
        }
        public DataTable LoadSearchSchedule(string txt)
        {
            string query;
            try
            {
                query = "select schedule_id,movie_name,room_name,schedule_date,schedule_start,schedule_end from TBSchedule where schedule_id = " + Convert.ToInt32(txt) ;
                LoadData(query);
            }
            catch (Exception)//
            {
                query = "select schedule_id,movie_name,room_name,schedule_date,schedule_start,schedule_end from TBSchedule " +
                            "where room_name like '%" + txt+ "%' or movie_name like '%" + txt + "%' or schedule_date like '%" + txt + "%'";
            }
            return LoadData(query);
        }
        public DataRow LoadScheduleByID(int id)
        {
            return LoadData("select schedule_id,movie_name,room_name,schedule_date,schedule_start,schedule_end from TBSchedule where schedule_id = " + id).Rows[0];
        }
        public int GetScheduleIDLast()
        {
            return Convert.ToInt32(LoadData("SELECT MAX(schedule_id) FROM TBSchedule").Rows[0][0].ToString());
        }
        public DataTable LoadUnFinishScheduleIdsByMovieId(int movie_id)
        {
            return LoadData("select TBSchedule.schedule_id from TBSchedule where movie_id = " + movie_id +
                " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))");
        }
        public DataTable LoadUnFinishScheduleIdsByRoomId(int room_id)
        {
            return LoadData("select TBSchedule.schedule_id from TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id " +
                "where TBRoom.room_id = "+room_id+ " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))");
        }
        public DataTable LoadUnFinishScheduleIdsBySeatTypeId(int seat_type_id)
        {
            return LoadData("select TBSchedule.schedule_id from  ((TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id) inner join TBSeat on tbseat.room_id = TBRoom.room_id) inner join TBSeatType on TBSeatType.seat_type_id = TBSeat.seat_type_id " +
                "where TBSeatType.seat_type_id = " + seat_type_id + " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))");
        }
        public DataTable LoadUnFinishScheduleIdsByRoomTypeId(int room_type_id)
        {
            return LoadData("select TBSchedule.schedule_id from ((TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id) inner join TBRoomType on tbroom.room_type_id = TBRoomType.room_type_id) " +
                "where tbroom.room_type_id = " + room_type_id + " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))");
        }
        public void Add(Schedule schedule)
        {
            EditData("Insert into TBSchedule(schedule_date,movie_id,movie_name,room_id,room_name,schedule_start,schedule_end) " +
                    "values('" + schedule.schedule_date + "'," + schedule.movie_id + ",'" + schedule.movie_name + "'," + schedule.room_id +",'" + schedule.room_name + 
                    "','" + schedule.schedule_start + "','" + schedule.schedule_end + "')");
        }
        public void Update(Schedule schedule)
        {
            EditData("UPDATE TBSchedule set schedule_date = '" + schedule.schedule_date + "', movie_id = '" + schedule.movie_id + "', movie_name = '" + schedule.movie_name + "', room_id = '" + schedule.room_id
                + "', room_name = '" + schedule.room_name + "', schedule_start = '" + schedule.schedule_start + "', schedule_end = '" + schedule.schedule_end + "' where schedule_id = " + schedule.schedule_id);
        }
        public void Delete(int id)
        {
            EditData("DELETE FROM TBSchedule WHERE schedule_id = " + id + ";");
        }
        public DataTable LoadScheduleDateByMovieID(int id)
        {
            return LoadData("select distinct schedule_date from TBSchedule where movie_id = " + id + " and schedule_date >= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' order by schedule_date");
        }
        public DataTable LoadRoomTypeByMovieIdAndDate(int id, DateTime date)
        {
            return LoadData("select distinct room_type from (TBRoomType inner join TBRoom on TBRoom.room_type_id = TBRoomType.room_type_id) inner join TBSchedule on TBSchedule.room_id = TBRoom.room_id " +
                "where TBSchedule.movie_id = "+id+" and TBSchedule.schedule_date = '" + date + "' order by room_type");
        }
        public DataTable LoadScheduleStart(int id, DateTime date, string room_type) {
            string query;
            if(DateTime.Now.ToString("yyyy-MM-dd") == Convert.ToDateTime(date).ToString("yyyy-MM-dd"))
            {
                query = "select schedule_start from TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id inner join TBRoomType on TBRoomType.room_type_id = TBRoom.room_type_id " +
                    "where movie_id = " + id + " and TBRoomType.room_type = '" + room_type + "' and schedule_date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "' and schedule_start >= '"+(DateTime.Now.AddMinutes(-30)).ToString("HH: mm")+"' order by schedule_start";
                
            }
            else
            {
                query = "select schedule_start from TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id inner join TBRoomType on TBRoomType.room_type_id = TBRoom.room_type_id " +
                    "where movie_id = " + id + " and TBRoomType.room_type = '" + room_type + "' and schedule_date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "' order by schedule_start";
            }
            return LoadData(query);
        }
        public DataTable LoadID(int id, DateTime date, string room_type, string time_start)
        {
            return LoadData("select schedule_id from ((TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id) inner join TBRoomType on TBRoomType.room_type_id = TBRoom.room_type_id) " +
                "where TBSchedule.movie_id = '" + id + "' and TBRoomType.room_type = '" + room_type +"' and schedule_date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "' and schedule_start = '" + time_start + "'");
        }
    }
}
