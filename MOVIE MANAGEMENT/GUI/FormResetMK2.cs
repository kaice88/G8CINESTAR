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
    public partial class FormResetMK2 : Form
    {
        public FormResetMK2()
        {
            InitializeComponent();
        }
        private void gunaChange_Click(object sender, EventArgs e)
        {
            string otp = txtcode.Text;
            if(AccountBLL.Instance.CheckOTP(otp))
            {
                FormResetMK3 f = new FormResetMK3();
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
