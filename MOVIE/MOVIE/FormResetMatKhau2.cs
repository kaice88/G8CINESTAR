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
    public partial class FormResetMatKhau2 : Form
    {
        public delegate void MyDel(string code, string email);
        public MyDel d;
        string otp, email;

        public FormResetMatKhau2()
        {
            InitializeComponent();
            d = new MyDel(GetCode);
        }
        private void GetCode(string code, string xemail)
        {
            otp = code;
            email = xemail;
        }
        private void gunaChange_Click(object sender, EventArgs e)
        {
            if(txtcode.Text == otp)
            {
                FormResetMatKhau3 f3 = new FormResetMatKhau3();
                f3.Show();
                f3.d(otp, email);
                Hide();
            }
            else
            {
                labelfail.Text = "The security code is incorrect. Try again.";
                txtcode.Text = "";
                return;
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
