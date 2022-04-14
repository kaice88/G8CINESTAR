using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_QL : Form
    {
        public Form_QL()
        {
            InitializeComponent();
        }
        public void AddUC(UserControl uc)
        {
            paneltrans.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            paneltrans.Controls.Add(uc);

        }
        private void Form_QL_NV_Load(object sender, EventArgs e)
        {
            paneltrans.FillColor = Color.FromArgb(25, 0, 0, 0);
            UC_Movie uc = new UC_Movie();
            AddUC(uc);
        }
        private void btstaff_CheckedChanged(object sender, EventArgs e)
        {

            UC_Staff uc = new UC_Staff();
            AddUC(uc);

        }

        private void btmovie_CheckedChanged(object sender, EventArgs e)
        {
            UC_Movie uc = new UC_Movie();
            AddUC(uc);
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            Hide();
            f.Show();
        }
    }
}
