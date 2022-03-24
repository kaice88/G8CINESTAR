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
        Modify modify = new Modify();

        private void gunacreate_Click(object sender, EventArgs e)
        {
                string fullname = txtfullname.Text;
                string username = txtusername.Text;
                string phone_number = txtphonenumber.Text;
                string email = txtemail.Text;
                string password = txtpassword.Text;
            //if (modify.accounts("Select from * where email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký, vui lòng đăng kí email khác!"); return; }
           
                string query = "Insert into account2(fullname, username, pwd, phone_number, email ) values('"+fullname+ "','" +username+ "','" +password + "','"+phone_number+"','" +email+"')";
                modify.Command(query);
              
        }

        }
    }
