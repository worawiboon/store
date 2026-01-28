namespace store
{
    partial class SalesbyYear
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
            label2 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnShowGraph = new Button();
            panel = new Panel();
            btnback = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "วันที่เริ่มนับ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 27);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 1;
            label2.Text = "วันที่หยุดนับ";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(20, 71);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(311, 71);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 3;
            // 
            // btnShowGraph
            // 
            btnShowGraph.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowGraph.Location = new Point(560, 71);
            btnShowGraph.Name = "btnShowGraph";
            btnShowGraph.Size = new Size(83, 23);
            btnShowGraph.TabIndex = 4;
            btnShowGraph.Text = "ShowGraph";
            btnShowGraph.UseVisualStyleBackColor = true;
            btnShowGraph.Click += btnShowGraph_Click;
            // 
            // panel
            // 
            panel.Location = new Point(20, 100);
            panel.Name = "panel";
            panel.Size = new Size(757, 530);
            panel.TabIndex = 5;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.Location = new Point(672, 71);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 23);
            btnback.TabIndex = 6;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // SalesbyYear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 642);
            Controls.Add(btnback);
            Controls.Add(panel);
            Controls.Add(btnShowGraph);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SalesbyYear";
            Text = "SalesbyYear";
            Load += SalesbyYear_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnShowGraph;
        private Panel panel;
        private Button btnback;
    }
}