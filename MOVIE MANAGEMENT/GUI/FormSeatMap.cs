using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormSeatMap : Form
    {
        public int Room_ID { get; set; }
        public FormSeatMap(int room_id = 1)
        {
            InitializeComponent();
            Room_ID = room_id;
            //txtsoghe.Text = Convert.ToString(Color.Orange.ToArgb());
            //txtsohang.Text = Color.FromArgb(Convert.ToInt32(txtsoghe.Text)).ToString();
            //butsetup.BackColor = System.Drawing.Color.FromArgb(Color.Orange.ToArgb());
            CreateListLabel(SeatTypeBLL.Instance.LoadAllSeatType(), group,panel2);
            txtsoghe.Text = RoomBLL.Instance.GetNumberofSeatByID(Room_ID).ToString();
            txtsohang.Text = RoomBLL.Instance.GetNumberofRowByID(Room_ID).ToString();
           
        }
        public Panel SetPanel(Panel panel)
        {
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(661, 451);
            return panel;
        }

        public void CreateArrayButton(int soghe, int sohang, Panel panel)
        {
            int y = 0;
            int soghetronghang = soghe / sohang;
            if (soghe % sohang != 0) soghetronghang += 1;

            for (int i = 1; i <= sohang; i++)
            {
                int x = 0;
                if ((soghe % sohang != 0) && (i > soghe % sohang)) soghetronghang = soghe / sohang;
                for (int j = 1; j <= soghetronghang; j++)
                {

                    Guna.UI2.WinForms.Guna2Button bt = new Guna.UI2.WinForms.Guna2Button();
                    bt.BorderRadius = 10;
                    bt.Name = String.Format(Convert.ToString("bt" + (char)(i + 64) + Convert.ToString(j)));
                    bt.Text = String.Format(Convert.ToString((char)(i + 64) + Convert.ToString(j)));
                    bt.Size = new System.Drawing.Size(50,50);
                    bt.Location = new System.Drawing.Point(x, y);

                    bt.ForeColor = Color.Black;
                    bt.FillColor = Color.White;

                    bt.Click += new EventHandler(bt_Click);

                    panel.Controls.Add(bt);

                    x += 65;
                }
                y += 65;
            }
        }
        private void bt_Click(object sender, EventArgs e)
        {
            SetSeatTypeColor(SeatTypeBLL.Instance.LoadAllSeatType(), ((Guna.UI2.WinForms.Guna2Button)sender));
        }
        private void bt_Click2(object sender, EventArgs e)
        {
            if (group.HasChildren)
            {
                foreach (Control childControl in group.Controls)
                {
                    if (childControl.Name == ((Guna.UI2.WinForms.Guna2Button)sender).Name)
                    {
                        //MessageBox.Show(childControl.Name + "\n"+ ((Guna.UI2.WinForms.Guna2Button)sender).Name);

                        ((Guna.UI2.WinForms.Guna2Button)childControl).BorderColor = Color.Black;
                        ((Guna.UI2.WinForms.Guna2Button)childControl).BorderThickness = 2;
                    }
                    else
                    {
                        //MessageBox.Show(childControl.Name);
                        ((Guna.UI2.WinForms.Guna2Button)childControl).BorderThickness = 0;
                    }

                }
            }
            
        }
        public bool CheckButton()
        {
            if (group.HasChildren)
            {
                foreach (Control childControl in group.Controls)
                {
                    if (((Guna.UI2.WinForms.Guna2Button)childControl).Checked)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }
        public void SetSeatTypeColor(DataTable seattype, Guna.UI2.WinForms.Guna2Button bt)
        {
            if (group.HasChildren && CheckButton())
            {
                foreach (Control childControl in group.Controls)
                {
                    if (((Guna.UI2.WinForms.Guna2Button)childControl).Checked)
                    {
                        bt.FillColor = ((Guna.UI2.WinForms.Guna2Button)childControl).FillColor;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose Seat Type!");
            }
        }
        // them moi 21_4
        public void SetSeatTypeColorFromDB(Guna.UI2.WinForms.Guna2Button bt)
        {

            bt.FillColor = System.Drawing.Color.FromArgb(SeatTypeBLL.Instance.GetSeatTypeColorByID(SeatBLL.Instance.GetSeatTypeIdBySeatId(SeatBLL.Instance.GetSeatIDByRoomIDandSeatName(Room_ID, bt.Text.ToString()))));
        }
        //
        public void CreateListLabel(DataTable seattype, GroupBox group, Panel panel)
        {
            int y = 20;

            for (int i = 1; i <= seattype.Rows.Count; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    if (j == 1)
                    {
                        Guna.UI2.WinForms.Guna2Button bt = new Guna.UI2.WinForms.Guna2Button();
                        bt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                        bt.BorderRadius = 10;
                        bt.Name = String.Format(Convert.ToString("bt" + seattype.Rows[i - 1][1].ToString()));
                        bt.Text = "";
                        bt.Size = new System.Drawing.Size(30, 30);
                        bt.FillColor = System.Drawing.Color.FromArgb(Convert.ToInt32(seattype.Rows[i - 1][3].ToString()));
                        bt.Location = new System.Drawing.Point(30, y);
                        bt.Click += new EventHandler(bt_Click2);
                        group.Controls.Add(bt);
                    }
                    else
                    {
                        Label lb = new Label();
                        lb.AutoSize = false;
                        lb.Name = String.Format(Convert.ToString("lb" + seattype.Rows[i - 1][1].ToString()));
                        lb.Text = seattype.Rows[i - 1][1].ToString();
                        lb.Font = new Font("Microsoft Sans Serif", 14);
                        lb.Size = new System.Drawing.Size(200, 30);
                        lb.Location = new System.Drawing.Point(70, y);
                        panel.Controls.Add(lb);
                    }
                    
                }
                y += 40;
            }
        }
        
        private void butsetup_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (panel1.HasChildren)
                {
                    foreach (Control childControl in panel1.Controls)
                    {
                        panel1.Controls.Remove(childControl);
                        childControl.Dispose();
                    }
                }
                System.Windows.Forms.Panel panel3 = new System.Windows.Forms.Panel();
                panel3 = SetPanel(panel3);
                panel1.Controls.Add(panel3);
                foreach (Control childControl in panel1.Controls)
                {
                    CreateArrayButton(Convert.ToInt32(txtsoghe.Text.ToString()), Convert.ToInt32(txtsohang.Text.ToString()), (Panel)childControl);
                }
                foreach (Control childControl in panel1.Controls)
                {
                    foreach (Guna.UI2.WinForms.Guna2Button bt in childControl.Controls)
                    {
                        SetSeatTypeColorFromDB(bt);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số cho số hàng và số ghế");
            }

        }
        public bool CheckSetColor()
        {
            foreach (Control childControl in panel1.Controls)
            {
                foreach (Guna.UI2.WinForms.Guna2Button bt in childControl.Controls)
                {
                    if (bt.FillColor.ToArgb() == Color.White.ToArgb())
                        return false;
                }
            }
            return true;
        }
        public List<Seat> GetSeatInScreen()
        {
            List<Seat> seat = new List<Seat>();
            foreach (Control childControl in panel1.Controls)
            {
                foreach (Guna.UI2.WinForms.Guna2Button bt in childControl.Controls)
                {
                    Seat s = new Seat();
                    s.seat_type_ID = Convert.ToInt32(SeatTypeBLL.Instance.LoadIDBySeatTypeColor(bt.FillColor.ToArgb())[0].ToString());
                    s.room_ID = Room_ID;
                    s.Name = bt.Text;
                    seat.Add(s);
                }
            }
            return seat;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            if (!panel1.HasChildren)
            {
                MessageBox.Show("Bạn chưa setup số ghê, số hàng");
            }
            else if (!CheckSetColor())
            {
                MessageBox.Show("Bạn chưa setup hết loại ghế");
            }
            else
            {
                List<Seat> seat = new List<Seat>();
                seat = GetSeatInScreen();
                SeatBLL.Instance.Add(seat);
                MessageBox.Show("ADD SUCCESSFUL");
            }
        }
        
    }
}
