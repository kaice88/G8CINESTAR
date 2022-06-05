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
    public partial class Form_SeatType : Form
    {
        public delegate void Mydel(DataTable dt);
        public Mydel d { get; set; }
        public Form_SeatType()
        {
            InitializeComponent();
            ShowDGV();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtprice.Text.ToString());
                MessageBox.Show(SeatTypeBLL.Instance.Add(GetSeatTypeInScreen(true)));
                ShowDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Price!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    Convert.ToInt32(txtprice.Text.ToString());
                    MessageBox.Show(SeatTypeBLL.Instance.Update(GetSeatTypeInScreen()));
                    ShowDGV();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Price!");
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
            if (check == false) seattype.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());
            seattype.Name = txtseattype.Text;
            seattype.Price = Convert.ToInt32(txtprice.Text.ToString());
            seattype.Color = btcolor.FillColor.ToArgb();
            return seattype;
            
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = SeatTypeBLL.Instance.LoadAllSeatType();
        }

        private void gunaDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "NOTIFICATION", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    List<int> id = new List<int>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        id.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                    }
                    List<int> id_invalid = SeatTypeBLL.Instance.Delete(id);
                    if (id_invalid.Count > 0)
                    {
                        string mess = "Seat Types with id: ";

                        for (int i = 0; i < id_invalid.Count; i++)
                        {
                            if (i == id_invalid.Count - 1) mess += id_invalid[i].ToString();
                            else mess += id_invalid[i].ToString() + ", ";
                        }
                        MessageBox.Show(mess + " can't be deleted because some unfinished schedules use these seat type.");
                    }
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtseattype.Text = "";
            txtprice.Text = "";
            btcolor.FillColor = Color.FromArgb(22, 66, 110);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = SeatTypeBLL.Instance.LoadSeatTypeByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    txtseattype.Text = row[1].ToString().Trim();
                    txtprice.Text = row[2].ToString().Trim();
                    btcolor.FillColor = Color.FromArgb(Convert.ToInt32(row[3].ToString()));
                }
            }
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            d(SeatTypeBLL.Instance.LoadAllSeatType());
            this.Close();
        }

        private void btcolor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btcolor.FillColor = dlg.Color;
            }
        }
    }
}
