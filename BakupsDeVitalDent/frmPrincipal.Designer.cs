namespace BakupsDeVitalDent
{
	partial class frmPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pcbSuperior = new PictureBox();
            pcbMenu = new PictureBox();
            btnInicio = new Button();
            btnRegistroPacientes = new Button();
            btnAgendaCitas = new Button();
            btnConsulta = new Button();
            btnHistorialMedico = new Button();
            pnlContenido = new Panel();
           
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbSuperior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pcbSuperior
            // 
            pcbSuperior.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_53_PM__1_;
            pcbSuperior.BackgroundImageLayout = ImageLayout.Stretch;
            pcbSuperior.Location = new Point(-1, -2);
            pcbSuperior.Margin = new Padding(4, 5, 4, 5);
            pcbSuperior.Name = "pcbSuperior";
            pcbSuperior.Size = new Size(1896, 175);
            pcbSuperior.TabIndex = 0;
            pcbSuperior.TabStop = false;
            // 
            // pcbMenu
            // 
            pcbMenu.Image = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_53_PM;
            pcbMenu.Location = new Point(-1, 168);
            pcbMenu.Margin = new Padding(4, 5, 4, 5);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(233, 857);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 1;
            pcbMenu.TabStop = false;
            // 
            // btnInicio
            // 
            btnInicio.BackgroundImage = Properties.Resources.Group_60;
            btnInicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnInicio.Location = new Point(38, 199);
            btnInicio.Margin = new Padding(4, 5, 4, 5);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(150, 75);
            btnInicio.TabIndex = 2;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            btnInicio.MouseDown += btnGeneral_MouseDown;
            btnInicio.MouseUp += btnGeneral_MouseUp;
            // 
            // btnRegistroPacientes
            // 
            btnRegistroPacientes.BackgroundImage = Properties.Resources.Group_61;
            btnRegistroPacientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistroPacientes.Location = new Point(38, 284);
            btnRegistroPacientes.Margin = new Padding(4, 5, 4, 5);
            btnRegistroPacientes.Name = "btnRegistroPacientes";
            btnRegistroPacientes.Size = new Size(150, 75);
            btnRegistroPacientes.TabIndex = 3;
            btnRegistroPacientes.UseVisualStyleBackColor = true;
            btnRegistroPacientes.Click += btnRegistroPacientes_Click;
            btnRegistroPacientes.MouseDown += btnGeneral_MouseDown;
            btnRegistroPacientes.MouseUp += btnGeneral_MouseUp;
            // 
            // btnAgendaCitas
            // 
            btnAgendaCitas.BackgroundImage = Properties.Resources.Group_62;
            btnAgendaCitas.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgendaCitas.Location = new Point(38, 369);
            btnAgendaCitas.Margin = new Padding(4, 5, 4, 5);
            btnAgendaCitas.Name = "btnAgendaCitas";
            btnAgendaCitas.Size = new Size(150, 75);
            btnAgendaCitas.TabIndex = 4;
            btnAgendaCitas.UseVisualStyleBackColor = true;
            btnAgendaCitas.Click += btnAgendaCitas_Click;
            btnAgendaCitas.MouseDown += btnGeneral_MouseDown;
            btnAgendaCitas.MouseUp += btnGeneral_MouseUp;
            // 
            // btnConsulta
            // 
            btnConsulta.BackgroundImage = Properties.Resources.Group_64;
            btnConsulta.BackgroundImageLayout = ImageLayout.Stretch;
            btnConsulta.Location = new Point(38, 454);
            btnConsulta.Margin = new Padding(4, 5, 4, 5);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(150, 75);
            btnConsulta.TabIndex = 5;
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            btnConsulta.MouseDown += btnGeneral_MouseDown;
            btnConsulta.MouseUp += btnGeneral_MouseUp;
            // 
            // btnHistorialMedico
            // 
            btnHistorialMedico.BackgroundImage = Properties.Resources.Group_63;
            btnHistorialMedico.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistorialMedico.Location = new Point(38, 539);
            btnHistorialMedico.Margin = new Padding(4, 5, 4, 5);
            btnHistorialMedico.Name = "btnHistorialMedico";
            btnHistorialMedico.Size = new Size(150, 75);
            btnHistorialMedico.TabIndex = 6;
            btnHistorialMedico.UseVisualStyleBackColor = true;
            btnHistorialMedico.Click += btnHistorialMedico_Click;
            btnHistorialMedico.MouseDown += btnGeneral_MouseDown;
            btnHistorialMedico.MouseUp += btnGeneral_MouseUp;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Location = new Point(229, 168);
            pnlContenido.Margin = new Padding(4, 5, 4, 5);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1666, 857);
            pnlContenido.TabIndex = 7;
            // 
         
           
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = Properties.Resources.Group_65;
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.Location = new Point(38, 822);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 75);
            btnSalir.TabIndex = 8;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.MouseDown += btnGeneral_MouseDown;
            btnSalir.MouseUp += btnGeneral_MouseUp;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnSalir);
            Controls.Add(pnlContenido);
            Controls.Add(btnHistorialMedico);
            Controls.Add(btnConsulta);
            Controls.Add(btnAgendaCitas);
            Controls.Add(btnRegistroPacientes);
            Controls.Add(btnInicio);
            Controls.Add(pcbMenu);
            Controls.Add(pcbSuperior);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPrincipal";
            Text = "Principal";
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pcbSuperior).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbSuperior;
		private PictureBox pcbMenu;
		private Button btnInicio;
		private Button btnRegistroPacientes;
		private Button btnAgendaCitas;
		private Button btnConsulta;
		private Button btnHistorialMedico;
		private Panel pnlContenido;
        private Button btnSalir;
        
    }
}
