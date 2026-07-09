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
            pcbLogo = new PictureBox();
            txtNombreUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblUsuario = new Label();
            lblPassword = new Label();
            btnMostrarContrasena = new Button();
            btnSalir = new Button();
            btnIniciarSesion = new Button();
            lblContrasena = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_9_46_14_PM;
            pcbLogo.Location = new Point(288, 36);
            pcbLogo.Margin = new Padding(4, 5, 4, 5);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(284, 191);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(322, 238);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "Usuario";
            txtNombreUsuario.Size = new Size(370, 39);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(322, 291);
            txtContrasena.Margin = new Padding(4, 5, 4, 5);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.ShortcutsEnabled = false;
            txtContrasena.Size = new Size(370, 39);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(186, 249);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(102, 32);
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
            btnMostrarContrasena.Location = new Point(818, 528);
            btnMostrarContrasena.Margin = new Padding(4, 5, 4, 5);
            btnMostrarContrasena.Name = "btnMostrarContrasena";
            btnMostrarContrasena.Size = new Size(48, 52);
            btnMostrarContrasena.TabIndex = 5;
            btnMostrarContrasena.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 205, 210);
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(441, 340);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 45);
            btnSalir.TabIndex = 54;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(244, 249, 252);
            btnIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(212, 340);
            btnIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(200, 45);
            btnIniciarSesion.TabIndex = 53;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(171, 298);
            lblContrasena.Margin = new Padding(4, 0, 4, 0);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(143, 32);
            lblContrasena.TabIndex = 55;
            lblContrasena.Text = "Contraseña";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblContrasena);
            Controls.Add(btnSalir);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnMostrarContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombreUsuario);
            Controls.Add(pcbLogo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = "Acceso al sistema";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
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