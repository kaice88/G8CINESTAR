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
    public partial class Form_QL_NV : Form
    {
        
        public Form_QL_NV()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e) // show csdl
        {
            string query = "SELECT id_number,fullname,username,email,phone_number,role FROM TBStaff";
            dt = modify.QLNV(query).Tables[0];
            dataGridView1.DataSource = dt;
           
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string query = "Select * from TBStaff where username = '" + txtSearch.Text+"' or fullname = '" + txtSearch.Text
                +"' or phone_number = '" + txtSearch.Text+"' or email = '" + txtSearch.Text+"';";
            dt = modify.QLNV(query).Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
