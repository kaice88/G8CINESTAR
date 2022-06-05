using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using BLL;
using DTO;



namespace GUI
{
    public partial class UC_Booking2 : UserControl
    {
        public int Schedule_id { get; set; }

        public delegate void Mydel(DataTable data);
        public Mydel d { get; set; }
        public delegate void Mydel2(UserControl uc);
        public Mydel2 d2 { get; set; }
        public delegate void Mydel3();
        public Mydel3 d3 { get; set; }
        public DataTable table;
        public UC_Booking2(int schedule_id)
        {
            InitializeComponent();
            Schedule_id = schedule_id;
            table = new DataTable();
            table.Columns.Add("movie_name",typeof(string));
            table.Columns.Add("seat_name", typeof(string));
            table.Columns.Add("seat_price", typeof(int));
            table.Columns.Add("schedule_id", typeof(int));
            ShowSeatBooking();
            CreateListLabel(SeatTypeBLL.Instance.LoadAllSeatType());
            UpdateSeatStatusInScreen();
            DataRow row = ScheduleBLL.Instance.LoadScheduleByID(Schedule_id);
            label10.Text = row["movie_name"].ToString().Trim();
            label11.Text = row["schedule_date"].ToString().Trim().Substring(0, 10)  + " | " + row["schedule_start"].ToString().Trim();

        }
        public void AddRow(string movie_name, string seat_name, int seat_price, int schedule_id)
        {
            DataRow row = DB.Instance.table.NewRow();
            row[0] = movie_name;
            row[1] = seat_name;
            row[2] = seat_price;
            row[3] = schedule_id;
            DB.Instance.table.Rows.Add(row);
        }
        public void DeleteRow(string movie_name,string seat_name,int schedule_id)
        {

            for (int i = 0; i < DB.Instance.table.Rows.Count; i++)
            {
                DataRow row = DB.Instance.table.Rows[i];
                if (row[1].ToString() == seat_name && row[0].ToString() == movie_name && row[3].ToString()== schedule_id.ToString()) row.Delete();
            }
            DB.Instance.table.AcceptChanges();

        }
        private void bt_Click(object sender, EventArgs e)
        {
            int color = ((Guna2Button)sender).FillColor.ToArgb();
            if (((Guna2Button)sender).FillColor != Color.Firebrick)
            {
                ((Guna2Button)sender).FillColor = Color.Firebrick;
                AddRow(ScheduleBLL.Instance.LoadScheduleByID(Schedule_id)["movie_name"].ToString().Trim(), ((Guna2Button)sender).Text, BookingBLL.Instance.PriceSeat(Schedule_id, color),Schedule_id);
                d(DB.Instance.table);
            }
            else
            {
                ((Guna2Button)sender).FillColor = Color.FromArgb(SeatBookingBLL.Instance.LoadSeatTypeColorByScheduleIDandSeatName(Schedule_id, ((Guna2Button)sender).Text));
                DeleteRow(ScheduleBLL.Instance.LoadScheduleByID(Schedule_id)["movie_name"].ToString().Trim(), ((Guna2Button)sender).Text,Schedule_id);
                d(DB.Instance.table);
            }
        }
        public bool SeatStatus(string seat_name)
        {
            return SeatBookingBLL.Instance.GetSeatStatusByByScheduleIDandSeatName(Schedule_id, seat_name);
        }
        public void SetStatusColorFromDB(Guna2Button bt)
        {
            if (SeatStatus(bt.Text) == true)
            {
                bt.FillColor = Color.Silver;
                bt.Enabled = false;
            }

        }
        public void SetSeatTypeColorFromDB(Guna2Button bt)
        {
            bt.FillColor = Color.FromArgb(SeatBookingBLL.Instance.LoadSeatTypeColorByScheduleIDandSeatName(Schedule_id, bt.Text));
        }
        public void CreateArrayButton(int soghe, int sohang)
        {
            panel1.Controls.Clear();
            int y;
            if (sohang <= 6)
            {
                y = (panel1.Size.Height - ((50 * sohang) + 15 * (sohang - 1))) / 2;//doc
            }
            else
            {
                y = 10;
            }

            for (int i = 1; i <= sohang; i++)
            {
                int x;
                if ((float)soghe / (float)sohang <= 10)
                {
                    x = (panel1.Size.Width - ((50 * ((soghe % sohang == 0) ? soghe / sohang : soghe / sohang + 1)) + 15 * (((soghe % sohang != 0) ? soghe / sohang : soghe / sohang + 1) - 1))) / 2;//ngang
                }
                else
                {
                    x = 10;
                }
                for (int j = 1; j <= (((soghe % sohang != 0 && i > soghe % sohang) || soghe % sohang == 0) ? soghe / sohang : soghe / sohang + 1); j++)
                {
                    Guna2Button bt = new Guna2Button();
                    bt.BorderRadius = 10;
                    bt.Name = String.Format(Convert.ToString("bt" + (char)(i + 64) + Convert.ToString(j)));
                    bt.Text = String.Format(Convert.ToString((char)(i + 64) + Convert.ToString(j)));
                    bt.Size = new System.Drawing.Size(50, 50);
                    bt.Location = new System.Drawing.Point(x, y);
                    bt.Cursor = System.Windows.Forms.Cursors.Hand;

                    bt.ForeColor = Color.Black;
                    bt.FillColor = Color.Gray;

                    bt.Click += new EventHandler(bt_Click);

                    panel1.Controls.Add(bt);

                    x += 65;
                }
                y += 65;
            }
        }
      
