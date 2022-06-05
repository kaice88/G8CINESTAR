using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_Room : UserControl
    {
        public UC_Room()
        {
            InitializeComponent();
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
            if (check == false) room.room_id = Convert.ToInt32(txtid.Text);
            room.room_name = txtname.Text;
            room.room_type_id = Convert.ToInt32(RoomTypeBLL.Instance.GetRoomTypeIDAndPercentByRoomType(cbtype.SelectedItem.ToString())["room_type_id"].ToString());
            room.room_type_name = cbtype.SelectedItem.ToString();
            return room;
        }
        public void ShowDGV(string txt = "All")
        {
            LoadComboboxType();
            if (txt == "All") dataGridView1.DataSource = RoomBLL.Instance.LoadAllRoomView();
            else dataGridView1.DataSource = RoomBLL.Instance.LoadSearchRoom(txt);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {   
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = RoomBLL.Instance.LoadRoomViewByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row["room_id"].ToString().Trim();
                    txtname.Text = row["room_name"].ToString().Trim();
                    if(row["room_type"].ToString().Trim() == "NULL")
                    {
                        cbtype.SelectedIndex = -1;
                    }
                    else cbtype.SelectedItem = row["room_type"].ToString().Trim();
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
            MessageBox.Show(RoomBLL.Instance.Add(GetRoomInScreen(true)));
            ShowDGV();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show(RoomBLL.Instance.Update(GetRoomInScreen()));
                ShowDGV();
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

                    List<int> id_invalid = RoomBLL.Instance.Delete(id);
                    if (id_invalid.Count > 0)
                    {
                        string mess = "Rooms with id: ";
                        for (int i = 0; i < id_invalid.Count; i++)
                        {
                            if (i == id_invalid.Count - 1) mess += id_invalid[i].ToString();
                            else mess += id_invalid[i].ToString() + ", ";
                        }
                        MessageBox.Show(mess+ " can't be deleted because some unfinished schedules have this room.");
                    }
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }

       
        private void btSeatMap_Click(object sender, EventArgs e)
        {
            Form_SeatMap f = new Form_SeatMap();
            f.Show();
            f.d_ShowDGV = new Form_SeatMap.Mydel(ShowDGV) ;
        }

        private void btRoomType_Click(object sender, EventArgs e)
        {
            Form_RoomType f = new Form_RoomType();
            f.d_ShowDGV = new Form_RoomType.Mydel(LoadComboboxType);
            f.d_LoadComboboxType = new Form_RoomType.Mydel1(ShowDGV);
            f.Show();
        }
    }
}
