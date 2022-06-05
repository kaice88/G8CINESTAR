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
    public class SeatTypeBLL
    {
        private static SeatTypeBLL _instance;
        public static SeatTypeBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SeatTypeBLL();
                return _instance;
            }
            set { }
        }
        public string CheckFormatSeatType(SeatType seattype)
        {
            if (seattype.Name == "") return "Invalid Seat Type name. Please enter Seat Type name.";
            if (seattype.Price == 0) return "Invalid Seat Type price. Please enter Seat Type price.";
            if (seattype.Color == -15318418) return "Invalid Seat Type color. Please choose Seat Type color.";
            return "OK";
        }
        public string Add(SeatType seattype)
        {
            string check = CheckFormatSeatType(seattype);
            if (check != "OK") return check;

            return SeatTypeDAL.Instance.Add(seattype);
        }
        public string Update(SeatType seattype)
        {
            string check = CheckFormatSeatType(seattype);
            if (check != "OK") return check;
            if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsBySeatTypeId(seattype.ID).Rows.Count > 0)
                return "Can't update because some schedules have this seat type.";
            return SeatTypeDAL.Instance.Update(seattype);
        }
        public List<int> Delete(List<int> id)
        {
            List<int> invalid_id = new List<int>();
            foreach (int i in id)
            {
                if (ScheduleDAL.Instance.LoadUnFinishScheduleIdsBySeatTypeId(i).Rows.Count == 0)
                {
                    SeatTypeDAL.Instance.Delete(i);
                }
                else
                {
                    invalid_id.Add(i);
                }
            }
            return invalid_id;
        }
        public DataTable LoadAllSeatType()
        {
            return SeatTypeDAL.Instance.LoadAllSeatType();
        }
        
        public DataRow LoadSeatTypeByID(int id)
        {
            return SeatTypeDAL.Instance.LoadSeatTypeByID(id);
        }
        public DataRow LoadIDBySeatTypeColor(int color)
        {
            return SeatTypeDAL.Instance.LoadIDBySeatTypeColor(color);
        }
    }
}
