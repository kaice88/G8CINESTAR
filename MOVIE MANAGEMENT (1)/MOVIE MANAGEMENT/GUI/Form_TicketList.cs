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
    public partial class Form_TicketList : Form
    {
        public string Username { get; set; }
        public int Receipt_Id { get; set; }
        public int Number_of_tickets { get; set; }
        public List<int> Booking_Id { get; set; }// list ticket đang được chọn
        public Form_TicketList(int id, string username)
        {
            Booking_Id = new List<int>();
            InitializeComponent();
            Receipt_Id = id;
            Number_of_tickets = 1;
            Username = username;   
        }
        public string TransferUsername()
        {
            return Username;
        }
        private void FormTicketList_Load(object sender, EventArgs e)
        {
            DataTable dt = BookingBLL.Instance.LoadAllTicketByReceiptId(Receipt_Id);
            int y = 15;
            int sohang = (dt.Rows.Count % 3 != 0) ? dt.Rows.Count / 3 + 1 : dt.Rows.Count / 3;
            for (int i = 1; i <= sohang; i++)
            {
                int x = 40;
                for (int j = 1; j <= ((dt.Rows.Count % 3 != 0 && i == sohang) ? dt.Rows.Count % 3 : 3); j++)
                {
                   CreatePanel(Convert.ToInt32(dt.Rows[(i - 1) * 3 + j - 1]["booking_id"].ToString().Trim()), x, y);
                    x += 290;
                }
                y += 275;
            }


        }

        public void CreatePanel(int data, int x, int y) // false: chua huy, true: huy r
        {
            UC_Ticket uc = new UC_Ticket(data);

            Guna.UI2.WinForms.Guna2Panel panel = new Guna.UI2.WinForms.Guna2Panel();
            panel.Location = new System.Drawing.Point(x, y);
            panel.Name = "panel" + x.ToString() + y.ToString();
            panel.Size = new System.Drawing.Size(255, 234);
            panel1.Controls.Add(panel);
            panel.Controls.Add(uc);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<int> booking_id = ListTicket();
            DataRow row = BookingBLL.Instance.LoadTicketById(booking_id[Number_of_tickets - 1]);

            e.Graphics.DrawString("CINESTAR CINEMA", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(90, 10));
            e.Graphics.DrawString("MOVIE TICKET", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(100, 30));
            e.Graphics.DrawString(row["movie_name"].ToString().Trim().ToUpper(), new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString("Staff:        " + row["fullname"].ToString().Trim() + "        Ticket Id: 1000", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 80));
            e.Graphics.DrawString("Customer: " + row["customer_name"].ToString().Trim() + "        Price: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString(row["price"].ToString().Trim(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(240, 100));
            e.Graphics.DrawString("Time:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 125));
            e.Graphics.DrawString(Convert.ToDateTime(row["schedule_start"].ToString().Trim()).ToString("H:mm"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 120));
            e.Graphics.DrawString("Seat: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(200, 125));
            e.Graphics.DrawString(row["seat_booking_name"].ToString().Trim(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(240, 120));
            e.Graphics.DrawString("Date:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString(Convert.ToDateTime(row["schedule_date"].ToString()).ToString("dd-MM-yyyy"), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 145));
            e.Graphics.DrawString("Room: ", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(200, 150));
            e.Graphics.DrawString(row["room_name"].ToString().Trim(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(240, 145));
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            if (Number_of_tickets < booking_id.Count)
                e.HasMorePages = true;
            else
            {
                e.HasMorePages = false;
                Number_of_tickets = 1;
            }
            Number_of_tickets++;
        }
        public void Add_Booking_Id_List()// tìm cái vé nào đang được chọn và add vào list booking_id
        {
            Booking_Id.Clear();
            foreach (Control control in panel1.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Panel)
                {
                    foreach (Control c in control.Controls)
                    {
                        if (c is UC_Ticket)
                        {
                            foreach (Control ct in c.Controls)
                            {
                                if (ct is Guna.UI2.WinForms.Guna2Panel)
                                {
                                    if (((Guna.UI2.WinForms.Guna2Panel)ct).BorderColor == System.Drawing.Color.Red)
                                    {
                                        Booking_Id.Add(((UC_Ticket)c).Booking_Id);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
                   
        private void btPrint_Click(object sender, EventArgs e)
        {
            if (Booking_Id.Count > 0) Booking_Id.Clear();
            Number_of_tickets = 1;
            Add_Booking_Id_List();

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Receipt", 300, 200);
            if (DialogResult.OK == printPreviewDialog1.ShowDialog())
            {
                printDocument1.Print();
            }
        }
        public List<int> ListTicket()
        {
            List<int> list = new List<int>();
            if (Booking_Id.Count == 0)
            {
                DataTable dt = BookingBLL.Instance.LoadAllTicketByReceiptId(Receipt_Id);
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(Convert.ToInt32(dr[0].ToString().Trim()));
                }
            }
            else
            {
                list = Booking_Id;
            }

            return list;
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            Add_Booking_Id_List();
            if (Booking_Id.Count > 0)
            {
                if (ReceiptBLL.Instance.CheckReceiptBeforeCancel(Receipt_Id))
                {
                    if (ReceiptBLL.Instance.CheckTimeBeforeCancel(Booking_Id))
                    {
                        CancelTicketsBLL.Instance.CancelTicket(Receipt_Id, Username, Booking_Id);
                        MessageBox.Show("CANCEL SUCCESSFUL");

                        Form_Payment f = new Form_Payment(Receipt_Id);
                        f.Show();
                        //Form_PaymentVoucher f = new Form_PaymentVoucher(Receipt_Id);
                        //f.d1 = new Form_PaymentVoucher.Mydel1(TransferUsername);
                        //f.Show();

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Those tickets cannot be canceled because of invalid time");// vé phải đổi trả trước 2 tiếng bắt đầu phim
                    }
                }
                else
                {
                    MessageBox.Show("Those tickets cannot be canceled because the receipt has been canceled before.");// hóa đơn này đã từng đổi trả rồi, chỉ đc đổi trả 1 lần thôi
                }
            }
            else
            {
                MessageBox.Show("Please choose ticket to cancel");
            }
        }
    }
}
