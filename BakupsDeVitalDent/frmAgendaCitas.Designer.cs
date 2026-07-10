namespace BakupsDeVitalDent
{
	partial class frmAgendaCitas
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
            txtBuscarPacientes = new TextBox();
            lblAgendaCitas = new Label();
            btnBuscar = new Button();
            pcbLupa = new PictureBox();
            lblNombre = new Label();
            txtNombrePaciente = new TextBox();
            dtpFechaCita = new DateTimePicker();
            lblFechaCita = new Label();
            lblMotivoCita = new Label();
            txtMotivoCita = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            mcCalendarioCitas = new MonthCalendar();
            lblCalendarioCita = new Label();
            btnGuardarCita = new Button();
            dtpHoraCita = new DateTimePicker();
            lblHoraCita = new Label();
            btnCancelarCita = new Button();
            label1 = new Label();
            cmbEstadoCita = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pcbLupa).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarPacientes
            // 
            txtBuscarPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPacientes.Location = new Point(263, 82);
            txtBuscarPacientes.Margin = new Padding(3, 4, 3, 4);
            txtBuscarPacientes.Multiline = true;
            txtBuscarPacientes.Name = "txtBuscarPacientes";
            txtBuscarPacientes.PlaceholderText = "Buscar Paciente";
            txtBuscarPacientes.Size = new Size(720, 32);
            txtBuscarPacientes.TabIndex = 1;
            // 
            // lblAgendaCitas
            // 
            lblAgendaCitas.AutoSize = true;
            lblAgendaCitas.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgendaCitas.Location = new Point(14, 12);
            lblAgendaCitas.Name = "lblAgendaCitas";
            lblAgendaCitas.Size = new Size(225, 37);
            lblAgendaCitas.TabIndex = 10;
            lblAgendaCitas.Text = "Agenda de Citas";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 249, 252);
            btnBuscar.Location = new Point(1005, 69);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 45);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pcbLupa
            // 
            pcbLupa.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
            pcbLupa.Location = new Point(220, 79);
            pcbLupa.Margin = new Padding(3, 4, 3, 4);
            pcbLupa.Name = "pcbLupa";
            pcbLupa.Size = new Size(30, 30);
            pcbLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLupa.TabIndex = 42;
            pcbLupa.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F);
            lblNombre.Location = new Point(99, 131);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 44;
            lblNombre.Text = "Nombre";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(263, 131);
            txtNombrePaciente.Margin = new Padding(3, 4, 3, 4);
            txtNombrePaciente.Multiline = true;
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(817, 25);
            txtNombrePaciente.TabIndex = 43;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.Location = new Point(263, 166);
            dtpFechaCita.Margin = new Padding(3, 4, 3, 4);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(234, 27);
            dtpFechaCita.TabIndex = 46;
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Font = new Font("Segoe UI", 11.25F);
            lblFechaCita.Location = new Point(99, 166);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(142, 25);
            lblFechaCita.TabIndex = 45;
            lblFechaCita.Text = "Fecha de la cita";
            // 
            // lblMotivoCita
            // 
            lblMotivoCita.AutoSize = true;
            lblMotivoCita.Font = new Font("Segoe UI", 11.25F);
            lblMotivoCita.Location = new Point(99, 195);
            lblMotivoCita.Name = "lblMotivoCita";
            lblMotivoCita.Size = new Size(152, 25);
            lblMotivoCita.TabIndex = 48;
            lblMotivoCita.Text = "Motivo de la cita";
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(263, 201);
            txtMotivoCita.Margin = new Padding(3, 4, 3, 4);
            txtMotivoCita.Multiline = true;
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(817, 80);
            txtMotivoCita.TabIndex = 47;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 205, 210);
            btnCancelar.Location = new Point(1005, 284);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 45);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(244, 249, 252);
            btnGuardar.Location = new Point(783, 284);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 45);
            btnGuardar.TabIndex = 49;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // mcCalendarioCitas
            // 
            mcCalendarioCitas.CalendarDimensions = new Size(3, 1);
            mcCalendarioCitas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcCalendarioCitas.Location = new Point(231, 349);
            mcCalendarioCitas.Margin = new Padding(10, 12, 10, 12);
            mcCalendarioCitas.Name = "mcCalendarioCitas";
            mcCalendarioCitas.TabIndex = 51;
            // 
            // lblCalendarioCita
            // 
            lblCalendarioCita.AutoSize = true;
            lblCalendarioCita.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalendarioCita.Location = new Point(36, 318);
            lblCalendarioCita.Name = "lblCalendarioCita";
            lblCalendarioCita.Size = new Size(231, 32);
            lblCalendarioCita.TabIndex = 52;
            lblCalendarioCita.Text = "Calendario de citas";
            // 
            // btnGuardarCita
            // 
            btnGuardarCita.BackColor = Color.FromArgb(244, 249, 252);
            btnGuardarCita.Location = new Point(898, 710);
            btnGuardarCita.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCita.Name = "btnGuardarCita";
            btnGuardarCita.Size = new Size(171, 40);
            btnGuardarCita.TabIndex = 53;
            btnGuardarCita.Text = "Guardar cita";
            btnGuardarCita.UseVisualStyleBackColor = false;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(736, 166);
            dtpHoraCita.Margin = new Padding(3, 4, 3, 4);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.ShowUpDown = true;
            dtpHoraCita.Size = new Size(234, 27);
            dtpHoraCita.TabIndex = 54;
            // 
            // lblHoraCita
            // 
            lblHoraCita.AutoSize = true;
            lblHoraCita.Font = new Font("Segoe UI", 11.25F);
            lblHoraCita.Location = new Point(600, 168);
            lblHoraCita.Name = "lblHoraCita";
            lblHoraCita.Size = new Size(134, 25);
            lblHoraCita.TabIndex = 55;
            lblHoraCita.Text = "Hora de la cita";
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.BackColor = Color.FromArgb(255, 205, 210);
            btnCancelarCita.Location = new Point(1005, 560);
            btnCancelarCita.Margin = new Padding(2);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(200, 45);
            btnCancelarCita.TabIndex = 56;
            btnCancelarCita.Text = "Cancelar Cita";
            btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(231, 580);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 57;
            label1.Text = "Estado de la cita";
            // 
            // cmbEstadoCita
            // 
            cmbEstadoCita.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCita.FormattingEnabled = true;
            cmbEstadoCita.Items.AddRange(new object[] { "Activo", "Cancelado" });
            cmbEstadoCita.Location = new Point(386, 577);
            cmbEstadoCita.Name = "cmbEstadoCita";
            cmbEstadoCita.Size = new Size(345, 28);
            cmbEstadoCita.TabIndex = 58;
            // 
            // frmAgendaCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1315, 627);
            Controls.Add(cmbEstadoCita);
            Controls.Add(label1);
            Controls.Add(btnCancelarCita);
            Controls.Add(lblHoraCita);
            Controls.Add(dtpHoraCita);
            Controls.Add(btnGuardarCita);
            Controls.Add(lblCalendarioCita);
            Controls.Add(mcCalendarioCitas);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblMotivoCita);
            Controls.Add(txtMotivoCita);
            Controls.Add(dtpFechaCita);
            Controls.Add(lblFechaCita);
            Controls.Add(lblNombre);
            Controls.Add(txtNombrePaciente);
            Controls.Add(pcbLupa);
            Controls.Add(btnBuscar);
            Controls.Add(lblAgendaCitas);
            Controls.Add(txtBuscarPacientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAgendaCitas";
            Text = "AgendaCitas";
            ((System.ComponentModel.ISupportInitialize)pcbLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarPacientes;
		private Label lblAgendaCitas;
		private Button btnBuscar;
		private PictureBox pcbLupa;
		private Label lblNombre;
		private TextBox txtNombrePaciente;
		private DateTimePicker dtpFechaCita;
		private Label lblFechaCita;
		private Label lblMotivoCita;
		private TextBox txtMotivoCita;
		private Button btnCancelar;
		private Button btnGuardar;
		private MonthCalendar mcCalendarioCitas;
		private Label lblCalendarioCita;
		private Button btnGuardarCita;
		private DateTimePicker dtpHoraCita;
		private Label lblHoraCita;
        private Button btnCancelarCita;
        private Label label1;
        private ComboBox cmbEstadoCita;
    }
}