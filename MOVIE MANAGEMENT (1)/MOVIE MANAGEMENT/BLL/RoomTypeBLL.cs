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
    public class RoomTypeBLL
    {
        private static RoomTypeBLL _instance;
        public static RoomTypeBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoomTypeBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllRoomType()
        {
            return RoomTypeDAL.Instance.LoadAllRoomType();
        }
        public DataRow LoadRoomTypeByID(int id)
        {
            return RoomTypeDAL.Instance.LoadRoomTypeByID(id);
        }
        public DataRow GetRoomTypeIDAndPercentByRoomType(string room_type)
        {
            return RoomTypeDAL.Instance.GetRoomTypeIDAndPercentByRoomType(room_type);
        }
        public string CheckRoomType(RoomType roomtype)
        {
            if (roomtype.room_type == "") return "Invalid Room Type name. Please enter Room Type name.";
            if (roomtype.room_type_price_percent == 0) return "Invalid Room Type price percent. Please enter Room Type price.";
            return "OK";
        }
        public string Add(RoomType roomtype)
        {
            string check = CheckRoomType(roomtype);
            if (check != "OK") return check;
            check = RoomTypeDAL.Instance.CheckAdd(roomtype);
            if (check != "OK") return check;

            RoomTypeDAL.Instance.Add(roomtype);
            return "ADD SUCCESSFUL";
        }
        public string Update(RoomType roomtype)
        {
            string check = CheckRoomType(roomtype);
            if (check != "OK") return check;
            check = RoomTypeDAL.Instance.CheckUpdate(roomtype);
            if (check != "OK") return check;
            if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsByRoomTypeId(roomtype.room_type_id).Rows.Count > 0)
                return "Can't update because some unfinished schedules use this room type.";

            RoomTypeDAL.Instance.Update(roomtype);
            RoomBLL.Instance.UpdateRoomTypeChange(roomtype.room_type_id);
            return "UPDATE SUCCESSFUL";
        }
        public List<int> Delete(List<int> id)
        {
            List<int> invalid_id = new List<int>();
            foreach (int i in id)
            {
                if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsByRoomTypeId(i).Rows.Count == 0)
                {
                    RoomTypeDAL.Instance.Delete(i);
                }
                else
                {
                    invalid_id.Add(i);
                }
            }
            return invalid_id; 
        }
    }
}
