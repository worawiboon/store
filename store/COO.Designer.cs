namespace store
{
    partial class COO
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
            txtCustomerId = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "CustomerID";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(148, 31);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(157, 23);
            txtCustomerId.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(325, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "ค้นหา";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(189, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(456, 255);
            dataGridView1.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(570, 375);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 44);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // COO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtCustomerId);
            Controls.Add(label1);
            Name = "COO";
            Text = "COO";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerId;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnBack;
    }
}