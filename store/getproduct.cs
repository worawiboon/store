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

namespace store
{
    public partial class getproduct : Form
    {
        public getproduct()
        {
            InitializeComponent();
        }

        private void getproduct_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindContext())
            {
                var product = context.Products.Select(p => new
                {
                    รหัสผลิตภัณฑ์ = p.ProductId,
                    ชื่อผลิตภัณฑ์ = p.ProductName,
                    ประเภท = p.Category.CategoryName,
                    ชื่อผู้ผลิต = p.Supplier.CompanyName,
                    ราคาต่อชิ้น = p.UnitPrice.ToString(),
                    จำนวนที่เหลือ = p.UnitsInStock.ToString(),
                }).ToList();
                dataGridView1.DataSource = product;
            }

        }

        private void gpd_back_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
