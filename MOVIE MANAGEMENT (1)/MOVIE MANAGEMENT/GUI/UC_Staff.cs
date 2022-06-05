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
            if(check == false) account.id_number = Convert.ToInt32(txtid.Text);
            account.fullname = txtfullname.Text;
            account.username = txtusername.Text;
            account.phone_number = txtphonenumber.Text;
            account.email = txtemail.Text;
            account.role = rbManager.Checked;
            return account;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AccountBLL.Instance.Add(GetAccountInScreen(true)));
            ShowDGV();
        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show(AccountBLL.Instance.Update(GetAccountInScreen()));
                ShowDGV();
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
                    DataRow row = AccountBLL.Instance.LoadAccountByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_number"].Value.ToString()));

                    txtid.Text = row["id_number"].ToString().Trim();
                    txtfullname.Text = row["fullname"].ToString().Trim();
                    txtusername.Text = row["username"].ToString().Trim();
                    txtphonenumber.Text = row["phone_number"].ToString().Trim();
                    txtemail.Text = row["email"].ToString().Trim();
                    if (Convert.ToBoolean(row["role"].ToString())) rbManager.Checked = true;
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
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "NOTIFICATION", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        id.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                    }
                    AccountBLL.Instance.Delete(id);
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
