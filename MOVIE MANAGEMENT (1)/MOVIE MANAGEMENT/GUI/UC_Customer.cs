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
    public partial class UC_Customer : UserControl
    {
        public delegate void Mydel(string Name, string sdt, int point);
        public Mydel d { get; set; }
        public UC_Customer()
        {
            InitializeComponent();
            txtid.Enabled = false;
            txtrewardpoints.Enabled = false;
            ShowDGV();
        }
        public void ShowDGV(string txt = "All")
        {
            if (txt == "All") dataGridView1.DataSource = CustomerBLL.Instance.LoadAllCustomer();
            else dataGridView1.DataSource = CustomerBLL.Instance.LoadSearchCustomer(txt);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DataRow row = CustomerBLL.Instance.LoadCustomerByID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                    txtid.Text = row[0].ToString().Trim();
                    txtname.Text = row[1].ToString().Trim();
                    birthdaypicker.Value = Convert.ToDateTime(row[2].ToString().Trim());
                    txtaddress.Text = row[3].ToString().Trim();
                    txtphonenumber.Text = row[4].ToString().Trim();
                    txtrewardpoints.Text = row[5].ToString().Trim();
                }
            }
        }

        public Customer GetCustomerInScreen(bool check = false) // false: update, true: add
        {
            Customer customer = new Customer();
            if (check == false) customer.customer_id = Convert.ToInt32(txtid.Text);
            customer.customer_name = txtname.Text;
            customer.customer_birthday = birthdaypicker.Value;
            customer.customer_address = txtaddress.Text;
            customer.customer_phone_number = txtphonenumber.Text;
            // customer.Accumulated_Reward_Points = Convert.ToInt32(txtrewardpoints.Text); 
            return customer;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CustomerBLL.Instance.Add(GetCustomerInScreen(true)));
            ShowDGV();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
            txtrewardpoints.Text = "";
            txtphonenumber.Text = "";

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
                    CustomerBLL.Instance.Delete(id);
                    ShowDGV();
                }
            }
            else
            {
                MessageBox.Show("Please choose a row to delete.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show(CustomerBLL.Instance.Update(GetCustomerInScreen()));
                ShowDGV();
            }
            else
            {
                MessageBox.Show("Please choose a row to update.");
            }
        }
    }
}
