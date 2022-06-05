using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class UC_Ticket : UserControl
    {
        public int Booking_Id { get; set; }
        public UC_Ticket(int id)//false: chua huy, true: da huy
        {
            InitializeComponent();
            Booking_Id = id;
        }

        private void UC_Ticket_Load(object sender, EventArgs e)
        {
            DataRow row = BookingBLL.Instance.LoadTicketById(Booking_Id);
            if (Convert.ToBoolean(row["booking_status"].ToString())==false) {
                lbCancel.Visible = true;
                panel1.Click -= new EventHandler(UC_Click);
                panel1.BackColor = Color.LightGray;
                foreach (Control control in panel1.Controls)
                {
                    control.Click -= new EventHandler(UC_Click);

                }
            }

            lbName.Text = row["movie_name"].ToString().Trim().ToUpper();
            lbStaff.Text = row["fullname"].ToString().Trim();
            lbCustomer.Text = row["customer_name"].ToString().Trim();
            lbDate.Text = Convert.ToDateTime(row["schedule_date"].ToString()).ToString("dd-MM-yyyy");
            lbId.Text += row["booking_id"].ToString().Trim();
            lbPrice.Text = row["booking_price"].ToString().Trim();
            lbTime.Text = Convert.ToDateTime(row["schedule_start"].ToString().Trim()).ToString("H:mm");
            lbSeat.Text = row["seat_booking_name"].ToString().Trim();
            lbRoom.Text = row["room_name"].ToString().Trim();
            lbNow.Text = row["date_booking"].ToString().Trim();

        }

        private void UC_Click(object sender, EventArgs e)
        {
            if (panel1.BorderColor == Color.Red)
            {
                panel1.BorderColor = Color.Black;
            }
            else
            {
                panel1.BorderColor = Color.Red;
            }
        }
    }
}
