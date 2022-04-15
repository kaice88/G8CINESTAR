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
    public partial class UC_SeatType : UserControl
    {
        public UC_SeatType()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string add = SeatTypeBLL.Instance.Add(GetSeatTypeInScreen(true));

            switch (add)
            {
                case "OK":
                    MessageBox.Show("ADD SUCCESSFUL");
                    ShowDGV();
                    break;
                default:
                    MessageBox.Show(add);
                    break;
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string update = SeatTypeBLL.Instance.Update(GetSeatTypeInScreen());
                switch (update)
                {
                    case "OK":
                        ShowDGV();
                        MessageBox.Show("UPDATE SUCCESSFUL");
                        break;
                    default:
                        MessageBox.Show(update);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to update.");
            }
        }
        public SeatType GetSeatTypeInScreen(bool check = false) // false: update, true: add
        {
            SeatType seattype = new SeatType();
            if (check == false) seattype.ID = Convert.ToInt32(txtid.Text.ToString());
            seattype.Name = txtseattype.Text;
            seattype.Price = Convert.ToInt32(txtprice.Text.ToString());
            return seattype;
        }
        public void ShowDGV(string txt = "All")
        {
            if (txt == "All") dataGridView1.DataSource = SeatTypeBLL.Instance.LoadAllSeatType();
            else dataGridView1.DataSource = SeatTypeBLL.Instance.LoadSearchSeatType(txt);
        }

        private void gunaDelete_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "NOTIFICATION", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        id.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                    }
                    SeatTypeBLL.Instance.Delete(id);
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtseattype.Text = "";
            txtprice.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = SeatTypeBLL.Instance.LoadSeatTypeByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row[0].ToString().Trim();
                    txtseattype.Text = row[1].ToString().Trim();
                    txtprice.Text = row[2].ToString().Trim();
                }
            }
        }
    }
}


