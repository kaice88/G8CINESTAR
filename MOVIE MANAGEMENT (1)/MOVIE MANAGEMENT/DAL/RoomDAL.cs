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
        public DataTable LoadRoomByRoomName(string room_name)
        {
            return LoadData("Select * from TBRoom where room_name = '" + room_name + "'");
        }
        public DataTable LoadRoomName(Room room)
        {
            return LoadData("Select room_name from TBRoom where room_name = '" + room.room_name + "' and room_id != " + room.room_id);
        }
        public DataRow LoadRoomByScheduleId(int schedule_id)
        {
            return LoadData("select distinct * from tbroom inner join TBSchedule on TBRoom.room_id = TBSchedule.room_id and schedule_id = "+schedule_id).Rows[0];
        }
        
        public DataTable LoadAllRoomView()
        {
            return LoadData("select room_id, room_name,isnull(TBRoomType.room_type,'NULL') as room_type from TBRoom left join TBRoomType on TBRoom.room_type_id = TBRoomType.room_type_id");
        }
        public DataTable LoadSearchRoom(string txt)
        {
            try
            {
                return LoadData("select room_id, room_name,isnull(TBRoomType.room_type,'NULL') as room_type from TBRoom left join TBRoomType on TBRoom.room_type_id = TBRoomType.room_type_id " +
                        "where room_id = " + Convert.ToInt32(txt));
            }
            catch (Exception)
            {
                return LoadData("select room_id, room_name,isnull(TBRoomType.room_type,'NULL') as room_type from TBRoom left join TBRoomType on TBRoom.room_type_id = TBRoomType.room_type_id " +
                        "where (TBRoom.room_name like '%" + txt + "%'  or TBRoomType.room_type = '" + txt + "')");
            }
            
        }
        public DataRow LoadRoomViewByID(int id)
        {
            return LoadData("select room_id, room_name,isnull(TBRoomType.room_type,'NULL') as room_type from TBRoom left join TBRoomType on TBRoom.room_type_id = TBRoomType.room_type_id " +
                            " where TBRoom.room_id = " + id).Rows[0];
        }
        public DataRow LoadRoomByID(int id)
        {
            return LoadData("select room_id, room_name,isnull(TBRoomType.room_type,'NULL') as room_type,room_type_name,room_number_of_seat,room_number_of_row from TBRoom left join TBRoomType on TBRoom.room_type_id = TBRoomType.room_type_id " +
                            " where TBRoom.room_id = " + id).Rows[0];
        }
        public void Add(Room room)
        {
            EditData("Insert into TBRoom(room_name,room_type_id,room_type_name) values('" + room.room_name + "'," + room.room_type_id + ",'" + room.room_type_name + "')");
        }
        public void Update(Room room)
        {
            EditData("UPDATE TBRoom set room_name = '" + room.room_name + "', room_type_id = " + room.room_type_id + ", room_type_name = '" +room.room_type_name + "'  where room_id = " + room.room_id);
        }
        public void UpdateRoomTypeByRoomTypeId(int room_type_id)
        {
            EditData("UPDATE TBRoom set room_type_name  = (select room_type from TBRoomType where room_type_id = "+ room_type_id + ") where room_type_id = " + room_type_id);
        }
        public void Delete(int id)
        {
            EditData("DELETE FROM TBRoom WHERE room_id = " + id);
        }
        public DataTable GetListRoomName()
        {
            return LoadData("SELECT room_name FROM TBRoom order by room_name");
        }
        public void UpdateNumberOfSeatAndNumberOfRow(int seat, int row, int room_id)
        {
            EditData("UPDATE TBRoom set room_number_of_seat = '" + seat + "', room_number_of_row = '" + row + "' where room_id = " + room_id);
        }
    }
}
