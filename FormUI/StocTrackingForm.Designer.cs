namespace FormUI
{
    partial class StocTrackingForm
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
            lswProductList = new ListView();
            btnCurrentDelete = new Button();
            btnCurrentUpdate = new Button();
            btnImportCurrent = new Button();
            btnCreateCurrent = new Button();
            SuspendLayout();
            // 
            // lswProductList
            // 
            lswProductList.CheckBoxes = true;
            lswProductList.Font = new Font("Segoe UI", 11F);
            lswProductList.FullRowSelect = true;
            lswProductList.Location = new Point(165, 46);
            lswProductList.Name = "lswProductList";
            lswProductList.Size = new Size(1251, 370);
            lswProductList.TabIndex = 0;
            lswProductList.UseCompatibleStateImageBehavior = false;
            lswProductList.View = View.Details;
            // 
            // btnCurrentDelete
            // 
            btnCurrentDelete.BackColor = SystemColors.ButtonHighlight;
            btnCurrentDelete.FlatAppearance.BorderSize = 0;
            btnCurrentDelete.FlatStyle = FlatStyle.Flat;
            btnCurrentDelete.Image = Properties.Resources._1564502_basket_delete_remove_icon;
            btnCurrentDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnCurrentDelete.Location = new Point(576, 570);
            btnCurrentDelete.Name = "btnCurrentDelete";
            btnCurrentDelete.Size = new Size(177, 60);
            btnCurrentDelete.TabIndex = 64;
            btnCurrentDelete.Text = "SİL";
            btnCurrentDelete.UseVisualStyleBackColor = false;
            // 
            // btnCurrentUpdate
            // 
            btnCurrentUpdate.BackColor = SystemColors.ButtonHighlight;
            btnCurrentUpdate.FlatAppearance.BorderSize = 0;
            btnCurrentUpdate.FlatStyle = FlatStyle.Flat;
            btnCurrentUpdate.Image = Properties.Resources._3671846_refresh_icon__1_;
            btnCurrentUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCurrentUpdate.Location = new Point(837, 570);
            btnCurrentUpdate.Name = "btnCurrentUpdate";
            btnCurrentUpdate.Size = new Size(177, 60);
            btnCurrentUpdate.TabIndex = 63;
            btnCurrentUpdate.Text = "GÜNCELLE";
            btnCurrentUpdate.UseVisualStyleBackColor = false;
            // 
            // btnImportCurrent
            // 
            btnImportCurrent.BackColor = SystemColors.ButtonHighlight;
            btnImportCurrent.FlatAppearance.BorderSize = 0;
            btnImportCurrent.FlatStyle = FlatStyle.Flat;
            btnImportCurrent.Image = Properties.Resources._8541930_file_import_icon__1_;
            btnImportCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            btnImportCurrent.Location = new Point(314, 570);
            btnImportCurrent.Name = "btnImportCurrent";
            btnImportCurrent.Size = new Size(177, 60);
            btnImportCurrent.TabIndex = 62;
            btnImportCurrent.Text = "İÇE AKTAR";
            btnImportCurrent.UseVisualStyleBackColor = false;
            // 
            // btnCreateCurrent
            // 
            btnCreateCurrent.BackColor = SystemColors.ButtonHighlight;
            btnCreateCurrent.FlatAppearance.BorderSize = 0;
            btnCreateCurrent.FlatStyle = FlatStyle.Flat;
            btnCreateCurrent.Image = Properties.Resources._8541957_file_invoice_icon;
            btnCreateCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateCurrent.Location = new Point(1099, 570);
            btnCreateCurrent.Name = "btnCreateCurrent";
            btnCreateCurrent.Size = new Size(177, 60);
            btnCreateCurrent.TabIndex = 61;
            btnCreateCurrent.Text = "KAYDET";
            btnCreateCurrent.UseVisualStyleBackColor = false;
            btnCreateCurrent.Click += btnCreateCurrent_Click;
            // 
            // StocTrackingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 686);
            Controls.Add(btnCurrentDelete);
            Controls.Add(btnCurrentUpdate);
            Controls.Add(btnImportCurrent);
            Controls.Add(btnCreateCurrent);
            Controls.Add(lswProductList);
            Name = "StocTrackingForm";
            Text = "StocTrackingForm";
            Load += StocTrackingForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lswProductList;
        private Button btnCurrentDelete;
        private Button btnCurrentUpdate;
        private Button btnImportCurrent;
        private Button btnCreateCurrent;
    }
}