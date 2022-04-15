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
    public partial class UC_Room : UserControl
    {
        public UC_Room()
        {
            InitializeComponent();
            txtid.Enabled = false;
            ShowDGV();
        }
        public void LoadComboboxType()
        {
            cbtype.Items.Clear();
            foreach (string i in RoomBLL.Instance.GetListRoomType().Distinct())
            {
                cbtype.Items.Add(i.Trim());
            }
        }
        public Room GetRoomInScreen(bool check = false) // false: update, true: add
        {
            Room room = new Room();
            if (check == false) room.ID = Convert.ToInt32(txtid.Text);
            room.Name = txtname.Text;
            room.Room_Type_ID = RoomBLL.Instance.GetRoomTypeIDByRomeType(cbtype.SelectedItem.ToString());
            return room;
        }
        public void ShowDGV(string txt = "All")
        {
            LoadComboboxType();
            if (txt == "All") dataGridView1.DataSource = RoomBLL.Instance.LoadAllRoom();
            else dataGridView1.DataSource = RoomBLL.Instance.LoadSearchRoom(txt);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = RoomBLL.Instance.LoadRoomByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row[0].ToString().Trim();
                    txtname.Text = row[1].ToString().Trim();
                    cbtype.SelectedItem = row[2].ToString().Trim();
                }
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            cbtype.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string add = RoomBLL.Instance.Add(GetRoomInScreen(true));

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
                string update = RoomBLL.Instance.Update(GetRoomInScreen());
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
                    RoomBLL.Instance.Delete(id);
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }

        private void RoomTypeManagement_Click(object sender, EventArgs e)
        {
            FormRoomType f = new FormRoomType();
            f.d = new FormRoomType.MyDel(ShowDGV);
            f.Show();
        }
    }
}
