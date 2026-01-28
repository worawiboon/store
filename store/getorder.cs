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
namespace store
{
    public partial class getorder : Form
    {
        public getorder()
        {
            InitializeComponent();
        }

        private void getorder_Load(object sender, EventArgs e)
        {
            using (var context = new NorthwindContext())
            {

                var order = context.Orders.Select(o => new
                {
                    รหัสออเดอร์ = o.OrderId,
                    รหัสลูกค้า = o.CustomerId,
                    รหัสลูกจ้างที่รับผิดชอบ = o.EmployeeId,
                    ชื่อผู้รับ = o.ShipName,

                    ที่อยู่จัดส่ง = o.ShipAddress
                }).ToList();

                dataGridView1.DataSource = order;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }



        private void btnViewDetail_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["รหัสออเดอร์"].Value);
                var detailForm = new orderdetail(id);
                detailForm.Show();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกรายการออเดอร์ก่อนครับ");
            }
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;


            int selectedOrderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            UpdateShipping form = new UpdateShipping();
            form.OrderId = selectedOrderId;
            form.ShowDialog();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int selectedOrderId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            OrderReport form = new OrderReport();
            form.OrderId = selectedOrderId;
            form.Show();
        }
    }
}
