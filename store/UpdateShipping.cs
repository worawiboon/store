using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using store.Models;
using Microsoft.EntityFrameworkCore;

namespace store
{
    public partial class UpdateShipping : Form
    {
        public int OrderId { get; set; }
        public UpdateShipping()
        {
            InitializeComponent();
        }

        private void UpdateShipping_Load(object sender, EventArgs e)
        {
            lblOrderId.Text = "แก้ไขที่อยู่จัดส่งสำหรับ Order #: " + OrderId;
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new NorthwindContext())
            {
                var order = context.Orders.Find(OrderId);
                if (order != null)
                {

                    txtShipName.Text = order.ShipName;
                    txtAddress.Text = order.ShipAddress;
                    txtCity.Text = order.ShipCity;
                    txtPostalCode.Text = order.ShipPostalCode;
                    txtCountry.Text = order.ShipCountry;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    var order = context.Orders.Find(OrderId);
                    if (order != null)
                    {
                        // อัปเดตข้อมูลลง DB
                        order.ShipName = txtShipName.Text;
                        order.ShipAddress = txtAddress.Text;
                        order.ShipCity = txtCity.Text;
                        order.ShipPostalCode = txtPostalCode.Text;
                        order.ShipCountry = txtCountry.Text;

                        context.SaveChanges();
                        MessageBox.Show("บันทึกข้อมูลจัดส่งเรียบร้อย!");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            getorder go = new getorder();
            go.Show();
            this.Close();
        }
    }
}