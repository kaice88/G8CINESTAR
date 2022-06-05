
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class UC_Booking1 : UserControl
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string room_type { get; set; }
        public delegate void Mydel();
        public Mydel d { get; set; }
        public delegate void Mydel2(UC_Booking2 uc);
        public Mydel2 d2 { get; set; }

        DataTable table;
        public UC_Booking1(int id)
        {
            Id = id;
            InitializeComponent();

            CreateListButtonDate(ScheduleBLL.Instance.LoadScheduleDateByMovieID(id));
            CreateListButtonRoomType(ScheduleBLL.Instance.LoadRoomTypeByMovieIdAndDate(id, Date));
            CreateListButtonSchedule(ScheduleBLL.Instance.LoadScheduleStart(Id, Date, room_type));

            table = new DataTable();
            table.Columns.Add("movie_name", typeof(string));
            table.Columns.Add("seat_name", typeof(string));
            table.Columns.Add("seat_price", typeof(int));

        }
        public void CreateListButtonDate(DataTable date)
        {
            int x = 0;
            for (int i = 1; i <= date.Rows.Count; i++)
            {
                Guna2Button bt = new Guna2Button();
                bt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                bt.BorderRadius = 10;
                bt.Name = date.Rows[(i - 1)][0].ToString();
                bt.Text = Convert.ToDateTime(date.Rows[(i - 1)][0].ToString()).ToString("dd-MM");
                bt.Cursor = Cursors.Hand;
                bt.Size = new Size(93, 50);
                bt.Location = new Point(x, 0);
                bt.FillColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
                bt.ForeColor = Color.White;

                bt.Click += new EventHandler(bt_Click1);
                if (i == 1)
                {
                    Date = Convert.ToDateTime(date.Rows[(i - 1)][0]);
                    bt.Checked = true;
                }
                panelDate.Controls.Add(bt);
                x += 100;
            }

        }
        public void CreateListButtonRoomType(DataTable roomtype)
        {
            panelRoomType.Controls.Clear();
            panelTime.Controls.Clear();
            int x = 0;
            for (int i = 1; i <= roomtype.Rows.Count; i++)
            {
                Guna2Button bt = new Guna2Button();
                bt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                bt.BorderRadius = 10;
                bt.Name = String.Format(Convert.ToString("bt" + roomtype.Rows[i - 1][0].ToString()));
                bt.Cursor = Cursors.Hand;
                bt.Text = roomtype.Rows[i - 1][0].ToString().Trim();
                bt.Size = new Size(90, 40);
                bt.Location = new Point(x, 0);
                bt.FillColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
                bt.ForeColor = Color.White;

                bt.Click += new EventHandler(bt_Click2);
                if (i == 1)
                {
                    room_type = bt.Text;
                    bt.Checked = true;
                }
                panelRoomType.Controls.Add(bt);
                x += 100;
            }

        }
        public void CreateListButtonSchedule(DataTable schedule)
        {
            panelTime.Controls.Clear();
            int x = 0;
            for (int i = 1; i <= schedule.Rows.Count; i++)
            {
                Guna2Button bt = new Guna2Button();
                bt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                bt.BorderRadius = 10;
                bt.Name = String.Format(Convert.ToString("bt" + schedule.Rows[i - 1][0].ToString()));
                bt.Text = Convert.ToDateTime(schedule.Rows[i - 1][0].ToString().Trim()).ToString("H:mm");
                bt.Cursor = Cursors.Hand;
                bt.Size = new Size(80, 35);
                bt.Location = new Point(x, 0);
                bt.FillColor = Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
                bt.ForeColor = Color.White;

                bt.Click += new EventHandler(bt_Click3);

                panelTime.Controls.Add(bt);
                x += 100;
            }

        }
        private void bt_Click1(object sender, EventArgs e)
        {
            Date = Convert.ToDateTime(((Guna2Button)sender).Name);
            CreateListButtonRoomType(ScheduleBLL.Instance.LoadRoomTypeByMovieIdAndDate(Id, Date));
            CreateListButtonSchedule(ScheduleBLL.Instance.LoadScheduleStart(Id, Date, room_type));
        }
        private void bt_Click2(object sender, EventArgs e)
        {
            room_type = ((Guna2Button)sender).Text;
            CreateListButtonSchedule(ScheduleBLL.Instance.LoadScheduleStart(Id, Date, room_type));
        }
        private void bt_Click3(object sender, EventArgs e)
        {
            UC_Booking2 uc = new UC_Booking2(ScheduleBLL.Instance.LoadID(Id, Date, room_type, ((Guna2Button)sender).Text.ToString()));
            d2(uc);
        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            d();
            this.Hide();
        }
    }

}
