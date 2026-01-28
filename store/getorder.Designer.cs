namespace store
{
    partial class getorder
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
            order = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            btnViewDetail_Click = new Button();
            btnUpdateShip = new Button();
            btnShowReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // order
            // 
            order.AutoSize = true;
            order.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order.Location = new Point(12, 9);
            order.Name = "order";
            order.Size = new Size(122, 45);
            order.TabIndex = 0;
            order.Text = "Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 276);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(601, 392);
            button2.Name = "button2";
            button2.Size = new Size(92, 46);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnViewDetail_Click
            // 
            btnViewDetail_Click.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetail_Click.Location = new Point(71, 392);
            btnViewDetail_Click.Name = "btnViewDetail_Click";
            btnViewDetail_Click.Size = new Size(101, 46);
            btnViewDetail_Click.TabIndex = 4;
            btnViewDetail_Click.Text = "OrderDetail";
            btnViewDetail_Click.UseVisualStyleBackColor = true;
            btnViewDetail_Click.Click += btnViewDetail_Click_Click;
            // 
            // btnUpdateShip
            // 
            btnUpdateShip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateShip.Location = new Point(178, 393);
            btnUpdateShip.Name = "btnUpdateShip";
            btnUpdateShip.Size = new Size(98, 45);
            btnUpdateShip.TabIndex = 5;
            btnUpdateShip.Text = "ระบุที่อยู่จัดส่ง";
            btnUpdateShip.UseVisualStyleBackColor = true;
            btnUpdateShip.Click += btnUpdateShip_Click;
            // 
            // btnShowReport
            // 
            btnShowReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowReport.Location = new Point(282, 393);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(83, 45);
            btnShowReport.TabIndex = 6;
            btnShowReport.Text = "ดูรายงาน";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // getorder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(btnShowReport);
            Controls.Add(btnUpdateShip);
            Controls.Add(btnViewDetail_Click);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(order);
            Name = "getorder";
            Text = "getorder";
            Load += getorder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label order;
        private DataGridView dataGridView1;
        private Button button2;
        private Button btnViewDetail_Click;
        private Button btnUpdateShip;
        private Button btnShowReport;
    }
}