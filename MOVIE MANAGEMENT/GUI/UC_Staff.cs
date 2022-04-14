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
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
            txtid.Enabled = false;
            ShowDGV();
        }
        public void ShowDGV(string txt = "All")
        {
            if(txt == "All") dataGridView1.DataSource = AccountBLL.Instance.LoadAllAccount();
            else dataGridView1.DataSource = AccountBLL.Instance.LoadSearchAccount(txt);
        }
        public Account GetAccountInScreen(bool check = false) // false: update, true: add
        {
            Account account = new Account();
            if(check == false)account.ID = Convert.ToInt32(txtid.Text);
            account.Fullname = txtfullname.Text;
            account.Username = txtusername.Text;
            account.Phone = txtphonenumber.Text;
            account.Email = txtemail.Text;
            if(check) account.Password = txtusername.Text; 
            if (rbManager.Checked == true) account.Role = true;
            else account.Role = false;
            return account;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string add = AccountBLL.Instance.Add(GetAccountInScreen(true));

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
                string update = AccountBLL.Instance.Update(GetAccountInScreen());
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

        private void butSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if(dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = AccountBLL.Instance.LoadAccountByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row[0].ToString().Trim();
                    txtfullname.Text = row[1].ToString().Trim();
                    txtusername.Text = row[2].ToString().Trim();
                    txtphonenumber.Text = row[3].ToString().Trim();
                    txtemail.Text = row[4].ToString().Trim();
                    if (Convert.ToBoolean(row[5].ToString())) rbManager.Checked = true;
                    else rbStaff.Checked = true;
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtfullname.Text = "";
            txtusername.Text = "";
            txtphonenumber.Text = "";
            txtemail.Text = "";
            rbManager.Checked = true;
        }

        private void gunaDelete_Click(object sender, EventArgs e)
        {
            List<int> id = new List<int>();
            if (dataGridView1.SelectedRows.Count > 0)
            {   
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    id.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                }
                AccountBLL.Instance.Delete(id);
                ShowDGV();
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }

        private void UC_Staff_Load(object sender, EventArgs e)
        {
          
        }
    }
}
