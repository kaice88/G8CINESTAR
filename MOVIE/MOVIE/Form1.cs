using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace MOVIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunacreate_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=DESKTOP-LAPTOP\SQLEXPRESS;Initial Catalog=RAPPHIM_QL;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(strConn);
            try
            {
                sqlConn.Open();
                string sqlTextCommand = "INSERT INTO account ( fullname, username,pwd, phone_number,email,role) " +
                    "VALUES ('" + gunaTextBox1.Text + "','" + gunaTextBox2.Text + "','" + gunaTextBox5.Text + "','" + gunaTextBox3.Text + "','" + gunaTextBox4.Text + "');";
                SqlCommand sqlCommand = new SqlCommand(sqlTextCommand, sqlConn);
                SqlDataReader dtReader = sqlCommand.ExecuteReader();
            }
            catch
            {

            }
        }
    }
}
