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
        public List<string> GetListRoom()
        {
            List<string> list = new List<string>();
            DataTable dt = RoomDAL.Instance.GetListRoom();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(dr["room_type"].ToString());
            }
            return list;
        }
        public DataTable LoadAllRoom()
        {
            return RoomDAL.Instance.LoadAllRoom();
        }
        public DataTable LoadSearchRoom(string txt)
        {
            
            return RoomDAL.Instance.LoadSearchRoom(txt);
        }
        public DataRow LoadRoomByID(int id)
        {
            return RoomDAL.Instance.LoadRoomByID(id);
        }
        public string Add(Room room)
        {
            if (room.Name == "") return "Invalid Name. Please enter the room name.";
            return RoomDAL.Instance.Add(room);
        }
        public string Update(Room room)
        {
            if (room.Name == "") return "Invalid Name. Please enter the room name.";
            return RoomDAL.Instance.Update(room);
        }
        public void Delete(List<int> id)
        {
            foreach (int i in id)
            {
                RoomDAL.Instance.Delete(i);
            }
        }
    }
}
