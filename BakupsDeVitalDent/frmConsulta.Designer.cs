namespace BakupsDeVitalDent
{
	partial class frmConsulta
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
            pcbLupa = new PictureBox();
            btnBuscar = new Button();
            txtBuscarPacientes = new TextBox();
            lblConsulta = new Label();
            dgvPacientes = new DataGridView();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLupa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // pcbLupa
            // 
            pcbLupa.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
            pcbLupa.Location = new Point(233, 115);
            pcbLupa.Margin = new Padding(4, 5, 4, 5);
            pcbLupa.Name = "pcbLupa";
            pcbLupa.Size = new Size(34, 42);
            pcbLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLupa.TabIndex = 45;
            pcbLupa.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 249, 252);
            btnBuscar.Location = new Point(1309, 107);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(214, 50);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPacientes
            // 
            txtBuscarPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPacientes.Location = new Point(276, 115);
            txtBuscarPacientes.Margin = new Padding(4, 5, 4, 5);
            txtBuscarPacientes.Multiline = true;
            txtBuscarPacientes.Name = "txtBuscarPacientes";
            txtBuscarPacientes.PlaceholderText = "Buscar Paciente";
            txtBuscarPacientes.Size = new Size(1023, 39);
            txtBuscarPacientes.TabIndex = 43;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsulta.Location = new Point(17, 15);
            lblConsulta.Margin = new Padding(4, 0, 4, 0);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(150, 45);
            lblConsulta.TabIndex = 46;
            lblConsulta.Text = "Consulta";
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(195, 181);
            dgvPacientes.Margin = new Padding(4, 5, 4, 5);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 62;
            dgvPacientes.Size = new Size(1328, 539);
            dgvPacientes.TabIndex = 47;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(244, 249, 252);
            btnSiguiente.Location = new Point(1307, 730);
            btnSiguiente.Margin = new Padding(4, 5, 4, 5);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(214, 50);
            btnSiguiente.TabIndex = 52;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.FromArgb(244, 249, 252);
            btnAnterior.Location = new Point(1085, 730);
            btnAnterior.Margin = new Padding(4, 5, 4, 5);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(214, 50);
            btnAnterior.TabIndex = 51;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 801);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(dgvPacientes);
            Controls.Add(lblConsulta);
            Controls.Add(pcbLupa);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarPacientes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmConsulta";
            Text = "frmConsulta";
            ((System.ComponentModel.ISupportInitialize)pcbLupa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLupa;
		private Button btnBuscar;
		private TextBox txtBuscarPacientes;
		private Label lblConsulta;
		private DataGridView dgvPacientes;
		private Button btnSiguiente;
		private Button btnAnterior;
	}
}