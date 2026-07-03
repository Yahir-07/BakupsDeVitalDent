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
            txtNombre = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pcbLupa).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarPacientes
            // 
            txtBuscarPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarPacientes.Location = new Point(329, 102);
            txtBuscarPacientes.Margin = new Padding(4, 5, 4, 5);
            txtBuscarPacientes.Multiline = true;
            txtBuscarPacientes.Name = "txtBuscarPacientes";
            txtBuscarPacientes.PlaceholderText = "Buscar Paciente";
            txtBuscarPacientes.Size = new Size(900, 39);
            txtBuscarPacientes.TabIndex = 1;
            // 
            // lblAgendaCitas
            // 
            lblAgendaCitas.AutoSize = true;
            lblAgendaCitas.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgendaCitas.Location = new Point(17, 15);
            lblAgendaCitas.Margin = new Padding(4, 0, 4, 0);
            lblAgendaCitas.Name = "lblAgendaCitas";
            lblAgendaCitas.Size = new Size(263, 45);
            lblAgendaCitas.TabIndex = 10;
            lblAgendaCitas.Text = "Agenda de Citas";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(244, 249, 252);
            btnBuscar.Location = new Point(1242, 102);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(200, 45);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pcbLupa
            // 
            pcbLupa.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
            pcbLupa.Location = new Point(275, 99);
            pcbLupa.Margin = new Padding(4, 5, 4, 5);
            pcbLupa.Name = "pcbLupa";
            pcbLupa.Size = new Size(34, 42);
            pcbLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLupa.TabIndex = 42;
            pcbLupa.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F);
            lblNombre.Location = new Point(124, 164);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 31);
            lblNombre.TabIndex = 44;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(329, 164);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(1020, 31);
            txtNombre.TabIndex = 43;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Format = DateTimePickerFormat.Short;
            dtpFechaCita.Location = new Point(329, 208);
            dtpFechaCita.Margin = new Padding(4, 5, 4, 5);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(290, 31);
            dtpFechaCita.TabIndex = 46;
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Font = new Font("Segoe UI", 11.25F);
            lblFechaCita.Location = new Point(124, 208);
            lblFechaCita.Margin = new Padding(4, 0, 4, 0);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(172, 31);
            lblFechaCita.TabIndex = 45;
            lblFechaCita.Text = "Fecha de la cita";
            // 
            // lblMotivoCita
            // 
            lblMotivoCita.AutoSize = true;
            lblMotivoCita.Font = new Font("Segoe UI", 11.25F);
            lblMotivoCita.Location = new Point(124, 244);
            lblMotivoCita.Margin = new Padding(4, 0, 4, 0);
            lblMotivoCita.Name = "lblMotivoCita";
            lblMotivoCita.Size = new Size(185, 31);
            lblMotivoCita.TabIndex = 48;
            lblMotivoCita.Text = "Motivo de la cita";
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(329, 246);
            txtMotivoCita.Margin = new Padding(4, 5, 4, 5);
            txtMotivoCita.Multiline = true;
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(1020, 100);
            txtMotivoCita.TabIndex = 47;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 205, 210);
            btnCancelar.Location = new Point(1256, 355);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 45);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(244, 249, 252);
            btnGuardar.Location = new Point(1034, 355);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
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
            mcCalendarioCitas.Location = new Point(289, 466);
            mcCalendarioCitas.Margin = new Padding(13, 15, 13, 15);
            mcCalendarioCitas.Name = "mcCalendarioCitas";
            mcCalendarioCitas.TabIndex = 51;
            // 
            // lblCalendarioCita
            // 
            lblCalendarioCita.AutoSize = true;
            lblCalendarioCita.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalendarioCita.Location = new Point(45, 413);
            lblCalendarioCita.Margin = new Padding(4, 0, 4, 0);
            lblCalendarioCita.Name = "lblCalendarioCita";
            lblCalendarioCita.Size = new Size(264, 38);
            lblCalendarioCita.TabIndex = 52;
            lblCalendarioCita.Text = "Calendario de citas";
            // 
            // btnGuardarCita
            // 
            btnGuardarCita.BackColor = Color.FromArgb(244, 249, 252);
            btnGuardarCita.Location = new Point(1123, 888);
            btnGuardarCita.Margin = new Padding(4, 5, 4, 5);
            btnGuardarCita.Name = "btnGuardarCita";
            btnGuardarCita.Size = new Size(214, 50);
            btnGuardarCita.TabIndex = 53;
            btnGuardarCita.Text = "Guardar cita";
            btnGuardarCita.UseVisualStyleBackColor = false;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(920, 208);
            dtpHoraCita.Margin = new Padding(4, 5, 4, 5);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.ShowUpDown = true;
            dtpHoraCita.Size = new Size(290, 31);
            dtpHoraCita.TabIndex = 54;
            // 
            // lblHoraCita
            // 
            lblHoraCita.AutoSize = true;
            lblHoraCita.Font = new Font("Segoe UI", 11.25F);
            lblHoraCita.Location = new Point(750, 210);
            lblHoraCita.Margin = new Padding(4, 0, 4, 0);
            lblHoraCita.Name = "lblHoraCita";
            lblHoraCita.Size = new Size(162, 31);
            lblHoraCita.TabIndex = 55;
            lblHoraCita.Text = "Hora de la cita";
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.BackColor = Color.FromArgb(255, 205, 210);
            btnCancelarCita.Location = new Point(1256, 726);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(200, 45);
            btnCancelarCita.TabIndex = 56;
            btnCancelarCita.Text = "Cancelar Cita";
            btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // frmAgendaCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1644, 801);
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
            Controls.Add(txtNombre);
            Controls.Add(pcbLupa);
            Controls.Add(btnBuscar);
            Controls.Add(lblAgendaCitas);
            Controls.Add(txtBuscarPacientes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAgendaCitas";
            Text = "frmAgendaCitas";
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
		private TextBox txtNombre;
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
    }
}