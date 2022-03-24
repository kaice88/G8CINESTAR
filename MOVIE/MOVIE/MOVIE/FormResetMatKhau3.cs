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
    public partial class FormResetMatKhau3 : Form
    {
        public FormResetMatKhau3()
        {
            InitializeComponent();
        }
        private void buttonreset_Click(object sender, EventArgs e)
        {
            //update vao csdl
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap1 formDangNhap1 = new FormDangNhap1();
            formDangNhap1.Show();
            Hide();
        }
    }
}
