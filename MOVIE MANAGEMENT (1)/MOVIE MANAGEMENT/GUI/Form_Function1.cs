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
    public partial class Form_Function1 : Form
    {
        public delegate void MyDel(string s);
        public MyDel d;
        public Form_Function1()
        {
            InitializeComponent();
            d = new MyDel(GetUsername);
        }
        private void GetUsername(string s)
        {
            lbfullname.Text = s;
        }
        public string TransferUsername()
        {
            return lbfullname.Text;
        }
        private void btManagement_Click(object sender, EventArgs e)
        {
            Form_Manager f = new Form_Manager();
            f.d1 = new Form_Manager.Mydel1(TransferUsername);
            f.Show();
        }

        private void btBooking_Click(object sender, EventArgs e)
        {
            Form_Booking f = new Form_Booking(TransferUsername());
            f.Show();
        }

        private void gunaexit_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            Hide();
            f.Show();
        }
    }
}
