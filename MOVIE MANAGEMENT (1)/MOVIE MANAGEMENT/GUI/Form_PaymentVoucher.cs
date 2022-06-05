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
    public partial class Form_PaymentVoucher : Form
    {
        public delegate string Mydel1();
        public Mydel1 d1 { get; set; }
        public int Receipt_Id { get; set; }
        public Form_PaymentVoucher(int receipt_id)
        {
            InitializeComponent();
            Receipt_Id = receipt_id;
        }

        private void Form_PaymentVoucher_Load(object sender, EventArgs e)
        {
            DataRow row = PaymentVoucherBLL.Instance.LoadPayment(Receipt_Id);
            lbPayment.Text =
                "                CINESTAR CINEMA\n" +
                "                PAYMENT VOUCHER\n" +
                "  Id: " + row["payment_id"].ToString().Trim() +
                "     Date: " + Convert.ToDateTime(row["date_payment"]).ToString("dd-MM-yyyy").Trim() +
                "\n\n  Staff:          " + row["fullname"].ToString().Trim() +
                "\n  Customer:  " + row["customer_name"].ToString().Trim() +
                "\n  Number of ticket: " + row["amount"].ToString().Trim() +
                "\n  Sub total: " + Convert.ToInt32(row["payment_price"].ToString().Trim()) * 100 / 90 +
                "\n  Cancellation charges: " + Convert.ToInt32(row["payment_price"].ToString().Trim()) / 9 +
                "\n  Total: " + row["payment_price"].ToString().Trim() +
                "\n\n         Thank you and see you again";

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lbPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Receipt", 305, 215);
            if (DialogResult.OK == printPreviewDialog1.ShowDialog())
            {
                printDocument1.Print();
            }
        }
    }
}
