namespace BakupsDeVitalDent
{
    partial class frmInicio
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
            lblBienvenido = new Label();
            dgvRecientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(36, 34);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(361, 38);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenidos a Vital Dent";
            // 
            // dgvRecientes
            // 
            dgvRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecientes.Location = new Point(181, 116);
            dgvRecientes.Name = "dgvRecientes";
            dgvRecientes.RowHeadersWidth = 62;
            dgvRecientes.Size = new Size(1327, 568);
            dgvRecientes.TabIndex = 1;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1644, 784);
            Controls.Add(dgvRecientes);
            Controls.Add(lblBienvenido);
            Name = "frmInicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private DataGridView dgvRecientes;
    }
}