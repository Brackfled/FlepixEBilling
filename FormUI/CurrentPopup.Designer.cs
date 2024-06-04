namespace FormUI
{
    partial class CurrentPopup
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
            dgwCurrents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwCurrents).BeginInit();
            SuspendLayout();
            // 
            // dgwCurrents
            // 
            dgwCurrents.BackgroundColor = SystemColors.Control;
            dgwCurrents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCurrents.Location = new Point(23, 12);
            dgwCurrents.Name = "dgwCurrents";
            dgwCurrents.RowHeadersWidth = 51;
            dgwCurrents.Size = new Size(546, 607);
            dgwCurrents.TabIndex = 0;
            dgwCurrents.CellDoubleClick += dgwCurrents_CellDoubleClick;
            // 
            // CurrentPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 631);
            Controls.Add(dgwCurrents);
            Name = "CurrentPopup";
            Text = "CurrentPopup";
            ((System.ComponentModel.ISupportInitialize)dgwCurrents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwCurrents;
    }
}