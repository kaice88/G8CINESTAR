using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class RoomDAL:DataBase
    {
        private static RoomDAL _instance;
        public static RoomDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoomDAL();
                return _instance;
            }
            set { }
        }
        public string CheckAdd(string room_name)
        {
            string query = "Select room_name from TBRoom where room_name = '" + room_name + "'";
            if (LoadData(query).Rows.Count != 0) return "Room's name is already registered!";
            return "OK";
        }
        public string CheckUpdate(Room room)
        {
            string query = "Select room_name from TBRoom where room_name = '" + room.Name + "' and room_id != " + room.ID;
            if (LoadData(query).Rows.Count != 0) return "Room's name is already registered!";
            return "OK";
        }
        public DataTable GetListRoomType()
        {
            string query = "SELECT room_type FROM TBRoomType";
            return LoadData(query);
        }
        public int GetRoomTypeIDByRomeType(string room_type)
        {
            string query = "SELECT room_type_id FROM TBRoomType WHERE room_type = '"+room_type + "'";
            return Convert.ToInt32(LoadData(query).Rows[0][0].ToString());
        }
        public DataTable LoadAllRoom()
        {
            string query = "select room_id, room_name,TBRoomType.room_type from TBRoomType, TBRoom where TBRoomType.room_type_id = TBRoom.room_type_id";
            return LoadData(query);
        }
        public DataTable LoadSearchRoom(string txt)
        {
            string query;
            try
            {
                query = "Select * from TBRoom where room_id = " + Convert.ToInt32(txt);
                LoadData(query);
            }
            catch (Exception e)
            {
                query = "select TBRoom.room_id, TBRoom.room_name, TBRoomType.room_type from TBRoom, TBRoomType " +
                        "where (TBRoom.room_name like '%"+txt+"%'  or TBRoomType.room_type = '"+txt+"') and TBRoomType.room_type_id = TBRoom.room_type_id";
            }
            return LoadData(query);
        }
        public DataRow LoadRoomByID(int id)
        {
            string query = "select TBRoom.room_id, TBRoom.room_name, TBRoomType.room_type from TBRoom, TBRoomType"+
                            " where TBRoom.room_id = "+id+" and TBRoomType.room_type_id = TBRoom.room_type_id";
            return LoadData(query).Rows[0];
        }
        public string Add(Room room)
        {
            string check = CheckAdd(room.Name);
            if (check != "OK") return check;

            // add
            string query = "Insert into TBRoom(room_name,room_type_id) values('" + room.Name + "',"+ room.Room_Type_ID+")";
            EditData(query);
            return "OK";
        }
        public string Update(Room room)
        {
            string check = CheckUpdate(room);
            if (check != "OK") return check;

            // ud  
            string query = "UPDATE TBRoom set room_name = '" + room.Name + "', room_type_id = " + room.Room_Type_ID + " where room_id = " + room.ID;
            EditData(query);
            return "OK";
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM TBRoom WHERE room_id = " + id + ";";
            EditData(query);
        }
        // them moi toi ngay 21_4
        public DataRow GetNumberofSeatByID(int id)
        {
            string query = "SELECT room_number_of_seat FROM TBRoom";
            return LoadData(query).Rows[0];
        }
        public DataRow GetNumberofRowByID(int id)
        {
            string query = "SELECT room_number_of_row FROM TBRoom";
            return LoadData(query).Rows[0];
        }
    }
}
