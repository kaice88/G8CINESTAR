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
    public partial class Form_RoomType : Form
    {
        public delegate void Mydel();
        public Mydel d_ShowDGV { get; set; }
        public delegate void Mydel1(string txt);
        public Mydel1 d_LoadComboboxType { get; set; }
        public Form_RoomType()
        {
            InitializeComponent();
            ShowDGV();
        }
        public RoomType GetRoomTypeInScreen(bool check = false) // false: update, true: add
        {
            RoomType roomtype = new RoomType();
            if (check == false) roomtype.room_type_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["room_type_id"].Value.ToString().Trim());
            roomtype.room_type = txtroomtype.Text;
            roomtype.room_type_price_percent = Convert.ToInt32(txtsurcharge.Text.ToString());
            return roomtype;
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = RoomTypeBLL.Instance.LoadAllRoomType();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtsurcharge.Text.ToString());
                MessageBox.Show(RoomTypeBLL.Instance.Add(GetRoomTypeInScreen(true)));
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
                    Convert.ToInt32(txtsurcharge.Text.ToString());
                    MessageBox.Show(RoomTypeBLL.Instance.Update(GetRoomTypeInScreen()));
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
                    List<int> id_invalid = RoomTypeBLL.Instance.Delete(id);
                    if (id_invalid.Count > 0)
                    {
                        string mess = "Room Types with id: ";

                        for(int i = 0;i< id_invalid.Count; i++)
                        {
                            if(i == id_invalid.Count -1) mess+=id_invalid[i].ToString();
                            else mess += id_invalid[i].ToString()+", ";
                        }
                        MessageBox.Show(mess + " can't be deleted because some unfinished schedules use these room type.");
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
                    txtroomtype.Text = row[1].ToString().Trim();
                    txtsurcharge.Text = row[2].ToString().Trim();
                }
            }
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            d_ShowDGV();
            d_LoadComboboxType("All");
            this.Close();
        }
    }
}
