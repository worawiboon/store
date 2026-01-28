using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using store.Models;

namespace store
{
    public partial class orderdetail : Form
    {
        private int _orderId;
        public orderdetail(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void orderdetail_Load(object sender, EventArgs e)
        {
            lblOrderId.Text = "Order: " + _orderId;
            using (var context = new NorthwindContext())
            {
                var items = context.OrderDetails.Where(od => od.OrderId == _orderId).Include(od => od.Product).Select(od =>new
                {
                    ชื่อสินค้า = od.Product.ProductName,
                    ราคาต่อชิ้น = od.UnitPrice,
                    จำนวน = od.Quantity,
                    ราคารวม = od.Quantity * od.UnitPrice,
                }).ToList();

                dataGridView1.DataSource = items;
            }
            this.Text = $"รายละเอียดออเดอร์หมายเลข: {_orderId}";
        }
    }
}
