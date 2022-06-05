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
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace GUI
{
    public partial class UC_Statistic : UserControl
    {
        public UC_Statistic()
        {
            InitializeComponent();
            lbtotalmovie1.Text = "0";
            lbtotalmovie2.Text = "0";
            lbcustomer1.Text = "0";
            lbcustomer2.Text = "0";
            lbemplyee1.Text = "0";
            lbemplyee2.Text = "0";
            pieChart1.LegendLocation = LegendLocation.Bottom;
            pieChart2.LegendLocation = LegendLocation.Bottom;
            pieChart3.LegendLocation = LegendLocation.Bottom;
        }

        public void SetCBB(ComboBox comboBox1, ComboBox comboBox2)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("1");
                comboBox2.Items.Add("2");
                comboBox2.Items.Add("3");
                comboBox2.Items.Add("4");
                comboBox2.Items.Add("5");
                comboBox2.Items.Add("6");
                comboBox2.Items.Add("7");
                comboBox2.Items.Add("8");
                comboBox2.Items.Add("9");
                comboBox2.Items.Add("10");
                comboBox2.Items.Add("11");
                comboBox2.Items.Add("12");
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("2020");
                comboBox2.Items.Add("2021");
                comboBox2.Items.Add("2022");
            }
        }
        
        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCBB(cbb1, cbb2);
        }
        private void cbb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCBB(cbb3, cbb4);
        }
        private void cbb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCBB(cbb5, cbb6);
        }
        private void cbb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = StatisticBLL.Instance.StatisticMovie(cbb1.SelectedItem.ToString(), cbb2.SelectedItem.ToString());
            dataGridView1.DataSource = table;
            LoadChart(table, pieChart1);
            if (table.Rows.Count > 0)
            {
                lbtotalmovie2.Text = StatisticBLL.Instance.Total(table).ToString();
                lbtotalmovie1.Text = table.Rows[0]["total"].ToString();
                lbname1.Text = table.Rows[0]["movie_name"].ToString();
            }
            else
            {
                lbtotalmovie2.Text = "0";
                lbtotalmovie1.Text = "0";
                lbname1.Text = "";
            }
        }
        private void cbb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = StatisticBLL.Instance.StatisticCustomer(cbb3.SelectedItem.ToString(), cbb4.SelectedItem.ToString());
            dataGridView2.DataSource = table;
            LoadChart(table, pieChart2);
            if (table.Rows.Count > 0)
            {
                lbcustomer2.Text = StatisticBLL.Instance.Total(table).ToString();
                lbcustomer1.Text = table.Rows[0]["total"].ToString();
                lbname3.Text = table.Rows[0]["customer_name"].ToString();
            }
            else
            {
                lbcustomer2.Text = "0";
                lbcustomer1.Text = "0";
                lbname3.Text = "";
            }
            
        }

        private void cbb6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = StatisticBLL.Instance.StatisticEmployee(cbb5.SelectedItem.ToString(), cbb6.SelectedItem.ToString());
            dataGridView3.DataSource = table;
            LoadChart(table, pieChart3);
            if (table.Rows.Count > 0)
            {
                lbemplyee2.Text = StatisticBLL.Instance.Total(table).ToString();
                lbemplyee1.Text = table.Rows[0]["total"].ToString();
                lbname2.Text = table.Rows[0]["fullname"].ToString();
            }
            else
            {
                lbemplyee2.Text = "0";
                lbemplyee1.Text = "0";
                lbname2.Text = "";
            }
        }

        public void LoadChart(DataTable table, LiveCharts.WinForms.PieChart piechart)
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection series = new SeriesCollection();
            if (table.Rows.Count > 3)
            {
                for (int i = 0; i < 3; i++)
                    series.Add(new PieSeries()
                    {
                        Title = table.Rows[i][0].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(table.Rows[i][2].ToString()) },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });
            }
            else
                foreach (DataRow r in table.Rows)
                    series.Add(new PieSeries()
                    {
                        Title = r[0].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(r[2].ToString()) },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });
            piechart.Series = series;
        }

        

        
    }
}
