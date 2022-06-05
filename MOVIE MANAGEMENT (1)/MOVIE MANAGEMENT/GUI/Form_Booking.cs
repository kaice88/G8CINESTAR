using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace GUI
{
    public partial class Form_Booking : Form
    {
        public int Customer_id { get; set; }
        public string Username { get; set; }
        public Form_Booking(string username)
        {
            InitializeComponent();
            Username = username;
        }
        public void AddDataSource(DataTable data)
        {
            dataGridView1.DataSource = data;
            txtsub.Text = SubTotal().ToString();
            txttotal.Text = (Convert.ToInt32(txtsub.Text.ToString()) - Convert.ToInt32(txtdiscount.Text.ToString())).ToString();
        }

        public void AddUC3(UC_Booking2 uc)
        {
            paneltrans.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            paneltrans.Controls.Add(uc);
            uc.d = new UC_Booking2.Mydel(AddDataSource);
            uc.d2 = new UC_Booking2.Mydel2(AddUC);
            uc.d3 = new UC_Booking2.Mydel3(ShowTab);
        }
        public void AddUC(UserControl uc)
        {
            paneltrans.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            paneltrans.Controls.Add(uc);
        }

        private void Form_Booking_Load(object sender, EventArgs e)
        {
            CreatePictureBox(MovieBLL.Instance.LoadAllMovieNowPlaying(), page1);
            CreateLabel(MovieBLL.Instance.LoadAllMovieNowPlaying(), page1);
            CreatePictureBox(MovieBLL.Instance.LoadAllMovieComingSoon(), page2);
            CreateLabel(MovieBLL.Instance.LoadAllMovieComingSoon(), page2);
        }
        public void CreatePictureBox(DataTable picture, TabPage page)
        {
            int y = 46;
            int sohang = (picture.Rows.Count % 5 != 0) ? picture.Rows.Count / 5 + 1 : picture.Rows.Count / 5;
            for (int i = 1; i <= sohang; i++)
            {
                int x = 40;
                for (int j = 1; j <= ((picture.Rows.Count % 5 != 0 && i == sohang) ? picture.Rows.Count % 5 : 5); j++)
                {
                    Guna2PictureBox bt = new Guna2PictureBox();
                    bt.BorderRadius = 10;
                    bt.ImageRotate = 0F;
                    bt.Location = new Point(x, y);
                    bt.Name = picture.Rows[(i - 1) * 5 + j - 1]["movie_id"].ToString().Trim();// name is id
                    bt.Size = new Size(142, 165);
                    bt.SizeMode = PictureBoxSizeMode.StretchImage;
                    bt.Cursor = Cursors.Hand;
                    bt.Image = byteArrayToImage((byte[])picture.Rows[(i - 1) * 5 + j - 1][5]);
                    if (page == page2)
                    {
                        if (picture.Rows[(i - 1) * 5 + j - 1]["status"].ToString().Trim() == "YES")
                        {
                            bt.BorderStyle = BorderStyle.FixedSingle;
                            bt.Click += new EventHandler(pt_Click);
                        }
                    }
                    else bt.Click += new EventHandler(pt_Click);

                    page.Controls.Add(bt);

                    x += 180;
                }
                y += 320;
            }
        }
        public void CreateLabel(DataTable infor, TabPage page)
        {
            int y = 220;
            int sohang = (infor.Rows.Count % 5 != 0) ? infor.Rows.Count / 5 + 1 : infor.Rows.Count / 5;
            for (int i = 1; i <= sohang; i++)
            {
                int x = 40;
                for (int j = 1; j <= ((infor.Rows.Count % 5 != 0 && i == sohang) ? infor.Rows.Count % 5 : 5); j++)
                {
                    Label lb = new Label();
                    lb.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lb.Location = new System.Drawing.Point(x, y);
                    lb.Name = "lb" + infor.Rows[(i - 1) * 5 + j - 1][0].ToString();// name is id;
                    lb.Size = new System.Drawing.Size(160, 130);
                    lb.Text = infor.Rows[(i - 1) * 5 + j - 1][1].ToString().Trim().ToUpper() + "\r\nGenre: " + infor.Rows[(i - 1) * 5 + j - 1][2].ToString().Trim() +
                        "\r\nLength: " + infor.Rows[(i - 1) * 5 + j - 1][3].ToString().Trim() + " min\r\nRelease date: " + Convert.ToDateTime(infor.Rows[(i - 1)][4].ToString().Trim()).ToString("dd-MM-yyyy");

                    page.Controls.Add(lb);

                    x += 180;
                }
                y += 320;
            }
        }
        private void pt_Click(object sender, EventArgs e)
        {
            UC_Booking1 uc = new UC_Booking1(Convert.ToInt32(((Guna2PictureBox)sender).Name));
            tab1.Hide();
            AddUC(uc);
            uc.Show();
            uc.d = new UC_Booking1.Mydel(ShowTab);
            uc.d2 = new UC_Booking1.Mydel2(AddUC3);
        }
        public void ShowTab()
        {
            tab1.Show();
        }
        public string TransferUsername()
        {
            return Username;
        }
        public Image byteArrayToImage(byte[] image)
        {
            MemoryStream memoryStream = new MemoryStream(image, 0, image.Length);
            memoryStream.Write(image, 0, image.Length);
            //Exception occurs here
            return Image.FromStream(memoryStream, true);

        }

        public void ShowCustomer(int id, string Name, string sdt, int point)
        {
            Customer_id = id;
            lbName.Text = Name;
            lbName.ForeColor = Color.Brown;
            lbPhone.Text = sdt.ToString();
            lbPhone.ForeColor = Color.Brown;
            lbrewardpoint.Text = point.ToString();
            lbrewardpoint.ForeColor = Color.Brown;
            txtdiscount.Text = (point * 1000).ToString();
            txttotal.Text = (Convert.ToInt32(txtsub.Text.ToString()) - Convert.ToInt32(txtdiscount.Text.ToString())).ToString();
        }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Form_Customer f = new Form_Customer();
                f.d = new Form_Customer.Mydel(ShowCustomer);
                f.Show();
            } 
        }

        public int SubTotal()
        {
            int sub_total = 0;
            for (int i = 0; i < DB.Instance.table.Rows.Count; i++)
            {
                DataRow row = DB.Instance.table.Rows[i];
                sub_total += Convert.ToInt32(row[2].ToString());
            }
            return sub_total;
        }
        private void btbooking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1) // =1 là rỗng, ko biết lí do
            {
                MessageBox.Show(BookingBLL.Instance.Booking(DataGridViewToDataTable(dataGridView1), Username, Customer_id, Convert.ToInt32(txttotal.Text)));

                DB.Instance.table.Rows.Clear();
                guna2CheckBox1.Checked = false;
                lbName.Text = "";
                lbPhone.Text = "";
                lbrewardpoint.Text = "";
                txtdiscount.Text = "0";
                txtsub.Text = "0";
                txttotal.Text = "0";              
                Form_Receipt f = new Form_Receipt(ReceiptBLL.Instance.GetLastReceiptId());
                f.Show();

                tab1.Show();
                
            }
            else
            {
                MessageBox.Show("Please choose a seat to book");
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Hide();
         /*   if (!Convert.ToBoolean(AccountBLL.Instance.LoadAccountByUsername(Username).Rows[0]["role"].ToString().Trim()))// nv
            {
                Form_Login f = new Form_Login();
                f.Show();
            }*/
        }


        private void butCancel_Click(object sender, EventArgs e)
        {
            foreach (Control control in paneltrans.Controls)
            {
                control.Hide();
            }
            tab1.Hide();
            UC_Receipt uc = new UC_Receipt();
            uc.d = new UC_Receipt.Mydel(ShowTab);
            uc.d1 = new UC_Receipt.Mydel1(TransferUsername);
            uc.BringToFront();
            paneltrans.Controls.Add(uc);
            uc.Location = new Point((paneltrans.Size.Width - uc.Size.Width) / 2, (paneltrans.Size.Height - uc.Size.Height) / 2);
        }
        private DataTable DataGridViewToDataTable(DataGridView dataGridView)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            for(int i=0;i<dataGridView.Rows.Count - 1; i++)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in dataGridView.Rows[i].Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            return dt;
        }
    }
}
