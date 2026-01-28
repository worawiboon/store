namespace store
{
    partial class UpdateShipping
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
            lblOrderId = new Label();
            txtShipName = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtPostalCode = new TextBox();
            label4 = new Label();
            txtCountry = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderId.Location = new Point(12, 9);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(98, 30);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Order ID:";
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(94, 67);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(180, 23);
            txtShipName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(94, 112);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(180, 64);
            txtAddress.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "ShipName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(94, 187);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "City";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(94, 224);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(100, 23);
            txtPostalCode.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 227);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "PostalCode";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(94, 261);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(100, 23);
            txtCountry.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 269);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(12, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(68, 46);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(710, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(78, 46);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // UpdateShipping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtCountry);
            Controls.Add(label4);
            Controls.Add(txtPostalCode);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtShipName);
            Controls.Add(lblOrderId);
            Name = "UpdateShipping";
            Text = "UpdateShipping";
            Load += UpdateShipping_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderId;
        private TextBox txtShipName;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtPostalCode;
        private Label label4;
        private TextBox txtCountry;
        private Label label5;
        private Button btnSave;
        private Button btnBack;
    }
}