using Microsoft.EntityFrameworkCore;
using store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Windows.Forms.DataVisualization.Charting; // อย่าลืมตัวนี้


namespace store
{
    public partial class SalesbyYear : Form
    {

        public SalesbyYear()
        {
            InitializeComponent();
        }
        private Chart chart1;

        private void SalesbyYear_Load(object sender, EventArgs e)
        {
            dtpStart.Value = new DateTime(1996, 1, 1);
            dtpEnd.Value = new DateTime(1998, 12, 31);

            // สร้าง Chart
            chart1 = new Chart();
            chart1.Dock = DockStyle.Fill;

            // สร้างพื้นที่กราฟ
            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            // สร้าง Legend
            Legend legend = new Legend("MainLegend");
            chart1.Legends.Add(legend);

            // สร้าง Series 
            Series series = new Series("ยอดขาย");
            series.ChartType = SeriesChartType.Line; // หรือเปลี่ยนเป็น Line ก็สวย
            series.IsValueShownAsLabel = true;
            chart1.Series.Add(series);

            if (panel != null)
            {
                panel.Controls.Add(chart1);
            }
            else
            {

                this.Controls.Add(chart1);
                chart1.Padding = new Padding(0, 50, 0, 0); // ดันลงมาหน่อยกันทับ
            }
        }
        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            string startDate = dtpStart.Value.ToString("yyyy-MM-dd");
            string endDate = dtpEnd.Value.ToString("yyyy-MM-dd");

            try
            {
                using (var context = new NorthwindContext())
                {
                    var rawData = context.Database
                        .SqlQuery<SalesByYearResult>($"EXEC [Sales by Year] @Beginning_Date={startDate}, @Ending_Date={endDate}")
                        .ToList();

                    if (rawData.Count == 0)
                    {
                        MessageBox.Show("ไม่พบข้อมูลในช่วงวันที่เลือก");
                        return;
                    }


                    var chartData = rawData
                        .GroupBy(r => r.Year)
                        .Select(g => new
                        {
                            Year = g.Key,
                            TotalSales = g.Sum(r => r.Subtotal ?? 0)
                        })
                        .OrderBy(x => x.Year)
                        .ToList();

                    chart1.Series[0].Points.Clear();
                    chart1.Titles.Clear();
                    var title = new Title($"ยอดขายรายปี ({startDate} ถึง {endDate})");
                    title.Font = new Font("Tahoma", 14, FontStyle.Bold);
                    chart1.Titles.Add(title);

                    foreach (var item in chartData)
                    {
                        chart1.Series[0].Points.AddXY(item.Year, item.TotalSales);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }

}
