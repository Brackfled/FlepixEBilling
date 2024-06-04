namespace FormUI
{
    partial class TaxDepartmentPopup
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
            dgwTaxDepartments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwTaxDepartments).BeginInit();
            SuspendLayout();
            // 
            // dgwTaxDepartments
            // 
            dgwTaxDepartments.BackgroundColor = SystemColors.ControlLightLight;
            dgwTaxDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwTaxDepartments.Location = new Point(35, 12);
            dgwTaxDepartments.Name = "dgwTaxDepartments";
            dgwTaxDepartments.RowHeadersWidth = 51;
            dgwTaxDepartments.Size = new Size(513, 594);
            dgwTaxDepartments.TabIndex = 0;
            dgwTaxDepartments.CellDoubleClick += dgwTaxDepartments_CellDoubleClick;
            // 
            // TaxDepartmentPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 631);
            Controls.Add(dgwTaxDepartments);
            Name = "TaxDepartmentPopup";
            Text = "TaxDepartmentPopup";
            ((System.ComponentModel.ISupportInitialize)dgwTaxDepartments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwTaxDepartments;
    }
}