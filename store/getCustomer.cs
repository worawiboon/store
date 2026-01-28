using store.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class getCustomer : Form
    {
        public getCustomer()
        {
            InitializeComponent();
        }

        private void getCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {

                    var customers = context.Database
                    .SqlQuery<CustomerViewModel>($"EXEC get_Customers")
                    .ToList();


                    dataGridView1.DataSource = customers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " + ex.Message);
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
