namespace FormUI
{
    partial class ProductCreatePopup
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
            lblName = new Label();
            lblStockAmount = new Label();
            lblUnitPrice = new Label();
            txtName = new TextBox();
            txtStockAmount = new TextBox();
            txtUnitPrice = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(117, 54);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ürün İsmi";
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(96, 153);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(92, 20);
            lblStockAmount.TabIndex = 1;
            lblStockAmount.Text = "Stok Milktarı";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(105, 102);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(83, 20);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Birim Fiyatı";
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(347, 27);
            txtName.TabIndex = 3;
            // 
            // txtStockAmount
            // 
            txtStockAmount.Location = new Point(194, 153);
            txtStockAmount.Name = "txtStockAmount";
            txtStockAmount.Size = new Size(347, 27);
            txtStockAmount.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(194, 102);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(347, 27);
            txtUnitPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(253, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ProductCreatePopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 337);
            Controls.Add(btnSave);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtStockAmount);
            Controls.Add(txtName);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblStockAmount);
            Controls.Add(lblName);
            Name = "ProductCreatePopup";
            Text = "ProductCreatePopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblStockAmount;
        private Label lblUnitPrice;
        private TextBox txtName;
        private TextBox txtStockAmount;
        private TextBox txtUnitPrice;
        private Button btnSave;
    }
}