namespace BakupsDeVitalDent
{
	partial class frmRegistroPacientes
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
			txtNombre = new TextBox();
			lblRegistroPacientes = new Label();
			lblNombre = new Label();
			lblApellidoPaterno = new Label();
			lblApellidoMaterno = new Label();
			lblEdad = new Label();
			lblFechaNacimiento = new Label();
			lblTelefono = new Label();
			lblCorreoElectronico = new Label();
			lblTipoSangre = new Label();
			lblMunicipio = new Label();
			lblCodigoPostal = new Label();
			lblLocalidad = new Label();
			lblColonia = new Label();
			lblCalle = new Label();
			txtApellidoPaterno = new TextBox();
			txtApellidoMaterno = new TextBox();
			txtEdad = new TextBox();
			txtTelefono = new TextBox();
			txtCorreoElectronico = new TextBox();
			txtMunicipio = new TextBox();
			txtCodigoPostal = new TextBox();
			txtLocalidad = new TextBox();
			txtColonia = new TextBox();
			txtCalle = new TextBox();
			lblGenero = new Label();
			cmbGenero = new ComboBox();
			dtpFechaNacimiento = new DateTimePicker();
			txtTipoSangre = new ComboBox();
			btnGuardar = new Button();
			btnCancelar = new Button();
			SuspendLayout();
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(263, 66);
			txtNombre.Multiline = true;
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(717, 20);
			txtNombre.TabIndex = 0;
			// 
			// lblRegistroPacientes
			// 
			lblRegistroPacientes.AutoSize = true;
			lblRegistroPacientes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblRegistroPacientes.Location = new Point(12, 9);
			lblRegistroPacientes.Name = "lblRegistroPacientes";
			lblRegistroPacientes.Size = new Size(221, 30);
			lblRegistroPacientes.TabIndex = 9;
			lblRegistroPacientes.Text = "Registro de Pacientes";
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Font = new Font("Segoe UI", 11.25F);
			lblNombre.Location = new Point(111, 74);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(64, 20);
			lblNombre.TabIndex = 10;
			lblNombre.Text = "Nombre";
			// 
			// lblApellidoPaterno
			// 
			lblApellidoPaterno.AutoSize = true;
			lblApellidoPaterno.Font = new Font("Segoe UI", 11.25F);
			lblApellidoPaterno.Location = new Point(111, 101);
			lblApellidoPaterno.Name = "lblApellidoPaterno";
			lblApellidoPaterno.Size = new Size(122, 20);
			lblApellidoPaterno.TabIndex = 11;
			lblApellidoPaterno.Text = "Apellido paterno";
			// 
			// lblApellidoMaterno
			// 
			lblApellidoMaterno.AutoSize = true;
			lblApellidoMaterno.Font = new Font("Segoe UI", 11.25F);
			lblApellidoMaterno.Location = new Point(111, 135);
			lblApellidoMaterno.Name = "lblApellidoMaterno";
			lblApellidoMaterno.Size = new Size(126, 20);
			lblApellidoMaterno.TabIndex = 12;
			lblApellidoMaterno.Text = "Apellido materno";
			// 
			// lblEdad
			// 
			lblEdad.AutoSize = true;
			lblEdad.Font = new Font("Segoe UI", 11.25F);
			lblEdad.Location = new Point(111, 165);
			lblEdad.Name = "lblEdad";
			lblEdad.Size = new Size(43, 20);
			lblEdad.TabIndex = 13;
			lblEdad.Text = "Edad";
			// 
			// lblFechaNacimiento
			// 
			lblFechaNacimiento.AutoSize = true;
			lblFechaNacimiento.Font = new Font("Segoe UI", 11.25F);
			lblFechaNacimiento.Location = new Point(111, 203);
			lblFechaNacimiento.Name = "lblFechaNacimiento";
			lblFechaNacimiento.Size = new Size(146, 20);
			lblFechaNacimiento.TabIndex = 14;
			lblFechaNacimiento.Text = "Fecha de nacimiento";
			// 
			// lblTelefono
			// 
			lblTelefono.AutoSize = true;
			lblTelefono.Font = new Font("Segoe UI", 11.25F);
			lblTelefono.Location = new Point(111, 232);
			lblTelefono.Name = "lblTelefono";
			lblTelefono.Size = new Size(67, 20);
			lblTelefono.TabIndex = 15;
			lblTelefono.Text = "Telefono";
			// 
			// lblCorreoElectronico
			// 
			lblCorreoElectronico.AutoSize = true;
			lblCorreoElectronico.Font = new Font("Segoe UI", 11.25F);
			lblCorreoElectronico.Location = new Point(111, 268);
			lblCorreoElectronico.Name = "lblCorreoElectronico";
			lblCorreoElectronico.Size = new Size(132, 20);
			lblCorreoElectronico.TabIndex = 16;
			lblCorreoElectronico.Text = "Correo electronico";
			// 
			// lblTipoSangre
			// 
			lblTipoSangre.AutoSize = true;
			lblTipoSangre.Font = new Font("Segoe UI", 11.25F);
			lblTipoSangre.Location = new Point(111, 302);
			lblTipoSangre.Name = "lblTipoSangre";
			lblTipoSangre.Size = new Size(108, 20);
			lblTipoSangre.TabIndex = 17;
			lblTipoSangre.Text = "Tipo de sangre";
			// 
			// lblMunicipio
			// 
			lblMunicipio.AutoSize = true;
			lblMunicipio.Font = new Font("Segoe UI", 11.25F);
			lblMunicipio.Location = new Point(111, 342);
			lblMunicipio.Name = "lblMunicipio";
			lblMunicipio.Size = new Size(75, 20);
			lblMunicipio.TabIndex = 18;
			lblMunicipio.Text = "Municipio";
			// 
			// lblCodigoPostal
			// 
			lblCodigoPostal.AutoSize = true;
			lblCodigoPostal.Font = new Font("Segoe UI", 11.25F);
			lblCodigoPostal.Location = new Point(111, 377);
			lblCodigoPostal.Name = "lblCodigoPostal";
			lblCodigoPostal.Size = new Size(101, 20);
			lblCodigoPostal.TabIndex = 19;
			lblCodigoPostal.Text = "Codigo Postal";
			// 
			// lblLocalidad
			// 
			lblLocalidad.AutoSize = true;
			lblLocalidad.Font = new Font("Segoe UI", 11.25F);
			lblLocalidad.Location = new Point(111, 412);
			lblLocalidad.Name = "lblLocalidad";
			lblLocalidad.Size = new Size(74, 20);
			lblLocalidad.TabIndex = 20;
			lblLocalidad.Text = "Localidad";
			// 
			// lblColonia
			// 
			lblColonia.AutoSize = true;
			lblColonia.Font = new Font("Segoe UI", 11.25F);
			lblColonia.Location = new Point(111, 448);
			lblColonia.Name = "lblColonia";
			lblColonia.Size = new Size(60, 20);
			lblColonia.TabIndex = 21;
			lblColonia.Text = "Colonia";
			// 
			// lblCalle
			// 
			lblCalle.AutoSize = true;
			lblCalle.Font = new Font("Segoe UI", 11.25F);
			lblCalle.Location = new Point(111, 482);
			lblCalle.Name = "lblCalle";
			lblCalle.Size = new Size(42, 20);
			lblCalle.TabIndex = 22;
			lblCalle.Text = "Calle";
			// 
			// txtApellidoPaterno
			// 
			txtApellidoPaterno.Location = new Point(263, 101);
			txtApellidoPaterno.Multiline = true;
			txtApellidoPaterno.Name = "txtApellidoPaterno";
			txtApellidoPaterno.Size = new Size(717, 20);
			txtApellidoPaterno.TabIndex = 23;
			// 
			// txtApellidoMaterno
			// 
			txtApellidoMaterno.Location = new Point(263, 135);
			txtApellidoMaterno.Multiline = true;
			txtApellidoMaterno.Name = "txtApellidoMaterno";
			txtApellidoMaterno.Size = new Size(717, 20);
			txtApellidoMaterno.TabIndex = 24;
			// 
			// txtEdad
			// 
			txtEdad.Location = new Point(263, 165);
			txtEdad.Multiline = true;
			txtEdad.Name = "txtEdad";
			txtEdad.Size = new Size(294, 20);
			txtEdad.TabIndex = 25;
			// 
			// txtTelefono
			// 
			txtTelefono.Location = new Point(263, 232);
			txtTelefono.Multiline = true;
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(717, 20);
			txtTelefono.TabIndex = 27;
			// 
			// txtCorreoElectronico
			// 
			txtCorreoElectronico.Location = new Point(263, 268);
			txtCorreoElectronico.Multiline = true;
			txtCorreoElectronico.Name = "txtCorreoElectronico";
			txtCorreoElectronico.Size = new Size(717, 20);
			txtCorreoElectronico.TabIndex = 28;
			// 
			// txtMunicipio
			// 
			txtMunicipio.Location = new Point(263, 342);
			txtMunicipio.Multiline = true;
			txtMunicipio.Name = "txtMunicipio";
			txtMunicipio.Size = new Size(717, 20);
			txtMunicipio.TabIndex = 30;
			// 
			// txtCodigoPostal
			// 
			txtCodigoPostal.Location = new Point(263, 377);
			txtCodigoPostal.Multiline = true;
			txtCodigoPostal.Name = "txtCodigoPostal";
			txtCodigoPostal.Size = new Size(717, 20);
			txtCodigoPostal.TabIndex = 31;
			// 
			// txtLocalidad
			// 
			txtLocalidad.Location = new Point(263, 413);
			txtLocalidad.Multiline = true;
			txtLocalidad.Name = "txtLocalidad";
			txtLocalidad.Size = new Size(717, 20);
			txtLocalidad.TabIndex = 32;
			// 
			// txtColonia
			// 
			txtColonia.Location = new Point(263, 448);
			txtColonia.Multiline = true;
			txtColonia.Name = "txtColonia";
			txtColonia.Size = new Size(717, 20);
			txtColonia.TabIndex = 33;
			// 
			// txtCalle
			// 
			txtCalle.Location = new Point(263, 483);
			txtCalle.Multiline = true;
			txtCalle.Name = "txtCalle";
			txtCalle.Size = new Size(717, 20);
			txtCalle.TabIndex = 34;
			// 
			// lblGenero
			// 
			lblGenero.AutoSize = true;
			lblGenero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblGenero.Location = new Point(613, 168);
			lblGenero.Name = "lblGenero";
			lblGenero.Size = new Size(57, 20);
			lblGenero.TabIndex = 36;
			lblGenero.Text = "Genero";
			// 
			// cmbGenero
			// 
			cmbGenero.FormattingEnabled = true;
			cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
			cmbGenero.Location = new Point(676, 165);
			cmbGenero.Name = "cmbGenero";
			cmbGenero.Size = new Size(304, 23);
			cmbGenero.TabIndex = 37;
			// 
			// dtpFechaNacimiento
			// 
			dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
			dtpFechaNacimiento.Location = new Point(263, 203);
			dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			dtpFechaNacimiento.Size = new Size(205, 23);
			dtpFechaNacimiento.TabIndex = 38;
			// 
			// txtTipoSangre
			// 
			txtTipoSangre.FormattingEnabled = true;
			txtTipoSangre.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
			txtTipoSangre.Location = new Point(263, 303);
			txtTipoSangre.Name = "txtTipoSangre";
			txtTipoSangre.Size = new Size(294, 23);
			txtTipoSangre.TabIndex = 39;
			// 
			// btnGuardar
			// 
			btnGuardar.BackColor = Color.FromArgb(244, 249, 252);
			btnGuardar.Location = new Point(674, 530);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(150, 30);
			btnGuardar.TabIndex = 40;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = false;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.FromArgb(255, 205, 210);
			btnCancelar.Location = new Point(830, 530);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(150, 30);
			btnCancelar.TabIndex = 41;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			// 
			// frmRegistroPacientes
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1195, 612);
			Controls.Add(btnCancelar);
			Controls.Add(btnGuardar);
			Controls.Add(txtTipoSangre);
			Controls.Add(dtpFechaNacimiento);
			Controls.Add(cmbGenero);
			Controls.Add(lblGenero);
			Controls.Add(txtCalle);
			Controls.Add(txtColonia);
			Controls.Add(txtLocalidad);
			Controls.Add(txtCodigoPostal);
			Controls.Add(txtMunicipio);
			Controls.Add(txtCorreoElectronico);
			Controls.Add(txtTelefono);
			Controls.Add(txtEdad);
			Controls.Add(txtApellidoMaterno);
			Controls.Add(txtApellidoPaterno);
			Controls.Add(lblCalle);
			Controls.Add(lblColonia);
			Controls.Add(lblLocalidad);
			Controls.Add(lblCodigoPostal);
			Controls.Add(lblMunicipio);
			Controls.Add(lblTipoSangre);
			Controls.Add(lblCorreoElectronico);
			Controls.Add(lblTelefono);
			Controls.Add(lblFechaNacimiento);
			Controls.Add(lblEdad);
			Controls.Add(lblApellidoMaterno);
			Controls.Add(lblApellidoPaterno);
			Controls.Add(lblNombre);
			Controls.Add(lblRegistroPacientes);
			Controls.Add(txtNombre);
			Name = "frmRegistroPacientes";
			Text = "frmRegistroPacientes";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtNombre;
		private Label lblRegistroPacientes;
		private Label lblNombre;
		private Label lblApellidoPaterno;
		private Label lblApellidoMaterno;
		private Label lblEdad;
		private Label lblFechaNacimiento;
		private Label lblTelefono;
		private Label lblCorreoElectronico;
		private Label lblTipoSangre;
		private Label lblMunicipio;
		private Label lblCodigoPostal;
		private Label lblLocalidad;
		private Label lblColonia;
		private Label lblCalle;
		private TextBox txtApellidoPaterno;
		private TextBox txtApellidoMaterno;
		private TextBox txtEdad;
		private TextBox txtTelefono;
		private TextBox txtCorreoElectronico;
		private TextBox txtMunicipio;
		private TextBox txtCodigoPostal;
		private TextBox txtLocalidad;
		private TextBox txtColonia;
		private TextBox txtCalle;
		private Label lblGenero;
		private ComboBox cmbGenero;
		private DateTimePicker dtpFechaNacimiento;
		private ComboBox txtTipoSangre;
		private Button btnGuardar;
		private Button btnCancelar;
	}
}