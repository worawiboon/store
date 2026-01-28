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
    public partial class COO : Form
    {
        public COO()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cusId = txtCustomerId.Text.Trim();
            if(string.IsNullOrEmpty(cusId) ) {
                MessageBox.Show("กรุณากรอกรหัสลูกค้า เช่น ALFKI");
                return;
        }

            try
            {
                using (var context = new NorthwindContext())
                {
                    var result = context.Database
                         .SqlQuery<CustOrdersOrdersResult>($"EXEC CustOrdersOrders @CustomerID = {cusId}")
                         .ToList();

                    dataGridView1.DataSource = result;
                    if (result.Count == 0)
                    {
                        MessageBox.Show("ไม่พยข้อมูลออร์เดอร์ของลูกค่ารายนี้");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + ex.Message);
            }
            }
    }
}
