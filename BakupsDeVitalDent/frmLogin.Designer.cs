namespace BakupsDeVitalDent
{
	partial class frmLogin
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
			ptbLogo = new PictureBox();
			txtNombreUsuario = new TextBox();
			txtContrasena = new TextBox();
			lblUsuario = new Label();
			lblPassword = new Label();
			btnMostrarContrasena = new Button();
			btnSalir = new Button();
			btnIniciarSesion = new Button();
			lblContrasena = new Label();
			((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
			SuspendLayout();
			// 
			// ptbLogo
			// 
			ptbLogo.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_9_46_14_PM;
			ptbLogo.Location = new Point(293, 43);
			ptbLogo.Name = "ptbLogo";
			ptbLogo.Size = new Size(255, 215);
			ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			ptbLogo.TabIndex = 0;
			ptbLogo.TabStop = false;
			// 
			// txtNombreUsuario
			// 
			txtNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtNombreUsuario.Location = new Point(306, 264);
			txtNombreUsuario.Multiline = true;
			txtNombreUsuario.Name = "txtNombreUsuario";
			txtNombreUsuario.PlaceholderText = "Nombre del trabajador";
			txtNombreUsuario.Size = new Size(260, 28);
			txtNombreUsuario.TabIndex = 1;
			// 
			// txtContrasena
			// 
			txtContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtContrasena.Location = new Point(306, 319);
			txtContrasena.Name = "txtContrasena";
			txtContrasena.PlaceholderText = "Contraseña";
			txtContrasena.ShortcutsEnabled = false;
			txtContrasena.Size = new Size(260, 29);
			txtContrasena.TabIndex = 2;
			txtContrasena.UseSystemPasswordChar = true;
			// 
			// lblUsuario
			// 
			lblUsuario.AutoSize = true;
			lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblUsuario.Location = new Point(220, 274);
			lblUsuario.Name = "lblUsuario";
			lblUsuario.Size = new Size(69, 21);
			lblUsuario.TabIndex = 3;
			lblUsuario.Text = "Usuario";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblPassword.Location = new Point(193, 327);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(96, 21);
			lblPassword.TabIndex = 4;
			lblPassword.Text = "Contraseña";
			// 
			// btnMostrarContrasena
			// 
			btnMostrarContrasena.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_16_PM;
			btnMostrarContrasena.BackgroundImageLayout = ImageLayout.Stretch;
			btnMostrarContrasena.Location = new Point(572, 317);
			btnMostrarContrasena.Name = "btnMostrarContrasena";
			btnMostrarContrasena.Size = new Size(33, 31);
			btnMostrarContrasena.TabIndex = 5;
			btnMostrarContrasena.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			btnSalir.BackColor = Color.FromArgb(255, 205, 210);
			btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnSalir.Location = new Point(419, 398);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(150, 35);
			btnSalir.TabIndex = 54;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = false;
			// 
			// btnIniciarSesion
			// 
			btnIniciarSesion.BackColor = Color.FromArgb(244, 249, 252);
			btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnIniciarSesion.Location = new Point(263, 398);
			btnIniciarSesion.Name = "btnIniciarSesion";
			btnIniciarSesion.Size = new Size(150, 35);
			btnIniciarSesion.TabIndex = 53;
			btnIniciarSesion.Text = "Iniciar Sesión";
			btnIniciarSesion.UseVisualStyleBackColor = false;
			// 
			// lblContrasena
			// 
			lblContrasena.AutoSize = true;
			lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblContrasena.Location = new Point(203, 327);
			lblContrasena.Name = "lblContrasena";
			lblContrasena.Size = new Size(86, 21);
			lblContrasena.TabIndex = 55;
			lblContrasena.Text = "Cotraseña";
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 249, 252);
			ClientSize = new Size(569, 415);
			Controls.Add(lblContrasena);
			Controls.Add(btnSalir);
			Controls.Add(btnIniciarSesion);
			Controls.Add(btnMostrarContrasena);
			Controls.Add(lblUsuario);
			Controls.Add(txtContrasena);
			Controls.Add(txtNombreUsuario);
			Controls.Add(ptbLogo);
			Name = "frmLogin";
			Text = "frmLogin";
			((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox ptbLogo;
		private TextBox txtNombreUsuario;
		private TextBox txtContrasena;
		private Label lblUsuario;
		private Label lblPassword;
		private Button btnMostrarContrasena;
		private Button btnSalir;
		private Button btnIniciarSesion;
		private Label lblContrasena;
	}
}