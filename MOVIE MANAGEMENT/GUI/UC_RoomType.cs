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
    public partial class UC_RoomType : UserControl
    {
        
        public UC_RoomType()
        {
            InitializeComponent();
            txtid.Enabled = false;
            ShowDGV();
        }
        public RoomType GetRoomTypeInScreen(bool check = false) // false: update, true: add
        {
            RoomType roomtype = new RoomType();
            if (check == false) roomtype.ID = Convert.ToInt32(txtid.Text.ToString());
            roomtype.Name = txtroomtype.Text;
            roomtype.Surcharge = Convert.ToInt32(txtsurcharge.Text.ToString());
            return roomtype;
        }
        public void ShowDGV(string txt = "All")
        {
            if (txt == "All") dataGridView1.DataSource = RoomTypeBLL.Instance.LoadAllRoomType();
            else dataGridView1.DataSource = RoomTypeBLL.Instance.LoadSearchRoomType(txt);
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtroomtype.Text = "";
            txtsurcharge.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = RoomTypeBLL.Instance.LoadRoomTypeByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row[0].ToString().Trim();
                    txtroomtype.Text = row[1].ToString().Trim();
                    txtsurcharge.Text = row[2].ToString().Trim();
                }
            }
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string add;
            try
            {
                Convert.ToInt32(txtsurcharge.Text.ToString());
                add = RoomTypeBLL.Instance.Add(GetRoomTypeInScreen(true));
            }
            catch (Exception ex)
            {
                add = "Invalid Price!";
            }
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
                string update;
                try
                {
                    Convert.ToInt32(txtsurcharge.Text.ToString());
                    update = RoomTypeBLL.Instance.Update(GetRoomTypeInScreen());
                }
                catch (Exception ex)
                {
                    update = "Invalid Price!";
                }

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
                    RoomTypeBLL.Instance.Delete(id);
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }
    }
}