        public void CreateListLabel(DataTable seattype)
        {
            panel2.Controls.Clear();
            int y = 20;

            for (int i = 1; i <= seattype.Rows.Count; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    if (j == 1)
                    {
                        Guna2Button bt = new Guna2Button();
                        bt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                        bt.BorderRadius = 10;
                        bt.Name = String.Format(Convert.ToString("bt" + seattype.Rows[i - 1][1].ToString()));
                        bt.Text = "";
                        bt.Size = new Size(30, 30);
                        bt.FillColor = Color.FromArgb(Convert.ToInt32(seattype.Rows[i - 1][3].ToString()));
                        bt.Location = new Point(30, y);
                        panel2.Controls.Add(bt);
                    }
                    else
                    {
                        Label lb = new Label();
                        lb.AutoSize = false;
                        lb.Name = String.Format(Convert.ToString("lb" + seattype.Rows[i - 1][1].ToString()));
                        lb.Text = seattype.Rows[i - 1][1].ToString();
                        lb.Font = new Font("Microsoft Sans Serif", 14);
                        lb.Size = new Size(100, 30);
                        lb.Location = new Point(70, y);
                        panel2.Controls.Add(lb);
                    }

                }
                y += 40;
            }
        }

        public void ShowSeatBooking()
        {
            int number_of_seat = Convert.ToInt32(RoomBLL.Instance.LoadRoomByScheduleId(Schedule_id)["room_number_of_seat"].ToString());
            int number_of_row = Convert.ToInt32(RoomBLL.Instance.LoadRoomByScheduleId(Schedule_id)["room_number_of_row"].ToString());

            CreateArrayButton(number_of_seat, number_of_row);
            foreach (Guna2Button bt in panel1.Controls)
            {
                SetSeatTypeColorFromDB(bt);
                SetStatusColorFromDB(bt);
            }
        }
        public void UpdateSeatStatusInScreen()
        {
            foreach (Guna2Button bt in panel1.Controls)
            {
                for (int i = 0; i < DB.Instance.table.Rows.Count; i++)
                {
                    DataRow row = DB.Instance.table.Rows[i];
                    if (row["seat_name"].ToString() == bt.Text && row["schedule_id"].ToString() == Schedule_id.ToString())
                        bt.FillColor = Color.Firebrick;
                }
            }
           
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            d3();
            this.Hide();
        }
    }
}
