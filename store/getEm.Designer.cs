namespace store
{
    partial class getEm
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
            label1 = new Label();
            back_getEm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(624, 294);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 45);
            label1.TabIndex = 1;
            label1.Text = "Employees";
            // 
            // back_getEm
            // 
            back_getEm.Location = new Point(580, 386);
            back_getEm.Name = "back_getEm";
            back_getEm.Size = new Size(90, 52);
            back_getEm.TabIndex = 2;
            back_getEm.Text = "Back";
            back_getEm.UseVisualStyleBackColor = true;
            back_getEm.Click += back_getEm_Click;
            // 
            // getEm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_getEm);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "getEm";
            Text = "getEm";
            Load += getEm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button back_getEm;
    }
}