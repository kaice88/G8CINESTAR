using BLL;
using System;
using System.Data;
using System.Windows.Forms;
namespace GUI
{
    public partial class UC_Receipt : UserControl
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public delegate string Mydel1();
        public Mydel1 d1 { get; set; }
        public UC_Receipt()
        {
            InitializeComponent();
            ShowDGV();
        }
        public void ShowDGV(string txt = "All")
        {
            if (txt == "All") dataGridView1.DataSource = ReceiptBLL.Instance.LoadAllReceipt();
            else dataGridView1.DataSource = ReceiptBLL.Instance.LoadSearchReceipt(txt);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = ReceiptBLL.Instance.LoadReceiptById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row["receipt_id"].ToString().Trim();
                    txtstaffname.Text = row["fullname"].ToString().Trim();
                    txtcustomername.Text = row["customer_name"].ToString().Trim();
                    txtdate.Text = Convert.ToDateTime(row["date_booking"]).ToString("dd-MM-yyyy").Trim();
                    txtprice.Text = row["total_price"].ToString().Trim();
                    txtnumber.Text = row["number_of_tickets"].ToString().Trim();
                }
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void btdetail_Click(object sender, EventArgs e)
        {
            Form_TicketList f = new Form_TicketList(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), d1());
            f.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            d();
            Hide();
        }
    }
}
