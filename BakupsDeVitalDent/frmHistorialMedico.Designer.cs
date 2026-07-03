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
            txtNombre = new TextBox();
            lblFechaConsulta = new Label();
            txtFechaConsulta = new TextBox();
            lblMotivoConsulta = new Label();
            txtMotivoConsulta = new TextBox();
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            lblTratamiento = new Label();
            txtTratamiento = new TextBox();
            lblObservaciones = new Label();
            txtObservaciones = new TextBox();
            btnLimpiar = new Button();
            btnDescarga = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbLupa).BeginInit();
            SuspendLayout();
            // 
            // lblHistorialMedico
            // 
            lblHistorialMedico.AutoSize = true;
            lblHistorialMedico.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorialMedico.Location = new Point(17, 15);
            lblHistorialMedico.Margin = new Padding(4, 0, 4, 0);
            lblHistorialMedico.Name = "lblHistorialMedico";
            lblHistorialMedico.Size = new Size(269, 45);
            lblHistorialMedico.TabIndex = 47;
            lblHistorialMedico.Text = "Historial Medico";
            // 
            // ptbLupa
            // 
            ptbLupa.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
            ptbLupa.Location = new Point(221, 93);
            ptbLupa.Margin = new Padding(4, 5, 4, 5);
            ptbLupa.Name = "ptbLupa";
            ptbLupa.Size = new Size(34, 42);
            ptbLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLupa.TabIndex = 50;
            ptbLupa.TabStop = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 249, 252);
            btnBuscar.Location = new Point(1201, 89);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 45);
            btnBuscar.TabIndex = 49;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPaciente.Location = new Point(275, 93);
            txtBuscarPaciente.Margin = new Padding(4, 5, 4, 5);
            txtBuscarPaciente.Multiline = true;
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.PlaceholderText = "Buscar Paciente";
            txtBuscarPaciente.Size = new Size(900, 39);
            txtBuscarPaciente.TabIndex = 48;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F);
            lblNombre.Location = new Point(119, 156);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 31);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(381, 156);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(1020, 30);
            txtNombre.TabIndex = 51;
            // 
            // lblFechaConsulta
            // 
            lblFechaConsulta.AutoSize = true;
            lblFechaConsulta.Font = new Font("Segoe UI", 11.25F);
            lblFechaConsulta.Location = new Point(119, 193);
            lblFechaConsulta.Margin = new Padding(4, 0, 4, 0);
            lblFechaConsulta.Name = "lblFechaConsulta";
            lblFechaConsulta.Size = new Size(197, 31);
            lblFechaConsulta.TabIndex = 54;
            lblFechaConsulta.Text = "Fecha de consulta";
            // 
            // txtFechaConsulta
            // 
            txtFechaConsulta.Location = new Point(381, 193);
            txtFechaConsulta.Margin = new Padding(4, 5, 4, 5);
            txtFechaConsulta.Multiline = true;
            txtFechaConsulta.Name = "txtFechaConsulta";
            txtFechaConsulta.Size = new Size(463, 31);
            txtFechaConsulta.TabIndex = 53;
            // 
            // lblMotivoConsulta
            // 
            lblMotivoConsulta.AutoSize = true;
            lblMotivoConsulta.Font = new Font("Segoe UI", 11.25F);
            lblMotivoConsulta.Location = new Point(119, 234);
            lblMotivoConsulta.Margin = new Padding(4, 0, 4, 0);
            lblMotivoConsulta.Name = "lblMotivoConsulta";
            lblMotivoConsulta.Size = new Size(213, 31);
            lblMotivoConsulta.TabIndex = 56;
            lblMotivoConsulta.Text = "Motivo de Consulta";
            // 
            // txtMotivoConsulta
            // 
            txtMotivoConsulta.Location = new Point(381, 235);
            txtMotivoConsulta.Margin = new Padding(4, 5, 4, 5);
            txtMotivoConsulta.Multiline = true;
            txtMotivoConsulta.Name = "txtMotivoConsulta";
            txtMotivoConsulta.Size = new Size(1020, 30);
            txtMotivoConsulta.TabIndex = 55;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 11.25F);
            lblDiagnostico.Location = new Point(119, 277);
            lblDiagnostico.Margin = new Padding(4, 0, 4, 0);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(136, 31);
            lblDiagnostico.TabIndex = 58;
            lblDiagnostico.Text = "Diagnostico";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(381, 275);
            txtDiagnostico.Margin = new Padding(4, 5, 4, 5);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(1020, 30);
            txtDiagnostico.TabIndex = 57;
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Segoe UI", 11.25F);
            lblTratamiento.Location = new Point(119, 316);
            lblTratamiento.Margin = new Padding(4, 0, 4, 0);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(136, 31);
            lblTratamiento.TabIndex = 60;
            lblTratamiento.Text = "Tratamiento";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(381, 315);
            txtTratamiento.Margin = new Padding(4, 5, 4, 5);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(1020, 30);
            txtTratamiento.TabIndex = 59;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 11.25F);
            lblObservaciones.Location = new Point(119, 367);
            lblObservaciones.Margin = new Padding(4, 0, 4, 0);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(163, 31);
            lblObservaciones.TabIndex = 64;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(381, 369);
            txtObservaciones.Margin = new Padding(4, 5, 4, 5);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(1020, 309);
            txtObservaciones.TabIndex = 63;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 205, 210);
            btnLimpiar.Location = new Point(1201, 688);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 45);
            btnLimpiar.TabIndex = 66;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnDescarga
            // 
            btnDescarga.BackColor = Color.FromArgb(244, 249, 252);
            btnDescarga.Location = new Point(993, 688);
            btnDescarga.Margin = new Padding(4, 5, 4, 5);
            btnDescarga.Name = "btnDescarga";
            btnDescarga.Size = new Size(200, 45);
            btnDescarga.TabIndex = 65;
            btnDescarga.Text = "Descargar ";
            btnDescarga.UseVisualStyleBackColor = false;
            // 
            // frmHistorialMedico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1644, 801);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDescarga);
            Controls.Add(lblObservaciones);
            Controls.Add(txtObservaciones);
            Controls.Add(lblTratamiento);
            Controls.Add(txtTratamiento);
            Controls.Add(lblDiagnostico);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblMotivoConsulta);
            Controls.Add(txtMotivoConsulta);
            Controls.Add(lblFechaConsulta);
            Controls.Add(txtFechaConsulta);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(ptbLupa);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(lblHistorialMedico);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHistorialMedico";
            Text = "frmHistorialMedico";
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
		private TextBox txtNombre;
		private Label lblFechaConsulta;
		private TextBox txtFechaConsulta;
		private Label lblMotivoConsulta;
		private TextBox txtMotivoConsulta;
		private Label lblDiagnostico;
		private TextBox txtDiagnostico;
		private Label lblTratamiento;
		private TextBox txtTratamiento;
		private Label lblObservaciones;
		private TextBox txtObservaciones;
		private Button btnLimpiar;
		private Button btnDescarga;
        private Label lblMedicameto;
        private TextBox txtMedicamento;
    }
}