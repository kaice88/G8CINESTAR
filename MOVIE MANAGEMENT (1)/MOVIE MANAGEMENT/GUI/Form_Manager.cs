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
    public partial class Form_Manager : Form
    {
        public delegate string Mydel1();
        public Mydel1 d1 { get; set; }
        public Form_Manager()
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
            Hide();
        }

        private void btroom_CheckedChanged(object sender, EventArgs e)
        {
            UC_Room uc = new UC_Room();
            AddUC(uc);
        }

        
        private void btschedule_CheckedChanged(object sender, EventArgs e)
        {
            UC_Schedule uc = new UC_Schedule();
            AddUC(uc);
        }
       

        private void btcustomer_CheckedChanged(object sender, EventArgs e)
        {
            UC_Customer uc = new UC_Customer();
            AddUC(uc);
        }

        
        private void btreceipt_Click(object sender, EventArgs e)
        {
            UC_Receipt uc = new UC_Receipt();
            uc.d1 = new UC_Receipt.Mydel1(d1);
            AddUC(uc);
        }

        private void btstatistic_CheckedChanged(object sender, EventArgs e)
        {
            UC_Statistic uc = new UC_Statistic();
            AddUC(uc);
        }
    }
}
