using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class RoomTypeDAL : DataBase
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
            return LoadData("SELECT * FROM TBRoomType order by room_type");
        }
        public DataRow LoadRoomTypeByID(int id)
        {
            return LoadData("SELECT * FROM TBRoomType WHERE room_type_id = " + id).Rows[0];
        }
        public DataTable LoadAllRoomTypeName()
        {
            return LoadData("SELECT room_type FROM TBRoomType order by room_type");
        }
        public DataRow GetRoomTypeIDAndPercentByRoomType(string room_type)
        {
            return LoadData("SELECT room_type_id, room_type_price_percent FROM TBRoomType WHERE room_type ='" + room_type + "'").Rows[0];
        }
        public string CheckAdd(RoomType roomtype)
        {
            if (LoadData("Select room_type from TBRoomType where room_type = '" + roomtype.room_type + "'").Rows.Count != 0) return "Room Type name already exists";
            return "OK";
        }
        public string CheckUpdate(RoomType roomtype)
        {
            if (LoadData("Select room_type from TBRoomType where room_type = '" + roomtype.room_type + "' and room_type_id != " + roomtype.room_type_id).Rows.Count != 0) return "Room Type name already exists";
            return "OK";
        }
        public void Add(RoomType roomtype)
        {
            EditData("Insert into TBRoomType(room_type,room_type_price_percent) values('"
                          + roomtype.room_type + "'," + roomtype.room_type_price_percent + ")");
        }
        public void Update(RoomType roomtype)
        {
            EditData("UPDATE TBRoomType set room_type = '" + roomtype.room_type + "', room_type_price_percent = '" + roomtype.room_type_price_percent + "' where room_type_id = " + roomtype.room_type_id);
        }

        public void Delete(int id)
        {
            EditData("Delete from TBRoomType where room_type_id =" + id);
        }
        public int LoadPriceByScheduleId(int schedule_id)
        {
            return Convert.ToInt32(LoadData("select room_type_price_percent from tbroomtype inner join tbroom on tbroom.room_type_id = TBRoomType.room_type_id inner join TBSchedule on tbroom.room_id = TBSchedule.room_id where TBSchedule.schedule_id =" + schedule_id).Rows[0][0].ToString());
        }
    }
}
