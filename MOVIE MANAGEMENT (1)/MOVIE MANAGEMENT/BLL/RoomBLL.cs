using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class RoomBLL
    {
        private static RoomBLL _instance;
        public static RoomBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoomBLL();
                return _instance;
            }
            set { }
        }
        public List<string> GetListRoomType()
        {
            List<string> list = new List<string>();
            foreach(DataRow dr in RoomTypeDAL.Instance.LoadAllRoomTypeName().Rows)
            {
                list.Add(dr["room_type"].ToString());
            }
            return list;
        }
        public DataTable LoadAllRoomView()
        {
            return RoomDAL.Instance.LoadAllRoomView();
        }
        public DataTable LoadSearchRoom(string txt)
        {
            
            return RoomDAL.Instance.LoadSearchRoom(txt);
        }
        public DataRow LoadRoomViewByID(int id)
        {
            return RoomDAL.Instance.LoadRoomViewByID(id);
        }
        public DataRow LoadRoomByID(int id)
        {
            return RoomDAL.Instance.LoadRoomByID(id);
        }
        public DataTable LoadRoomByRoomName(string room_name)
        {
            return RoomDAL.Instance.LoadRoomByRoomName(room_name);
        }
        public string Add(Room room)
        {
            if (room.room_name == "") return "Invalid Name. Please enter the room name.";
            if (RoomDAL.Instance.LoadRoomByRoomName(room.room_name).Rows.Count >0) return "Room's name is already registered!";
            RoomDAL.Instance.Add(room);
            return "ADD SUCCESSFUL";
        }
        public string Update(Room room)
        {
            if (room.room_name == "") return "Invalid Name. Please enter the room name.";
            if(RoomDAL.Instance.LoadRoomName(room).Rows.Count > 0) return "Room's name is already registered!";
            if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsByRoomId(room.room_id).Rows.Count == 0)
            {
                RoomDAL.Instance.Update(room);
            }
            else return "Can't delete because some unfinished schedules have this room.";
            return "UPDATE SUCCESSFUL";
        }
        public DataRow LoadRoomByScheduleId(int schedule_id)
        {
            return RoomDAL.Instance.LoadRoomByScheduleId(schedule_id);
        }
        public void UpdateRoomTypeChange(int room_type_id)
        {
            RoomDAL.Instance.UpdateRoomTypeByRoomTypeId(room_type_id);
        }
        public List<int> Delete(List<int> id)
        {
            List<int> invalid_id = new List<int>();
            foreach (int i in id)
            {
                if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsByRoomId(i).Rows.Count == 0)
                {
                    RoomDAL.Instance.Delete(i);
                }
                else
                {
                    invalid_id.Add(i);
                }
            }
            return invalid_id;
            
        }
        public List<string> GetListRoomName()
        {
            List<string> list = new List<string>();
            foreach (DataRow row in RoomDAL.Instance.GetListRoomName().Rows)
            {
                list.Add(row["room_name"].ToString());
            }
            return list;
        }
    }
}
