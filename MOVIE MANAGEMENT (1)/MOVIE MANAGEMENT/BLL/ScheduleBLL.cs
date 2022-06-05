using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class ScheduleBLL
    {
        private static ScheduleBLL _instance;
        public static ScheduleBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScheduleBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllSchedule()
        {
            return ScheduleDAL.Instance.LoadAllSchedule();
        }
        public DataTable LoadSearchSchedule(string txt)
        {
            return ScheduleDAL.Instance.LoadSearchSchedule(txt);
        }
        public DataRow LoadScheduleByID(int id)
        {
            return ScheduleDAL.Instance.LoadScheduleByID(id);
        }
        public string Add(Schedule schedule)
        {
            if (Convert.ToDateTime(schedule.schedule_date.ToString("yyyy-MM-dd")) < Convert.ToDateTime(Convert.ToDateTime(MovieDAL.Instance.LoadMovieByID(schedule.movie_id)["movie_release"].ToString()).ToString("yyyy - MM - dd")))
                return "Invaid Schedule Date! Schedule Date can not before the movie release.";
            if (schedule.schedule_end.Subtract(schedule.schedule_start).TotalMinutes < Convert.ToInt32(MovieDAL.Instance.LoadMovieByID(schedule.movie_id)["movie_length"].ToString()))
                return "Invaid Schedule Time! The schedule time is less than movie length.";
            if (ScheduleDAL.Instance.CountScheduleConflictAdd(schedule) > 0)
                return "Schedule Time conflict!";
            if (SeatDAL.Instance.CountSeatTypeIdNullByRoomId(schedule.room_id) > 0 ||
                Convert.ToInt32(RoomBLL.Instance.LoadRoomByID(schedule.room_id)["room_number_of_row"].ToString()) == 0 ||
                Convert.ToInt32(RoomBLL.Instance.LoadRoomByID(schedule.room_id)["room_number_of_seat"].ToString()) == 0)
                return "This room hasn't been set up yet";

            ScheduleDAL.Instance.Add(schedule);
            SeatBookingBLL.Instance.Add(ScheduleDAL.Instance.GetScheduleIDLast());
            
            return "ADD SUCCESSFUL";
        }

        public string UpDate(Schedule schedule)
        {

            if (ScheduleDAL.Instance.CheckScheduleFinished(schedule))
                return "Can't update because this schedule finished";
            if (SeatBookingDAL.Instance.LoadReservedSeatByScheduleId(schedule.schedule_id).Rows.Count > 0) 
                return "Can't update because this schedule is not finished and already has tickets sold";
            if (schedule.schedule_end.Subtract(schedule.schedule_start).TotalMinutes < Convert.ToInt32(MovieDAL.Instance.LoadMovieByID(schedule.movie_id)["movie_length"].ToString()))
                return "Invaid Schedule Time! The schedule time is less than movie length.";
            if (Convert.ToDateTime(schedule.schedule_date.ToString("yyyy-MM-dd")) < Convert.ToDateTime(Convert.ToDateTime(MovieDAL.Instance.LoadMovieByID(schedule.movie_id)["movie_release"].ToString()).ToString("yyyy - MM - dd")))
                return "Invaid Schedule Date! Schedule Date can not before the movie release.";
            if (ScheduleDAL.Instance.CountScheduleConflictUpdate(schedule) > 0)
                return "Schedule Time conflict!";
            if (SeatDAL.Instance.CountSeatTypeIdNullByRoomId(schedule.room_id) > 0 ||
                Convert.ToInt32(RoomBLL.Instance.LoadRoomByID(schedule.room_id)["room_number_of_row"].ToString()) == 0 ||
                Convert.ToInt32(RoomBLL.Instance.LoadRoomByID(schedule.room_id)["room_number_of_seat"].ToString()) == 0)
                return "This room hasn't been set up yet";
            ScheduleDAL.Instance.Update(schedule);
            SeatBookingDAL.Instance.Delete(schedule.schedule_id);
            SeatBookingDAL.Instance.Add(schedule.schedule_id);
            return "UPDATE SUCCESSFUL";
        }
        ///////
        public List<int> Delete(List<int> schedule_id)
        {
            List<int> list = new List<int>();
            foreach (int i in schedule_id)
            {
                if (SeatBookingDAL.Instance.LoadReservedSeatByScheduleId(i).Rows.Count == 0)
                {
                    ScheduleDAL.Instance.Delete(i);
                }
                else
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public DataTable LoadScheduleDateByMovieID(int id)
        {
            return ScheduleDAL.Instance.LoadScheduleDateByMovieID(id);
        }
        public DataTable LoadRoomTypeByMovieIdAndDate(int id, DateTime date)
        { 
            return ScheduleDAL.Instance.LoadRoomTypeByMovieIdAndDate(id, date);
        }
        public DataTable LoadScheduleStart(int id, DateTime date, string room_type)
        {
            return ScheduleDAL.Instance.LoadScheduleStart(id, date, room_type);
        }
        public int LoadID(int id, DateTime date, string room_type, string time_start)
        {
            return Convert.ToInt32(ScheduleDAL.Instance.LoadID(id, date, room_type, time_start).Rows[0][0].ToString());
        }
    }
}
