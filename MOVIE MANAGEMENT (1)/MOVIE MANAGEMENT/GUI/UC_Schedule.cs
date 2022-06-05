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
    public partial class UC_Schedule : UserControl
    {
        public UC_Schedule()
        {
            InitializeComponent();
            ShowDGV();
        }
        public void LoadComboboxMovieName()
        {
            cbbmoviename.Items.Clear();
            foreach (string i in MovieBLL.Instance.GetListMovieName().Distinct())
            {
                cbbmoviename.Items.Add(i.Trim());
            }
        }
        public void LoadComboboxRoomName()
        {
            cbbroomname.Items.Clear();
            foreach (string i in RoomBLL.Instance.GetListRoomName().Distinct())
            {
                cbbroomname.Items.Add(i.Trim());
            }
        }
        public void ShowDGV(string txt = "All")
        {
            LoadComboboxMovieName();
            LoadComboboxRoomName();
            if (txt == "All") dataGridView1.DataSource = ScheduleBLL.Instance.LoadAllSchedule();
            else dataGridView1.DataSource = ScheduleBLL.Instance.LoadSearchSchedule(txt);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = ScheduleBLL.Instance.LoadScheduleByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row["schedule_id"].ToString().Trim();
                    if (!cbbmoviename.Items.Contains(row["movie_name"].ToString().Trim()))
                        cbbmoviename.SelectedIndex = -1;
                    else cbbmoviename.Text = row["movie_name"].ToString().Trim();
                    if (!cbbroomname.Items.Contains(row["room_name"].ToString().Trim()))
                        cbbroomname.SelectedIndex = -1;
                    else cbbroomname.Text = row["room_name"].ToString().Trim();
                    dtdate.Text = row["schedule_date"].ToString().Trim();
                    dtstart.Text = row["schedule_start"].ToString().Trim();
                    dtend.Text = row["schedule_end"].ToString().Trim();
                }
            }
        }
        public Schedule GetScheduleInScreen(bool check = false) // false: update, true: add
        {
            Schedule schedule = new Schedule();
            DataRow movie = MovieBLL.Instance.GetMovieByMovieName(cbbmoviename.Text).Rows[0];
            DataRow room = RoomBLL.Instance.LoadRoomByRoomName(cbbroomname.Text).Rows[0];
            if (check == false) schedule.schedule_id = Convert.ToInt32(txtid.Text);
            schedule.schedule_date = Convert.ToDateTime(dtdate.Value.Date.ToString("yyyy-MM-dd"));
            schedule.movie_id = Convert.ToInt32(movie["movie_id"].ToString());
            schedule.movie_name = movie["movie_name"].ToString();
            schedule.room_id = Convert.ToInt32(room["room_id"].ToString());
            schedule.room_name = room["room_name"].ToString();
            schedule.schedule_start = Convert.ToDateTime(dtstart.Text);
            schedule.schedule_end = Convert.ToDateTime(dtend.Text);

            return schedule;
        }
        public string CheckScreen()
        {
            if (cbbmoviename.SelectedIndex == -1) return "Please choose Movie name.";
            if (cbbroomname.SelectedIndex == -1) return "Please choose Room name.";
            if (Convert.ToDateTime(dtdate.Value.Date.ToString("yyyy-MM-dd")) <= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")))
                return "Invaid Schedule Date! Schedule Date must after today.";
            if (Convert.ToDateTime(dtstart.Text) >= Convert.ToDateTime(dtend.Text)) 
                return "Invaid Schedule Time! The schedule end must greater than schedule start.";
            return "OK";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string check = CheckScreen();
            if (check != "OK") MessageBox.Show(check);
            else
            {
                MessageBox.Show(ScheduleBLL.Instance.Add(GetScheduleInScreen(true)));
                ShowDGV();
            }
          
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                string check = CheckScreen();
                if (check != "OK") MessageBox.Show(check);
                else
                {
                    MessageBox.Show(ScheduleBLL.Instance.UpDate(GetScheduleInScreen()));
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to update.");
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            cbbmoviename.SelectedIndex = -1;
            cbbroomname.SelectedIndex = -1;
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
                        id.Add(Convert.ToInt32(row.Cells["schedule_id"].Value.ToString()));
                    }
                    List<int> list_invalid_id = ScheduleBLL.Instance.Delete(id);
                    if (list_invalid_id.Count > 0)
                    {
                        string mes = "Schedules with id: ";
                        for(int i = 0; i < list_invalid_id.Count; i++)
                        {
                            if(i==list_invalid_id.Count-1) mes += list_invalid_id[i].ToString();
                            else mes += list_invalid_id[i].ToString() +", ";
                        }
                        MessageBox.Show(mes+ " can't be deleted because they are not finished and already have tickets sold.");
                    }
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
    }
}
