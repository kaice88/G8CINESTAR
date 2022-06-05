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
    public partial class Form_Ticket : Form
    {
        public int receipt_id { get; set; }
        public Form_Ticket(int id)
        {
            InitializeComponent();
            receipt_id = id;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportTicket.rdlc";
            ReportDataSource data = new ReportDataSource();
            data.Name = "DataSet1";
            data.Value = SeatBookingBLL.Instance.Receipt(receipt_id);
            reportViewer1.LocalReport.DataSources.Add(data);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
