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
    public partial class FormDangNhap1 : Form
    {
        public FormDangNhap1()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();  
        private void gunaCreate_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string query = "Select * from account2 Where username = '" + username + "'and pwd = '" + password + "'";
            if (modify.accounts(query).Count != 0)
            {
                MessageBox.Show("Đăng nhập thành công! ");
            }
            else
            {
                FormDangNhap2 f2 = new FormDangNhap2();
                f2.Show();
            }
        }
    }
}
