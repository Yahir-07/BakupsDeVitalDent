namespace BakupsDeVitalDent
{
	partial class frmInicio
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
			ptbSuperior = new PictureBox();
			ptbMenu = new PictureBox();
			btnInicio = new Button();
			btnRegistroPacientes = new Button();
			btnAgendaCitas = new Button();
			btnConsulta = new Button();
			btnHistorialMedico = new Button();
			pnlContenido = new Panel();
			((System.ComponentModel.ISupportInitialize)ptbSuperior).BeginInit();
			((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
			SuspendLayout();
			// 
			// ptbSuperior
			// 
			ptbSuperior.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_53_PM__1_;
			ptbSuperior.BackgroundImageLayout = ImageLayout.Stretch;
			ptbSuperior.Location = new Point(-1, -1);
			ptbSuperior.Name = "ptbSuperior";
			ptbSuperior.Size = new Size(1370, 105);
			ptbSuperior.TabIndex = 0;
			ptbSuperior.TabStop = false;
			// 
			// ptbMenu
			// 
			ptbMenu.Image = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_53_PM;
			ptbMenu.Location = new Point(-1, 101);
			ptbMenu.Name = "ptbMenu";
			ptbMenu.Size = new Size(163, 648);
			ptbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
			ptbMenu.TabIndex = 1;
			ptbMenu.TabStop = false;
			// 
			// btnInicio
			// 
			btnInicio.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__1_;
			btnInicio.BackgroundImageLayout = ImageLayout.Stretch;
			btnInicio.Location = new Point(12, 119);
			btnInicio.Name = "btnInicio";
			btnInicio.Size = new Size(123, 76);
			btnInicio.TabIndex = 2;
			btnInicio.UseVisualStyleBackColor = true;
			// 
			// btnRegistroPacientes
			// 
			btnRegistroPacientes.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM;
			btnRegistroPacientes.BackgroundImageLayout = ImageLayout.Stretch;
			btnRegistroPacientes.Location = new Point(12, 201);
			btnRegistroPacientes.Name = "btnRegistroPacientes";
			btnRegistroPacientes.Size = new Size(123, 76);
			btnRegistroPacientes.TabIndex = 3;
			btnRegistroPacientes.UseVisualStyleBackColor = true;
			// 
			// btnAgendaCitas
			// 
			btnAgendaCitas.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__2_;
			btnAgendaCitas.BackgroundImageLayout = ImageLayout.Stretch;
			btnAgendaCitas.Location = new Point(12, 283);
			btnAgendaCitas.Name = "btnAgendaCitas";
			btnAgendaCitas.Size = new Size(123, 76);
			btnAgendaCitas.TabIndex = 4;
			btnAgendaCitas.UseVisualStyleBackColor = true;
			// 
			// btnConsulta
			// 
			btnConsulta.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__4_;
			btnConsulta.BackgroundImageLayout = ImageLayout.Stretch;
			btnConsulta.Location = new Point(12, 365);
			btnConsulta.Name = "btnConsulta";
			btnConsulta.Size = new Size(123, 76);
			btnConsulta.TabIndex = 5;
			btnConsulta.UseVisualStyleBackColor = true;
			// 
			// btnHistorialMedico
			// 
			btnHistorialMedico.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__3_;
			btnHistorialMedico.BackgroundImageLayout = ImageLayout.Stretch;
			btnHistorialMedico.Location = new Point(12, 447);
			btnHistorialMedico.Name = "btnHistorialMedico";
			btnHistorialMedico.Size = new Size(123, 76);
			btnHistorialMedico.TabIndex = 6;
			btnHistorialMedico.UseVisualStyleBackColor = true;
			// 
			// pnlContenido
			// 
			pnlContenido.Location = new Point(158, 101);
			pnlContenido.Name = "pnlContenido";
			pnlContenido.Size = new Size(1211, 651);
			pnlContenido.TabIndex = 7;
			// 
			// frmInicio
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1370, 749);
			Controls.Add(pnlContenido);
			Controls.Add(btnHistorialMedico);
			Controls.Add(btnConsulta);
			Controls.Add(btnAgendaCitas);
			Controls.Add(btnRegistroPacientes);
			Controls.Add(btnInicio);
			Controls.Add(ptbMenu);
			Controls.Add(ptbSuperior);
			Name = "frmInicio";
			Text = "frmInicio";
			((System.ComponentModel.ISupportInitialize)ptbSuperior).EndInit();
			((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox ptbSuperior;
		private PictureBox ptbMenu;
		private Button btnInicio;
		private Button btnRegistroPacientes;
		private Button btnAgendaCitas;
		private Button btnConsulta;
		private Button btnHistorialMedico;
		private Panel pnlContenido;
	}
}
