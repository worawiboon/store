namespace store
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            getOrderToolStripMenuItem = new ToolStripMenuItem();
            getOrderToolStripMenuItem1 = new ToolStripMenuItem();
            newOrderToolStripMenuItem = new ToolStripMenuItem();
            EmployeeToolStripMenuItem = new ToolStripMenuItem();
            getEmployeeToolStripMenuItem1 = new ToolStripMenuItem();
            getProductToolStripMenuItem = new ToolStripMenuItem();
            getProductToolStripMenuItem1 = new ToolStripMenuItem();
            storeProcedureToolStripMenuItem = new ToolStripMenuItem();
            custOrdersOrdersToolStripMenuItem = new ToolStripMenuItem();
            salesByYearToolStripMenuItem = new ToolStripMenuItem();
            getCustomerToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getOrderToolStripMenuItem, EmployeeToolStripMenuItem, getProductToolStripMenuItem, storeProcedureToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(57, 20);
            systemToolStripMenuItem.Text = "System";
            // 
            // getOrderToolStripMenuItem
            // 
            getOrderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getOrderToolStripMenuItem1, newOrderToolStripMenuItem });
            getOrderToolStripMenuItem.Name = "getOrderToolStripMenuItem";
            getOrderToolStripMenuItem.Size = new Size(180, 22);
            getOrderToolStripMenuItem.Text = "Order";
            // 
            // getOrderToolStripMenuItem1
            // 
            getOrderToolStripMenuItem1.Name = "getOrderToolStripMenuItem1";
            getOrderToolStripMenuItem1.Size = new Size(129, 22);
            getOrderToolStripMenuItem1.Text = "getOrder";
            getOrderToolStripMenuItem1.Click += getOrderToolStripMenuItem1_Click;
            // 
            // newOrderToolStripMenuItem
            // 
            newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            newOrderToolStripMenuItem.Size = new Size(129, 22);
            newOrderToolStripMenuItem.Text = "new Order";
            newOrderToolStripMenuItem.Click += newOrderToolStripMenuItem_Click;
            // 
            // EmployeeToolStripMenuItem
            // 
            EmployeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getEmployeeToolStripMenuItem1 });
            EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            EmployeeToolStripMenuItem.Size = new Size(180, 22);
            EmployeeToolStripMenuItem.Text = "Employee";
            // 
            // getEmployeeToolStripMenuItem1
            // 
            getEmployeeToolStripMenuItem1.Name = "getEmployeeToolStripMenuItem1";
            getEmployeeToolStripMenuItem1.Size = new Size(143, 22);
            getEmployeeToolStripMenuItem1.Text = "getEmployee";
            getEmployeeToolStripMenuItem1.Click += getEmployeeToolStripMenuItem1_Click;
            // 
            // getProductToolStripMenuItem
            // 
            getProductToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getProductToolStripMenuItem1 });
            getProductToolStripMenuItem.Name = "getProductToolStripMenuItem";
            getProductToolStripMenuItem.Size = new Size(180, 22);
            getProductToolStripMenuItem.Text = "Product";
            // 
            // getProductToolStripMenuItem1
            // 
            getProductToolStripMenuItem1.Name = "getProductToolStripMenuItem1";
            getProductToolStripMenuItem1.Size = new Size(133, 22);
            getProductToolStripMenuItem1.Text = "getProduct";
            getProductToolStripMenuItem1.Click += getProductToolStripMenuItem1_Click_1;
            // 
            // storeProcedureToolStripMenuItem
            // 
            storeProcedureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { custOrdersOrdersToolStripMenuItem, salesByYearToolStripMenuItem, getCustomerToolStripMenuItem });
            storeProcedureToolStripMenuItem.Name = "storeProcedureToolStripMenuItem";
            storeProcedureToolStripMenuItem.Size = new Size(180, 22);
            storeProcedureToolStripMenuItem.Text = "StoreProcedure";
            storeProcedureToolStripMenuItem.Click += storeProcedureToolStripMenuItem_Click;
            // 
            // custOrdersOrdersToolStripMenuItem
            // 
            custOrdersOrdersToolStripMenuItem.Name = "custOrdersOrdersToolStripMenuItem";
            custOrdersOrdersToolStripMenuItem.Size = new Size(180, 22);
            custOrdersOrdersToolStripMenuItem.Text = "CustOrdersOrders";
            custOrdersOrdersToolStripMenuItem.Click += storeProcedureToolStripMenuItem_Click;
            // 
            // salesByYearToolStripMenuItem
            // 
            salesByYearToolStripMenuItem.Name = "salesByYearToolStripMenuItem";
            salesByYearToolStripMenuItem.Size = new Size(180, 22);
            salesByYearToolStripMenuItem.Text = "SalesByYear";
            salesByYearToolStripMenuItem.Click += salesByYearToolStripMenuItem_Click;
            // 
            // getCustomerToolStripMenuItem
            // 
            getCustomerToolStripMenuItem.Name = "getCustomerToolStripMenuItem";
            getCustomerToolStripMenuItem.Size = new Size(180, 22);
            getCustomerToolStripMenuItem.Text = "getCustomer";
            getCustomerToolStripMenuItem.Click += getCustomerToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 528);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Main Dashboard";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem getOrderToolStripMenuItem;
        private ToolStripMenuItem EmployeeToolStripMenuItem;
        private ToolStripMenuItem getProductToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem storeProcedureToolStripMenuItem;
        private ToolStripMenuItem custOrdersOrdersToolStripMenuItem;
        private ToolStripMenuItem salesByYearToolStripMenuItem;
        private ToolStripMenuItem getCustomerToolStripMenuItem;
        private ToolStripMenuItem getOrderToolStripMenuItem1;
        private ToolStripMenuItem newOrderToolStripMenuItem;
        private ToolStripMenuItem getEmployeeToolStripMenuItem1;
        private ToolStripMenuItem getProductToolStripMenuItem1;
    }
}
