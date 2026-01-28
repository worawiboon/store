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
    public partial class getEm : Form
    {
        public getEm()
        {
            InitializeComponent();
        }

        private void back_getEm_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Close();
        }

        private void getEm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NorthwindContext())
                {
                    
                    var employees = context.Employees.Select(emp => new
                    {
                        รหัสพนักงาน = emp.EmployeeId,
                        ชื่อ = emp.FirstName, 
                        นามสกุล = emp.LastName,
                        ตำแหน่ง = emp.Title,
                        เบอร์โทร = emp.HomePhone,
                        วันเกิด = emp.BirthDate
                    }).ToList();

                    dataGridView1.DataSource = employees;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }
    }
    
}
