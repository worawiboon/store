using Microsoft.EntityFrameworkCore;
using store.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace store
{
    public partial class OrderReport : Form
    {
        Bitmap memoryImage;
        public int OrderId { get; set; }
        public OrderReport()
        {
            InitializeComponent();
        }



        



        private void OrderReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            using (var context = new NorthwindContext())
            {

                var order = context.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.Employee)
                    .Include(o => o.OrderDetails)
                        .ThenInclude(od => od.Product)
                    .FirstOrDefault(o => o.OrderId == OrderId);

                if (order == null) return;



                string customerInfo = $"ผู้สั่งซื้อ (Bill To):\n{order.Customer?.CompanyName}\n{order.Customer?.Address}\n{order.Customer?.Phone}";
                string shipInfo = $"จัดส่งที่ (Ship To):\n{order.ShipName}\n{order.ShipAddress}\n{order.ShipCity} {order.ShipPostalCode}\n{order.ShipCountry}";
                string orderInfo = $"เลขที่: {order.OrderId}\nวันที่: {order.OrderDate:dd/MM/yyyy}\nพนักงาน: {order.Employee?.FirstName}";


                lblCustomerInfo.Text = customerInfo;
                lblShipInfo.Text = shipInfo;
                lblOrderInfo.Text = orderInfo;


                var items = order.OrderDetails.Select(d => new
                {
                    สินค้า = d.Product.ProductName,
                    ราคา = d.UnitPrice,
                    จำนวน = d.Quantity,
                    ส่วนลด = d.Discount,
                    รวม = (d.UnitPrice * d.Quantity) * (1 - (decimal)d.Discount)
                }).ToList();

                dgvItems.DataSource = items;


                decimal total = items.Sum(x => x.รวม);
                lblTotal.Text = $"ยอดรวมทั้งสิ้น: {total:N2} บาท";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // เตรียมกระดาษแนวตั้ง (ถ้าอยากได้แนวนอนให้แก้เป็น true)
            printDocument1.DefaultPageSettings.Landscape = false;

            // จับภาพหน้าจอ Form นี้
            CaptureScreen();

            // สั่งพิมพ์ (จะเด้งหน้าต่างเลือกเครื่องพิมพ์ของ Windows)
            printDocument1.Print();
        }private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size; // ขนาดของภาพเท่ากับขนาด Form
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            // คัดลอกภาพจากหน้าจอลงตัวแปร memoryImage
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // วาดรูปลงกระดาษที่ตำแหน่ง (0,0)
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
