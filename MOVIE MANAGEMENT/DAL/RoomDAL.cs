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
        public DataTable GetListRoom()
        {
            string query = "SELECT room_type FROM TBRoom";
            return LoadData(query);
        }
        public DataTable LoadAllRoom()
        {
            string query = "SELECT * FROM TBRoom";
            return LoadData(query);
        }
        public DataTable LoadSearchRoom(string txt)
        {
            string query;
            try
            {
                query = "Select * from TBRoom where room_id = " + Convert.ToInt32(txt) + "or room_name = '" + txt + "' or room_type = '" + txt + "';";
                LoadData(query);
            }
            catch (Exception e)
            {
                query = "Select * from TBRoom where room_name = '" + txt + "' or room_type = '" + txt + "';";
            }
            return LoadData(query);
        }
        public DataRow LoadRoomByID(int id)
        {
            string query = "SELECT * FROM TBRoom WHERE room_id = " + id + ";";
            return LoadData(query).Rows[0];
        }
        public string Add(Room room)
        {
            string check = CheckAdd(room.Name);
            if (check != "OK") return check;

            // add
            string query = "Insert into TBRoom(room_name,room_type) values('"+ room.Name + "','" + room.Type + "')";
            EditData(query);
            return "OK";
        }
        public string Update(Room room)
        {
            string check = CheckUpdate(room);
            if (check != "OK") return check;

            // ud  
            string query = "UPDATE TBRoom set room_name = '" + room.Name + "', room_type = '" + room.Type +"' where room_id = " + room.ID;
            EditData(query);
            return "OK";
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM TBRoom WHERE room_id = " + id + ";";
            EditData(query);
        }
    }
}
