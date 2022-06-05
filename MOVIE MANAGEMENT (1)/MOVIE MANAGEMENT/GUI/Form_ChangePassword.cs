using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Form_ChangePassword : Form
    {
        public string username { get; set; }
        public Form_ChangePassword(string us)
        {
            InitializeComponent();
            username = us;
        }
        private void txtconfirmpass_TextChanged(object sender, EventArgs e)
        {
            if (txtconfirmpass.Text == txtnewpass.Text)
            {
                gunacheck.Visible = true;
            }
            else gunacheck.Visible = false;
        }

        private void buttoneyes2_Click(object sender, EventArgs e)
        {
            if (txtnewpass.UseSystemPasswordChar == false)
            {
                buttoneyes1.BringToFront();
                txtnewpass.UseSystemPasswordChar = true;
                txtnewpass.PasswordChar = '●';
            }
        }

        private void buttoneyes1_Click(object sender, EventArgs e)
        {
            if (txtnewpass.UseSystemPasswordChar == true)
            {
                buttoneyes2.BringToFront();
                txtnewpass.UseSystemPasswordChar = false;
                txtnewpass.PasswordChar = '\0';

            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.Show();
            Hide();
        }

        private void buttonchange_Click(object sender, EventArgs e)
        {
            labelfail.Text = "";
            string check = AccountBLL.Instance.ChangePass(username, txtcurrentpass.Text, txtnewpass.Text, txtconfirmpass.Text);
            switch (check)
            {
                case "OK":
                    Form_Login f = new Form_Login();
                    f.Show();
                    Hide();
                    break;
                default:
                    labelfail.Text = check;
                    txtcurrentpass.Text = "";
                    txtnewpass.Text = "";
                    txtconfirmpass.Text = "";
                    break;
            }
        }

        private void gunaback_Click_1(object sender, EventArgs e)
        {
            Form_Home f = new Form_Home(username);
            f.Show();
            this.Hide();
        }
    }
}
