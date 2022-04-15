using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class RoomTypeDAL:DataBase
    {
        private static RoomTypeDAL _instance;
        public static RoomTypeDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoomTypeDAL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllRoomType()
        {
            string query = "SELECT * FROM TBRoomType";
            return LoadData(query);
        }
        public DataTable LoadSearchRoomType(string txt)
        {
            string query = "SELECT * FROM TBRoomType where room_type like '%" + txt + "%'";
            return LoadData(query);
        }
        public DataRow LoadRoomTypeByID(int id)
        {
            string query = "SELECT * FROM TBRoomType WHERE room_type_id = " + id + ";";
            return LoadData(query).Rows[0];
        }
        public string CheckAdd(RoomType roomtype)
        {
            string query = "Select room_type from TBRoomType where room_type = '" + roomtype.Name + "'";
            if (LoadData(query).Rows.Count != 0) return "Room Type name already exists";
            return "OK";
        }
        public string CheckUpdate(RoomType roomtype)
        {
            string query = "Select room_type from TBRoomType where room_type = '" + roomtype.Name + "' and room_type_id != " + roomtype.ID;
            if (LoadData(query).Rows.Count != 0) return "Room Type name already exists";
            return "OK";
        }
        public string Add(RoomType roomtype)
        {
            string check = CheckAdd(roomtype);
            if (check != "OK") return check;

            // add
            string query = "Insert into TBRoomType(room_type,room_type_surcharge) values('"
                          + roomtype.Name + "'," + roomtype.Surcharge + ")";
            EditData(query);
            return "OK";
        }
        public string Update(RoomType roomtype)
        {
            string check = CheckUpdate(roomtype);
            if (check != "OK") return check;

            // ud  
            string query = "UPDATE TBRoomType set room_type = '" + roomtype.Name + "', room_type_surcharge = '" + roomtype.Surcharge + "' where room_type_id = " + roomtype.ID;
            EditData(query);
            return "OK";
        }
        public void Delete(int id)
        {
            string query = "Delete from TBRoomType where room_type_id =" + id + ";";
            EditData(query);
        }
    }
}
