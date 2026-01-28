namespace store
{
    partial class newOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbCustomer = new ComboBox();
            label2 = new Label();
            cmbEmployee = new ComboBox();
            label3 = new Label();
            dtpOrderDate = new DateTimePicker();
            label4 = new Label();
            dtpRequiredDate = new DateTimePicker();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            btnAdd = new Button();
            numQuantity = new NumericUpDown();
            label7 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            cmbProduct = new ComboBox();
            label5 = new Label();
            dgvItems = new DataGridView();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(111, 43);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(121, 23);
            cmbCustomer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 2;
            label2.Text = "Employee";
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(111, 86);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(121, 23);
            cmbEmployee.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "วันที่สั่งซื้อ";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(111, 124);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 23);
            dtpOrderDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 6;
            label4.Text = "วันที่ต้องส่ง";
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(111, 161);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(200, 23);
            dtpRequiredDate.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(14, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 45);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(numQuantity);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbProduct);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(425, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 330);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการสินค้า";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 227);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(139, 30);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "ยอดรวมทั้งหมด:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(6, 276);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 48);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "เพิ่มลงตะกร้า";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantity.Location = new Point(148, 113);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 29);
            numQuantity.TabIndex = 5;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 121);
            label7.Name = "label7";
            label7.Size = new Size(129, 21);
            label7.TabIndex = 4;
            label7.Text = "จำนวน (Quantity):";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(168, 78);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(100, 29);
            txtPrice.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 81);
            label6.Name = "label6";
            label6.Size = new Size(142, 21);
            label6.TabIndex = 2;
            label6.Text = "ราคาต่อหน่วย (Price):";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(77, 42);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(191, 29);
            cmbProduct.TabIndex = 1;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 43);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 0;
            label5.Text = "สินค้า";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(15, 197);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(389, 172);
            dgvItems.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(684, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(72, 45);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // newOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvItems);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(dtpRequiredDate);
            Controls.Add(label4);
            Controls.Add(dtpOrderDate);
            Controls.Add(label3);
            Controls.Add(cmbEmployee);
            Controls.Add(label2);
            Controls.Add(cmbCustomer);
            Controls.Add(label1);
            Name = "newOrder";
            Text = "newOrder";
            Load += newOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCustomer;
        private Label label2;
        private ComboBox cmbEmployee;
        private Label label3;
        private DateTimePicker dtpOrderDate;
        private Label label4;
        private DateTimePicker dtpRequiredDate;
        private Button btnSave;
        private GroupBox groupBox1;
        private ComboBox cmbProduct;
        private Label label5;
        private NumericUpDown numQuantity;
        private Label label7;
        private TextBox txtPrice;
        private Label label6;
        private DataGridView dgvItems;
        private Button btnAdd;
        private Label lblTotal;
        private Button btnBack;
    }
}