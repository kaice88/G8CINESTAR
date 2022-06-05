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
    public partial class Form_ResetMK2 : Form
    {
        public Form_ResetMK2()
        {
            InitializeComponent();
        }
        private void gunaChange_Click(object sender, EventArgs e)
        {
            if(AccountBLL.Instance.CheckOTP(txtcode.Text))
            {
                Form_ResetMK3 f = new Form_ResetMK3();
                f.Show();
                Hide();
            }
            else
            {
                labelfail.Text = "The security code is incorrect. Try again.";
                txtcode.Text = "";
            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.Show();
            Hide();
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
