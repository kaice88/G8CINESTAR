using EmailValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        QLNV qlnv = new QLNV();
        DataTable dt = new DataTable();
        

        private void butSearch_Click(object sender, EventArgs e)
        {
            string query = "Select  id_number,fullname,username,email,phone_number,role from TBStaff where username = '" + txtSearch.Text+"' or fullname = '" + txtSearch.Text
                +"' or phone_number = '" + txtSearch.Text+"' or email = '" + txtSearch.Text+"';";
           
            dt = qlnv.DTNV(query);
            dataGridView1.DataSource = dt;
        }

        private void Form_QL_NV_Load(object sender, EventArgs e)
        {

        }

       

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fullname = txtfullname.Text ;
            string username = txtusername.Text;
            string phone_number = txtphonenumber.Text;
            string email = txtemail.Text;
            string pwd = txtusername.Text;
            bool role;
            if (radioButton1.Checked == true) role = true;
            else role = false;
            if (fullname == "") { MessageBox.Show("DD FULLNAME SAI"); return; }
            if (!qlnv.CheckAccount(username)) { MessageBox.Show("DD USERNAME SAI"); return; } // form1
            if (!qlnv.CheckPhoneNumber(phone_number)) { MessageBox.Show("DD Phone SAI"); return; }
            if (!qlnv.CheckEmail(email)) { MessageBox.Show("DD EMAIL SAI"); return; }//form2
           

            // kiểm tra có trùng không
            //if (modify.accounts("Select * from TBStaff where email = '" + email + "'").Count != 0) { formfail("Invalid Email! Email address is already registered!", 74, 105, 140, 161); return; }//form4 
            //if (modify.accounts("Select * from TBStaff where username = '" + username + "'").Count != 0) { formfail("Invalid Username! Username is already being used!", 74, 105, 140, 161); return; }//form6 

            if (qlnv.DTNV("Select id_number,fullname,username,email,phone_number,role from TBStaff where email = '" + email + "'").Rows.Count != 0)
            {

                MessageBox.Show("EMAIL TRUNG "); return;
            }
            if (qlnv.DTNV("Select id_number,fullname,username,email,phone_number,role from TBStaff where username = '" + username + "'").Rows.Count != 0)
            {
                MessageBox.Show("username TRUNG "); return;
            }
            bool check = qlnv.CheckEmailExist(email);
            if (check)
            {

                string query1 = "Insert into TBStaff(fullname, username, pwd, phone_number, email,role ) values('" + fullname + "','" + username + "','" + pwd + "','" + phone_number + "','" + email + "','"+role+"')";
                qlnv.Add(query1);
                string query2 = "SELECT id_number,fullname,username,email,phone_number,role FROM TBStaff";
                dt = qlnv.DTNV(query2);  
                dataGridView1.DataSource = dt;

            }
            else
            {
                MessageBox.Show("email kh ton tai "); return;
            }
        }

        private void guna2Button4_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT id_number,fullname,username,email,phone_number,role FROM TBStaff";
            dt = qlnv.DTNV(query);
            dataGridView1.DataSource = dt;
        }
    }
    }

