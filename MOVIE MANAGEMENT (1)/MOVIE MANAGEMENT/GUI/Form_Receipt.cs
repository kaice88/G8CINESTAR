using Microsoft.Reporting.WinForms;
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
namespace GUI
{
    public partial class Form_Receipt : Form
    {
        public int receipt_id { get; set; }
        public Form_Receipt(int id)
        {
            InitializeComponent();
            receipt_id = id;
        }

        private void FormReceipt1_Load(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "GUI.ReportReceipt.rdlc";
            ReportDataSource data = new ReportDataSource();
            data.Name = "DataSet1";
            data.Value = SeatBookingBLL.Instance.Receipt(receipt_id);

            reportViewer2.LocalReport.DataSources.Add(data);
            this.reportViewer2.RefreshReport();
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            Form_Ticket f = new Form_Ticket(receipt_id);
            f.Show();
        }
    }
}
