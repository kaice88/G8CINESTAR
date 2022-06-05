using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class Form_SeatMap : Form
    {
        public Point point1 { get; set; }
        public Point point2 { get; set; }
        public Rectangle rectangle { get; set; }
        public delegate void Mydel(string txt);
        public Mydel d_ShowDGV { get; set; }
        
        public Form_SeatMap()
        {
            InitializeComponent();
            LoadComboboxRoomName();
            CreateListLabel(SeatTypeBLL.Instance.LoadAllSeatType());
        }
        public void LoadComboboxRoomName()
        {
            cbbRoomName.Items.Clear();
            foreach (string i in RoomBLL.Instance.GetListRoomName().Distinct())
            {
                cbbRoomName.Items.Add(i.Trim());
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
                        bt.BorderColor = Color.Black;
                        bt.Cursor = Cursors.Hand;
                        bt.Click += new EventHandler(butSeatType_Click);
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
                if ((float)soghe / (float)sohang <=10)
                {
                    x = (panel1.Size.Width - ((50 * ((soghe % sohang == 0)  ? soghe / sohang : soghe / sohang + 1)) + 15 * (((soghe % sohang != 0) ? soghe / sohang : soghe / sohang + 1) - 1))) / 2;//ngang
                }
                else
                {
                    x = 10;
                } 
                for (int j = 1; j <= (((soghe % sohang != 0 && i > soghe % sohang) || soghe % sohang == 0) ? soghe / sohang: soghe/sohang+1); j++)
                {
                    Guna2Button bt = new Guna2Button();
                    bt.BorderRadius = 10;
                    bt.Name = String.Format(Convert.ToString("bt" + (char)(i + 64) + Convert.ToString(j)));
                    bt.Text = String.Format(Convert.ToString((char)(i + 64) + Convert.ToString(j)));
                    bt.Size = new Size(50,50);
                    bt.Location = new Point(x, y);

                    bt.ForeColor = Color.Black;
                    bt.FillColor = Color.Gray;

                    bt.Click += new EventHandler(butSeat_Click);

                    panel1.Controls.Add(bt);

                    x += 65;
                }
                y += 65;
            }
        }
        private void butSeat_Click(object sender, EventArgs e)
        {
            if (CheckedSeatTypeButton())// chon loai ghe chua
            {
                SetSeatTypeColor((Guna2Button)sender);
            }
        }
        private void butSeatType_Click(object sender, EventArgs e)
        {
            foreach(Control control in panel2.Controls)
            {
                if(control is Guna2Button)
                {
                    if (((Guna2Button)control).Name == ((Guna2Button)sender).Name)
                    {
                        ((Guna2Button)control).BorderColor = Color.Black;
                        ((Guna2Button)control).BorderThickness = 2;
                    }
                    else ((Guna2Button)control).BorderThickness = 0;
                }
            }
        }
        public bool CheckedSeatTypeButton()
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is Guna2Button && ((Guna2Button)control).Checked) return true;
            }
            return false;
        }
        public void SetSeatTypeColor(Guna2Button bt)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is Guna2Button && ((Guna2Button)control).Checked)
                {
                    bt.FillColor = ((Guna2Button)control).FillColor;
                    break;
                }
            }
        }
        public void SetSeatTypeColorFromDB(Guna2Button bt, int room_id)
        {
            bt.FillColor = Color.FromArgb(SeatBLL.Instance.GetSeatTypeColorByRoomIDAndSeatName(room_id,bt.Text));
        }
        
        private void butsetup_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                if (cbbRoomName.SelectedIndex != -1)
                {
                    CreateArrayButton(Convert.ToInt32(txtsoghe.Text.ToString()), Convert.ToInt32(txtsohang.Text.ToString()));
                }
                else
                {
                    MessageBox.Show("Please choose room name.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter number for number of seat and number of row");
            }
        }
        public bool CheckSetColor()
        {
            foreach (Guna2Button bt in panel1.Controls)
            {
                if (bt.FillColor.ToArgb() == Color.Gray.ToArgb())
                    return false;
            }
            return true;
        }
        public List<Seat> GetSeatInScreen()
        {
            List<Seat> seat = new List<Seat>();
            foreach (Guna2Button bt in panel1.Controls)
            {
                Seat s = new Seat();
                s.seat_type_id = Convert.ToInt32(SeatTypeBLL.Instance.LoadIDBySeatTypeColor(bt.FillColor.ToArgb())[0].ToString());
                s.room_id = Convert.ToInt32(RoomBLL.Instance.LoadRoomByRoomName(cbbRoomName.SelectedItem.ToString()).Rows[0]["room_id"].ToString());
                s.seat_name = bt.Text;
                seat.Add(s);
            }
            
            return seat;
        }
        
        private void btOK_Click(object sender, EventArgs e)
        {
            if (!panel1.HasChildren)
            {
                MessageBox.Show("You have not set up any room");
            }
            else if (!CheckSetColor())
            {
                MessageBox.Show("You haven't set up all the seats yet");
            }
            else
            {
                MessageBox.Show(SeatMapBLL.Instance.SetSeatMap(cbbRoomName.SelectedItem.ToString(),Convert.ToInt32(txtsoghe.Text), Convert.ToInt32(txtsohang.Text), GetSeatInScreen()));
            }
        }

        private void btSeatType_Click(object sender, EventArgs e)
        {
            Form_SeatType f = new Form_SeatType();
            f.d = new Form_SeatType.Mydel(CreateListLabel);
            f.Show();
        }

        private void cbbRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Controls.Clear();
            DataTable dt = RoomBLL.Instance.LoadRoomByRoomName(cbbRoomName.SelectedItem.ToString());
            txtsoghe.Text = dt.Rows[0]["room_number_of_seat"].ToString().Trim();
            txtsohang.Text = dt.Rows[0]["room_number_of_row"].ToString().Trim();
            if(txtsoghe.Text != "0"|| txtsohang.Text != "0")
            {
                CreateArrayButton(Convert.ToInt32(txtsoghe.Text), Convert.ToInt32(txtsohang.Text));
                foreach (Guna2Button bt in panel1.Controls)
                {
                    SetSeatTypeColorFromDB(bt, Convert.ToInt32(dt.Rows[0]["room_id"].ToString().Trim()));
                }
            }
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            d_ShowDGV("All");
            this.Close();
        }
        public void SetSeatTypeColor()
        {
            foreach (Guna2Button bt in panel1.Controls)
            {
                if (rectangle.Contains(bt.Location) || rectangle .Contains(new Point(bt.Location.X + 50, bt.Location.Y))
                    || rectangle.Contains(new Point(bt.Location.X + 50, bt.Location.Y + 50)) || rectangle.Contains(new Point(bt.Location.X, bt.Location.Y + 50)))
                {
                    SetSeatTypeColor(bt);
                }
            }
        }
        public void PaintRectangel(MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Red, 2f);
            p.DashPattern = new float[] { 5, 5, 5, 5 };
            rectangle = new Rectangle(point1.X, point1.Y, e.Location.X - point1.X, e.Location.Y - point1.Y);
            g.DrawRectangle(p, rectangle);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Location.X - point1.X != 0 && e.Location.Y - point1.Y != 0 && panel1.HasChildren)
            {
                point2 = e.Location;
                PaintRectangel(e);
                if (CheckedSeatTypeButton())
                {
                    Thread.Sleep(200);
                    SetSeatTypeColor();
                }
                else
                {
                    MessageBox.Show("Please choose Seat Type before set color!");
                    
                }
                panel1.Invalidate();
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Location.X - point1.X !=0 && e.Location.Y - point1.Y!=0 && panel1.HasChildren)
            {
                panel1.Invalidate();
                PaintRectangel(e);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point1 = e.Location;
            }
        }
    }
}
