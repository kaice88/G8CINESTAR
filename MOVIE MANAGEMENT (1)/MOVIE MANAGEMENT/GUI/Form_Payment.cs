using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class Form_Payment : Form
    {
        public int receipt_id { get; set; }
        public Form_Payment(int id)
        {
            InitializeComponent();
            receipt_id = id;
        }

        private void Form_Payment_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
