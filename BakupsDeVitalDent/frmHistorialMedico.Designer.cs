namespace BakupsDeVitalDent
{
	partial class frmHistorialMedico
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
            lblHistorialMedico = new Label();
            ptbLupa = new PictureBox();
            btnBuscar = new Button();
            txtBuscarPaciente = new TextBox();
            lblNombre = new Label();
            txtNombrePaciente = new TextBox();
            lblFechaConsulta = new Label();
            txtFechaConsulta = new TextBox();
            lblMotivoConsulta = new Label();
            txtMotivoConsulta = new TextBox();
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            lblTratamiento = new Label();
            txtTratamiento = new TextBox();
            lblNotasClinicas = new Label();
            txtNotasClinicas = new TextBox();
            btnLimpiar = new Button();
            btnDescarga = new Button();
            lblMedicamnetos = new Label();
            txtMedicamentos = new TextBox();
            lblDosis = new Label();
            txtDosis = new TextBox();
            lblIndicaciones = new Label();
            txtIndicaciones = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbLupa).BeginInit();
            SuspendLayout();
            // 
            // lblHistorialMedico
            // 
            lblHistorialMedico.AutoSize = true;
            lblHistorialMedico.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorialMedico.Location = new Point(14, 12);
            lblHistorialMedico.Name = "lblHistorialMedico";
            lblHistorialMedico.Size = new Size(231, 37);
            lblHistorialMedico.TabIndex = 47;
            lblHistorialMedico.Text = "Historial Medico";
            // 
            // ptbLupa
            // 
            ptbLupa.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
            ptbLupa.Location = new Point(177, 74);
            ptbLupa.Margin = new Padding(3, 4, 3, 4);
            ptbLupa.Name = "ptbLupa";
            ptbLupa.Size = new Size(27, 34);
            ptbLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLupa.TabIndex = 50;
            ptbLupa.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 249, 252);
            btnBuscar.Location = new Point(961, 61);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 45);
            btnBuscar.TabIndex = 49;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPaciente.Location = new Point(220, 74);
            txtBuscarPaciente.Margin = new Padding(3, 4, 3, 4);
            txtBuscarPaciente.Multiline = true;
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.PlaceholderText = "Buscar Paciente";
            txtBuscarPaciente.Size = new Size(720, 32);
            txtBuscarPaciente.TabIndex = 48;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F);
            lblNombre.Location = new Point(95, 125);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(305, 125);
            txtNombrePaciente.Margin = new Padding(3, 4, 3, 4);
            txtNombrePaciente.Multiline = true;
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(817, 25);
            txtNombrePaciente.TabIndex = 51;
            // 
            // lblFechaConsulta
            // 
            lblFechaConsulta.AutoSize = true;
            lblFechaConsulta.Font = new Font("Segoe UI", 11.25F);
            lblFechaConsulta.Location = new Point(95, 154);
            lblFechaConsulta.Name = "lblFechaConsulta";
            lblFechaConsulta.Size = new Size(163, 25);
            lblFechaConsulta.TabIndex = 54;
            lblFechaConsulta.Text = "Fecha de consulta";
            // 
            // txtFechaConsulta
            // 
            txtFechaConsulta.Location = new Point(305, 154);
            txtFechaConsulta.Margin = new Padding(3, 4, 3, 4);
            txtFechaConsulta.Multiline = true;
            txtFechaConsulta.Name = "txtFechaConsulta";
            txtFechaConsulta.Size = new Size(371, 26);
            txtFechaConsulta.TabIndex = 53;
            // 
            // lblMotivoConsulta
            // 
            lblMotivoConsulta.AutoSize = true;
            lblMotivoConsulta.Font = new Font("Segoe UI", 11.25F);
            lblMotivoConsulta.Location = new Point(95, 187);
            lblMotivoConsulta.Name = "lblMotivoConsulta";
            lblMotivoConsulta.Size = new Size(176, 25);
            lblMotivoConsulta.TabIndex = 56;
            lblMotivoConsulta.Text = "Motivo de Consulta";
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Location = new Point(305, 188);
            txtMotivoConsulta.Margin = new Padding(3, 4, 3, 4);
            txtMotivoConsulta.Multiline = true;
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.Size = new Size(817, 25);
            txtMotivoConsulta.TabIndex = 55;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 11.25F);
            lblDiagnostico.Location = new Point(95, 222);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(112, 25);
            lblDiagnostico.TabIndex = 58;
            lblDiagnostico.Text = "Diagnostico";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(305, 220);
            txtDiagnostico.Margin = new Padding(3, 4, 3, 4);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(817, 25);
            txtDiagnostico.TabIndex = 57;
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Segoe UI", 11.25F);
            lblTratamiento.Location = new Point(95, 253);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(112, 25);
            lblTratamiento.TabIndex = 60;
            lblTratamiento.Text = "Tratamiento";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(305, 252);
            txtTratamiento.Margin = new Padding(3, 4, 3, 4);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(817, 25);
            txtTratamiento.TabIndex = 59;
            // 
            // lblNotasClinicas
            // 
            lblNotasClinicas.AutoSize = true;
            lblNotasClinicas.Font = new Font("Segoe UI", 11.25F);
            lblNotasClinicas.Location = new Point(95, 399);
            lblNotasClinicas.Name = "lblNotasClinicas";
            lblNotasClinicas.Size = new Size(131, 25);
            lblNotasClinicas.TabIndex = 64;
            lblNotasClinicas.Text = "Notas Clinicas";
            // 
            // txtNotasClinicas
            // 
            txtNotasClinicas.Location = new Point(305, 399);
            txtNotasClinicas.Margin = new Padding(3, 4, 3, 4);
            txtNotasClinicas.Multiline = true;
            txtNotasClinicas.Name = "txtNotasClinicas";
            txtNotasClinicas.Size = new Size(817, 162);
            txtNotasClinicas.TabIndex = 63;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 205, 210);
            btnLimpiar.Location = new Point(961, 569);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 45);
            btnLimpiar.TabIndex = 66;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnDescarga
            // 
            btnDescarga.BackColor = Color.FromArgb(244, 249, 252);
            btnDescarga.Location = new Point(755, 569);
            btnDescarga.Margin = new Padding(3, 4, 3, 4);
            btnDescarga.Name = "btnDescarga";
            btnDescarga.Size = new Size(200, 45);
            btnDescarga.TabIndex = 65;
            btnDescarga.Text = "Descargar ";
            btnDescarga.UseVisualStyleBackColor = false;
            // 
            // lblMedicamnetos
            // 
            lblMedicamnetos.AutoSize = true;
            lblMedicamnetos.Font = new Font("Segoe UI", 11.25F);
            lblMedicamnetos.Location = new Point(95, 285);
            lblMedicamnetos.Name = "lblMedicamnetos";
            lblMedicamnetos.Size = new Size(136, 25);
            lblMedicamnetos.TabIndex = 67;
            lblMedicamnetos.Text = "Medicamentos";
            // 
            // txtMedicamentos
            // 
            txtMedicamentos.Location = new Point(305, 285);
            txtMedicamentos.Margin = new Padding(3, 4, 3, 4);
            txtMedicamentos.Multiline = true;
            txtMedicamentos.Name = "txtMedicamentos";
            txtMedicamentos.Size = new Size(817, 25);
            txtMedicamentos.TabIndex = 68;
            // 
            // lblDosis
            // 
            lblDosis.AutoSize = true;
            lblDosis.Font = new Font("Segoe UI", 11.25F);
            lblDosis.Location = new Point(95, 318);
            lblDosis.Name = "lblDosis";
            lblDosis.Size = new Size(57, 25);
            lblDosis.TabIndex = 69;
            lblDosis.Text = "Dosis";
            // 
            // txtDosis
            // 
            txtDosis.Location = new Point(305, 318);
            txtDosis.Margin = new Padding(3, 4, 3, 4);
            txtDosis.Multiline = true;
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new Size(817, 25);
            txtDosis.TabIndex = 70;
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Font = new Font("Segoe UI", 11.25F);
            lblIndicaciones.Location = new Point(95, 351);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new Size(117, 25);
            lblIndicaciones.TabIndex = 71;
            lblIndicaciones.Text = "Indicaciones";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new Point(305, 351);
            txtIndicaciones.Margin = new Padding(3, 4, 3, 4);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new Size(817, 25);
            txtIndicaciones.TabIndex = 72;
            // 
            // frmHistorialMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1315, 627);
            Controls.Add(txtIndicaciones);
            Controls.Add(lblIndicaciones);
            Controls.Add(txtDosis);
            Controls.Add(lblDosis);
            Controls.Add(txtMedicamentos);
            Controls.Add(lblMedicamnetos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDescarga);
            Controls.Add(lblNotasClinicas);
            Controls.Add(txtNotasClinicas);
            Controls.Add(lblTratamiento);
            Controls.Add(txtTratamiento);
            Controls.Add(lblDiagnostico);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblMotivoConsulta);
            Controls.Add(txtMotivoConsulta);
            Controls.Add(lblFechaConsulta);
            Controls.Add(txtFechaConsulta);
            Controls.Add(lblNombre);
            Controls.Add(txtNombrePaciente);
            Controls.Add(ptbLupa);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(lblHistorialMedico);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHistorialMedico";
            Text = "HistorialMedico";
            ((System.ComponentModel.ISupportInitialize)ptbLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHistorialMedico;
		private PictureBox ptbLupa;
		private Button btnBuscar;
		private TextBox txtBuscarPaciente;
		private Label lblNombre;
		private TextBox txtNombrePaciente;
		private Label lblFechaConsulta;
		private TextBox txtFechaConsulta;
		private Label lblMotivoConsulta;
		private TextBox txtMotivoConsulta;
		private Label lblDiagnostico;
		private TextBox txtDiagnostico;
		private Label lblTratamiento;
		private TextBox txtTratamiento;
		private Label lblNotasClinicas;
		private TextBox txtNotasClinicas;
		private Button btnLimpiar;
		private Button btnDescarga;
        private Label lblMedicamnetos;
        private TextBox txtMedicamentos;
        private Label lblDosis;
        private TextBox txtDosis;
        private Label lblIndicaciones;
        private TextBox txtIndicaciones;
    }
}