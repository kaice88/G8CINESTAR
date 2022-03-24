using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVIE
{
    public partial class FormResetMatKhau4 : Form
    {
        public delegate void MyDel(string code);
        public MyDel d;
        string otp;
        public FormResetMatKhau4()
        {
            InitializeComponent();
        }
        private void GetCode(string code)
        {
            otp = code;
        }

        private void gunaChange_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == otp)
            {
                FormResetMatKhau3 f3 = new FormResetMatKhau3();
                f3.Show();
                Hide();
            }
            else
            {
                txtcode.Text = "";
            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormResetMatKhau1 f1 = new FormResetMatKhau1();
            f1.Show();
            Hide();
        }
    }
}
