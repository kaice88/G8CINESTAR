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
    public partial class Form_Home : Form
    {
        public delegate void SendMessage();
        public SendMessage Sender; 
        private bool isCollapsed;
        public string username { get; set; }
        public Form_Home(string us)
        {
            InitializeComponent();
            Sender = new SendMessage(HideManagement);
            username = us;
            btaccountname.Text = us;
        }

        private void FormFunction_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btaccountname_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            this.Hide();
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

           Form_ChangePassword f = new Form_ChangePassword(username);
            this.Hide();
            f.Show();
        }
        public void HideManagement()
        {
            btmanage.Hide();
        }
        public string TransferUsername()
        {
            return btaccountname.Text;
        }

        private void btmanage_Click(object sender, EventArgs e)
        {
            Form_Manager f = new Form_Manager();
            f.d1 = new Form_Manager.Mydel1(TransferUsername);
            f.Show();
        }

        private void btbooking_Click(object sender, EventArgs e)
        {
            Form_Booking f = new Form_Booking(TransferUsername());
            f.Show();
        }

        
    }
}
