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
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            lblTratamiento = new Label();
            txtTratamiento = new TextBox();
            lblMeicamentos = new Label();
            txtMedicamento = new TextBox();
            txtDosis = new TextBox();
            txtIndicaciones = new TextBox();
            txtNotasClinicas = new TextBox();
            lblDosis = new Label();
            lblIdicaciones = new Label();
            lblNotasClinicas = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLupa).BeginInit();
            SuspendLayout();
            // 
            // pcbLupa
            // 
            pcbLupa.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
            pcbLupa.Location = new Point(186, 92);
            pcbLupa.Margin = new Padding(3, 4, 3, 4);
            pcbLupa.Name = "pcbLupa";
            pcbLupa.Size = new Size(30, 30);
            pcbLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLupa.TabIndex = 45;
            pcbLupa.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 249, 252);
            btnBuscar.Location = new Point(1046, 81);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 45);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPacientes
            // 
            txtBuscarPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPacientes.Location = new Point(221, 92);
            txtBuscarPacientes.Margin = new Padding(3, 4, 3, 4);
            txtBuscarPacientes.Multiline = true;
            txtBuscarPacientes.Name = "txtBuscarPacientes";
            txtBuscarPacientes.PlaceholderText = "Buscar Paciente";
            txtBuscarPacientes.Size = new Size(819, 32);
            txtBuscarPacientes.TabIndex = 43;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsulta.Location = new Point(14, 12);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(129, 37);
            lblConsulta.TabIndex = 46;
            lblConsulta.Text = "Consulta";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnostico.Location = new Point(94, 173);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(107, 25);
            lblDiagnostico.TabIndex = 47;
            lblDiagnostico.Text = "Diagnostico";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(223, 174);
            txtDiagnostico.Margin = new Padding(3, 4, 3, 4);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.PlaceholderText = "Diagnostico del paciente";
            txtDiagnostico.Size = new Size(817, 25);
            txtDiagnostico.TabIndex = 52;
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTratamiento.Location = new Point(94, 209);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(105, 25);
            lblTratamiento.TabIndex = 53;
            lblTratamiento.Text = "Tratamiento";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(223, 210);
            txtTratamiento.Margin = new Padding(3, 4, 3, 4);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.PlaceholderText = "Descripción del tratamiento ";
            txtTratamiento.Size = new Size(817, 71);
            txtTratamiento.TabIndex = 54;
            // 
            // lblMeicamentos
            // 
            lblMeicamentos.AutoSize = true;
            lblMeicamentos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeicamentos.Location = new Point(94, 296);
            lblMeicamentos.Name = "lblMeicamentos";
            lblMeicamentos.Size = new Size(121, 25);
            lblMeicamentos.TabIndex = 55;
            lblMeicamentos.Text = "Medicamento";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(221, 297);
            txtMedicamento.Margin = new Padding(3, 4, 3, 4);
            txtMedicamento.Multiline = true;
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.PlaceholderText = "Medicamento";
            txtMedicamento.Size = new Size(817, 25);
            txtMedicamento.TabIndex = 56;
            // 
            // txtDosis
            // 
            txtDosis.Location = new Point(223, 330);
            txtDosis.Margin = new Padding(3, 4, 3, 4);
            txtDosis.Multiline = true;
            txtDosis.Name = "txtDosis";
            txtDosis.PlaceholderText = "Dosis del medicamento";
            txtDosis.Size = new Size(817, 25);
            txtDosis.TabIndex = 57;
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(223, 363);
            txtIndicaciones.Margin = new Padding(3, 4, 3, 4);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.PlaceholderText = "Indicaciones del tratamiento";
            txtIndicaciones.Size = new Size(817, 75);
            txtIndicaciones.TabIndex = 58;
            // 
            // txtNotasClinicas
            // 
            txtNotasClinicas.Location = new Point(223, 460);
            txtNotasClinicas.Margin = new Padding(3, 4, 3, 4);
            txtNotasClinicas.Multiline = true;
            txtNotasClinicas.Name = "txtNotasClinicas";
            txtNotasClinicas.PlaceholderText = "Observaciones del paciente";
            txtNotasClinicas.Size = new Size(817, 86);
            txtNotasClinicas.TabIndex = 59;
            // 
            // lblDosis
            // 
            lblDosis.AutoSize = true;
            lblDosis.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDosis.Location = new Point(94, 330);
            lblDosis.Name = "lblDosis";
            lblDosis.Size = new Size(56, 25);
            lblDosis.TabIndex = 60;
            lblDosis.Text = "Dosis";
            // 
            // lblIdicaciones
            // 
            lblIdicaciones.AutoSize = true;
            lblIdicaciones.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdicaciones.Location = new Point(94, 363);
            lblIdicaciones.Name = "lblIdicaciones";
            lblIdicaciones.Size = new Size(109, 25);
            lblIdicaciones.TabIndex = 61;
            lblIdicaciones.Text = "Indicaciones";
            // 
            // lblNotasClinicas
            // 
            lblNotasClinicas.AutoSize = true;
            lblNotasClinicas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotasClinicas.Location = new Point(94, 460);
            lblNotasClinicas.Name = "lblNotasClinicas";
            lblNotasClinicas.Size = new Size(122, 25);
            lblNotasClinicas.TabIndex = 62;
            lblNotasClinicas.Text = "Notas Clinicas";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(244, 249, 252);
            btnGuardar.Location = new Point(791, 554);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 45);
            btnGuardar.TabIndex = 63;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 205, 210);
            btnCancelar.Location = new Point(997, 554);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 45);
            btnCancelar.TabIndex = 64;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1315, 627);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblNotasClinicas);
            Controls.Add(lblIdicaciones);
            Controls.Add(lblDosis);
            Controls.Add(txtNotasClinicas);
            Controls.Add(txtIndicaciones);
            Controls.Add(txtDosis);
            Controls.Add(txtMedicamento);
            Controls.Add(lblMeicamentos);
            Controls.Add(txtTratamiento);
            Controls.Add(lblTratamiento);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblDiagnostico);
            Controls.Add(lblConsulta);
            Controls.Add(pcbLupa);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarPacientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmConsulta";
            Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)pcbLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLupa;
		private Button btnBuscar;
		private TextBox txtBuscarPacientes;
		private Label lblConsulta;
        private Label lblDiagnostico;
        private TextBox txtDiagnostico;
        private Label lblTratamiento;
        private TextBox txtTratamiento;
        private Label lblMeicamentos;
        private TextBox txtMedicamento;
        private TextBox txtDosis;
        private TextBox txtIndicaciones;
        private TextBox txtNotasClinicas;
        private Label lblDosis;
        private Label lblIdicaciones;
        private Label lblNotasClinicas;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}