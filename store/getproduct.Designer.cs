namespace store
{
    partial class getproduct
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
            dataGridView1 = new DataGridView();
            gpd_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(665, 276);
            dataGridView1.TabIndex = 0;
            // 
            // gpd_back
            // 
            gpd_back.Location = new Point(638, 360);
            gpd_back.Name = "gpd_back";
            gpd_back.Size = new Size(97, 47);
            gpd_back.TabIndex = 1;
            gpd_back.Text = "Back";
            gpd_back.UseVisualStyleBackColor = true;
            gpd_back.Click += gpd_back_Click;
            // 
            // getproduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gpd_back);
            Controls.Add(dataGridView1);
            Name = "getproduct";
            Text = "getproduct";
            Load += getproduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button gpd_back;
    }
}