using Microsoft.EntityFrameworkCore;
using store.Models;
using store.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace store
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            Chart chart1 = new Chart();
            chart1.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            Legend legend = new Legend("MainLegend");
            chart1.Legends.Add(legend);

            Series series = new Series("ยอดขาย");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            chart1.Series.Add(series);


            panel1.Controls.Add(chart1);
            chart1.SendToBack();

            try
            {
                using (var context = new NorthwindContext())
                {
                    var topProduct = context.OrderDetails.Include(od => od.Product)
                        .GroupBy(od => od.Product.ProductName)
                        .Select(g => new
                        {
                            ProductName = g.Key,
                            TotalSales = g.Sum(od => od.UnitPrice * od.Quantity)
                        })
                        .OrderByDescending(x => x.TotalSales)
                        .Take(5)
                        .ToList();
                    foreach (var item in topProduct)
                    {
                        series.Points.AddXY(item.ProductName, item.TotalSales);
                    }
                    Title title = new Title("5 อันดับสินค้าขายดี (Top 5 Best Sellers)");
                    title.Font = new Font("Arial", 16, FontStyle.Bold);
                    title.Docking = Docking.Top;
                    title.Alignment = ContentAlignment.BottomCenter;
                    title.IsDockedInsideChartArea = false;
                    chart1.Titles.Add(title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " + ex.Message);
            }
        }





        private void storeProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COO coo = new COO();
            coo.Show();
            this.Hide();
        }

        private void salesByYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesbyYear s = new SalesbyYear();
            s.Show();
            this.Hide();
        }

        private void getCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCustomer c = new getCustomer();
            c.Show();
            this.Hide();
        }

        private void getOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getorder go = new getorder();
            go.Show();
            this.Hide();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newOrder no = new newOrder();
            no.Show();
            this.Hide();
        }

        private void getEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var employee = new getEm();
            employee.Show();
            this.Hide();
        }

        

        private void getProductToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var get_product = new getproduct();
            get_product.Show();
            this.Hide();
        }
    }
}
