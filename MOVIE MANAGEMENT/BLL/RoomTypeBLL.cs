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
        public DataTable LoadSearchRoomType(string txt)
        {
            return RoomTypeDAL.Instance.LoadSearchRoomType(txt);
        }
        public DataRow LoadRoomTypeByID(int id)
        {
            return RoomTypeDAL.Instance.LoadRoomTypeByID(id);
        }
        public string CheckRoomType(RoomType roomtype)
        {
            if (roomtype.Name == "") return "Invalid Room Type name. Please enter Room Type name.";
            if (roomtype.Surcharge == 0) return "Invalid Room Type price. Please enter Room Type price.";
            return "OK";
        }
        public string Add(RoomType roomtype)
        {
            string check = CheckRoomType(roomtype);
            if (check != "OK") return check;
            check = RoomTypeDAL.Instance.Add(roomtype);
            return check;
        }
        public string Update(RoomType roomtype)
        {
            string check = CheckRoomType(roomtype);
            if (check != "OK") return check;
            check = RoomTypeDAL.Instance.Update(roomtype);
            return check;
        }
        public void Delete(List<int> id)
        {
            foreach (int i in id)
            {
                RoomTypeDAL.Instance.Delete(i);
            }
        }
    }
}
