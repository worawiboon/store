namespace store
{
    partial class OrderReport
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
            lblCustomerInfo = new Label();
            lblShipInfo = new Label();
            lblOrderInfo = new Label();
            dgvItems = new DataGridView();
            lblTotal = new Label();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "ใบสั่งซื้อ / INVOICE";
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.AutoSize = true;
            lblCustomerInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerInfo.Location = new Point(12, 68);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(215, 21);
            lblCustomerInfo.TabIndex = 1;
            lblCustomerInfo.Text = "ข้อมูลลูกค้า (Customer Info)";
            // 
            // lblShipInfo
            // 
            lblShipInfo.AutoSize = true;
            lblShipInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShipInfo.Location = new Point(482, 68);
            lblShipInfo.Name = "lblShipInfo";
            lblShipInfo.Size = new Size(208, 21);
            lblShipInfo.TabIndex = 2;
            lblShipInfo.Text = "ข้อมูลจัดส่ง (Shipping Info)";
            // 
            // lblOrderInfo
            // 
            lblOrderInfo.AutoSize = true;
            lblOrderInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderInfo.Location = new Point(12, 127);
            lblOrderInfo.Name = "lblOrderInfo";
            lblOrderInfo.Size = new Size(93, 21);
            lblOrderInfo.TabIndex = 3;
            lblOrderInfo.Text = "Order Date";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(13, 177);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(402, 163);
            dgvItems.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(13, 379);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(72, 30);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label2";
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(732, 15);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(56, 26);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // OrderReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(lblTotal);
            Controls.Add(dgvItems);
            Controls.Add(lblOrderInfo);
            Controls.Add(lblShipInfo);
            Controls.Add(lblCustomerInfo);
            Controls.Add(label1);
            Name = "OrderReport";
            Text = "OrderReport";
            Load += OrderReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCustomerInfo;
        private Label lblShipInfo;
        private Label lblOrderInfo;
        private DataGridView dgvItems;
        private Label lblTotal;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}