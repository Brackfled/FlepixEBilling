namespace FormUI
{
    partial class MainForm
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
            panelHeader = new Panel();
            btnCurrentCreate = new Button();
            lblFlepixLogo = new Label();
            pnlContent = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ButtonHighlight;
            panelHeader.Controls.Add(btnCurrentCreate);
            panelHeader.Controls.Add(lblFlepixLogo);
            panelHeader.Location = new Point(12, 12);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1576, 72);
            panelHeader.TabIndex = 0;
            // 
            // btnCurrentCreate
            // 
            btnCurrentCreate.FlatAppearance.MouseDownBackColor = Color.White;
            btnCurrentCreate.FlatAppearance.MouseOverBackColor = Color.White;
            btnCurrentCreate.FlatStyle = FlatStyle.Flat;
            btnCurrentCreate.ForeColor = SystemColors.ControlLightLight;
            btnCurrentCreate.Image = Properties.Resources._8665460_id_card_clip_icon__2_;
            btnCurrentCreate.Location = new Point(207, 3);
            btnCurrentCreate.Name = "btnCurrentCreate";
            btnCurrentCreate.Size = new Size(70, 66);
            btnCurrentCreate.TabIndex = 1;
            btnCurrentCreate.UseVisualStyleBackColor = true;
            btnCurrentCreate.Click += btnCurrentCreate_Click;
            // 
            // lblFlepixLogo
            // 
            lblFlepixLogo.AllowDrop = true;
            lblFlepixLogo.AutoSize = true;
            lblFlepixLogo.ForeColor = Color.Blue;
            lblFlepixLogo.Location = new Point(19, 26);
            lblFlepixLogo.Name = "lblFlepixLogo";
            lblFlepixLogo.Size = new Size(108, 20);
            lblFlepixLogo.TabIndex = 0;
            lblFlepixLogo.Text = "Flepix E-Billing";
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(12, 102);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1576, 686);
            pnlContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 800);
            Controls.Add(pnlContent);
            Controls.Add(panelHeader);
            Name = "MainForm";
            Text = "MainForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblFlepixLogo;
        private Button btnCurrentCreate;
        private Panel pnlContent;
    }
}