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
using System.Globalization;
namespace store
{
    public partial class newOrder : Form
    {
        List<OrderDetail> cart = new List<OrderDetail>();
        public newOrder()
        {
            InitializeComponent();
        }

        private void newOrder_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    // --- โหลดลูกค้า (Customer) ---
                    var customers = context.Customers
                        .Select(c => new
                        {
                            Text = c.CompanyName + " (" + c.CustomerId + ")", // สิ่งที่จะโชว์
                            Value = c.CustomerId // ค่าจริงที่จะเอาไปใช้ (ID)
                        })
                        .OrderBy(c => c.Text)
                        .ToList();

                    cmbCustomer.DataSource = customers;
                    cmbCustomer.DisplayMember = "Text";  // โชว์ชื่อ
                    cmbCustomer.ValueMember = "Value";   // ซ่อนรหัสไว้ข้างหลัง

                    // --- โหลดพนักงาน (Employee) ---
                    var employees = context.Employees
                        .Select(e => new
                        {
                            Text = e.FirstName + " " + e.LastName,
                            Value = e.EmployeeId
                        })
                        .ToList();

                    cmbEmployee.DataSource = employees;
                    cmbEmployee.DisplayMember = "Text";
                    cmbEmployee.ValueMember = "Value";

                    //สินค้า
                    cmbProduct.DataSource = context.Products
                        .Select(p => new { Text = p.ProductName, Value = p.ProductId, Price = p.UnitPrice })
                        .OrderBy(p => p.Text).ToList();
                    cmbProduct.DisplayMember = "Text";
                    cmbProduct.ValueMember = "Value";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Data: " + ex.Message);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem != null)
            {
                // ดึงค่า Price ที่เราแอบ Select มาด้วย (ผ่าน dynamic properties)
                dynamic selectedItem = cmbProduct.SelectedItem;
                decimal price = selectedItem.Price ?? 0; // ถ้า null ให้เป็น 0
                txtPrice.Text = price.ToString("N2");    // โชว์ทศนิยม 2 ตำแหน่ง
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกสินค้าอย่างน้อย 1 รายการ");
                return;
            }

            try
            {
                using (var context = new NorthwindContext())
                {
                    // 1. สร้างหัวบิล 
                    var newOrder = new Order
                    {
                        CustomerId = cmbCustomer.SelectedValue.ToString(),
                        EmployeeId = (int)cmbEmployee.SelectedValue,
                        OrderDate = dtpOrderDate.Value,
                        RequiredDate = dtpRequiredDate.Value,
                        Freight = 0,
                        ShipName = "New Order"
                    };

                    // 2. เอาสินค้าในตะกร้า ยัดใส่เข้าไปใน Order

                    foreach (var item in cart)
                    {
                        newOrder.OrderDetails.Add(item);

                        var product = context.Products.Find(item.ProductId);
                        if (product != null)
                        {
                            // เช็คว่าของพอขายไหม?
                            if (product.UnitsInStock < item.Quantity)
                            {
                                MessageBox.Show($"สินค้า '{product.ProductName}' มีของไม่พอ! (เหลือ {product.UnitsInStock})");
                                return; // ยกเลิกการบันทึกทั้งหมดทันที
                            }

                            // ตัดของออก
                            product.UnitsInStock = (short)(product.UnitsInStock - item.Quantity);
                        }
                    }

                    // 3. สั่ง Save 
                    context.Orders.Add(newOrder);
                    context.SaveChanges();

                    MessageBox.Show($"บันทึกเรียบร้อย! Order ID: {newOrder.OrderId}");
                    this.Close();
                    Form1 form = new Form1();
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Save: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null) return;

            int productId = (int)cmbProduct.SelectedValue;
            string productName = cmbProduct.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            short qty = (short)numQuantity.Value;

            // เช็คว่ามีสินค้านี้ในตะกร้าหรือยัง?
            var existingItem = cart.FirstOrDefault(x => x.ProductId == productId);

            if (existingItem != null)
            {
                // ถ้ามีแล้ว ให้บวกจำนวนเพิ่ม
                existingItem.Quantity += qty;
            }
            else
            {
                // ถ้ายังไม่มี ให้สร้างใหม่
                var item = new OrderDetail
                {
                    ProductId = productId,
                    UnitPrice = price,
                    Quantity = qty,
                    Discount = 0,
                    // แอบฝากชื่อสินค้าไว้ในตัวแปรที่ไม่ใช้ (หรือจะสร้าง Class แยกก็ได้ แต่นี่ทางลัด)
                    // หมายเหตุ: EF Core จะไม่บันทึก Property ที่ไม่อยู่ใน DB แต่เพื่อความง่ายในการโชว์ตาราง
                };
                cart.Add(item);
            }
            // รีเฟรชตาราง
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            // แปลงข้อมูลใน cart ให้อยู่ในรูปที่ DataGridView เข้าใจง่ายๆ
            var displayList = cart.Select(x => new
            {
                รหัสสินค้า = x.ProductId,
                ชื่อสินค้า = cmbProduct.Items.Cast<dynamic>().FirstOrDefault(p => p.Value == x.ProductId)?.Text,
                ราคา = x.UnitPrice,
                จำนวน = x.Quantity,
                รวม = x.UnitPrice * x.Quantity
            }).ToList();

            dgvItems.DataSource = displayList;

            // คำนวณยอดรวมท้ายบิล
            decimal grandTotal = cart.Sum(x => x.UnitPrice * x.Quantity);


            if (lblTotal != null)
            {
                lblTotal.Text = $"ยอดรวมทั้งหมด: {grandTotal:N2} บาท";


                lblTotal.ForeColor = Color.Black;
                lblTotal.Font = new Font("Tahoma", 12, FontStyle.Bold);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
