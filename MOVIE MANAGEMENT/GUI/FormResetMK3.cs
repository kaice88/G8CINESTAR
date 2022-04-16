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
    public partial class FormResetMK3 : Form
    {
        public FormResetMK3()
        {
            InitializeComponent();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            labelfail.Text = "";
            string check = AccountBLL.Instance.ResetPass(txtnewpass.Text,txtconfirmpass.Text);
            switch (check)
            {
                case "OK":
                    FormDangNhap f = new FormDangNhap();
                    f.Show();
                    Hide();
                    break;
                default:
                    labelfail.Text = check;
                    txtconfirmpass.Text = "";
                    break;
            }
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
            FormDangNhap f = new FormDangNhap();
            f.Show();
            Hide();
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
