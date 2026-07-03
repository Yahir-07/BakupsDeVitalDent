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
            pcbSuperior = new PictureBox();
            pcbMenu = new PictureBox();
            btnInicio = new Button();
            btnRegistroPacientes = new Button();
            btnAgendaCitas = new Button();
            btnConsulta = new Button();
            btnHistorialMedico = new Button();
            pnlContenido = new Panel();
            label1 = new Label();
            dgvRecientes = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbSuperior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).BeginInit();
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
            btnInicio.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__1_;
            btnInicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnInicio.Location = new Point(38, 199);
            btnInicio.Margin = new Padding(4, 5, 4, 5);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(150, 75);
            btnInicio.TabIndex = 2;
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnRegistroPacientes
            // 
            btnRegistroPacientes.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM;
            btnRegistroPacientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistroPacientes.Location = new Point(38, 284);
            btnRegistroPacientes.Margin = new Padding(4, 5, 4, 5);
            btnRegistroPacientes.Name = "btnRegistroPacientes";
            btnRegistroPacientes.Size = new Size(150, 75);
            btnRegistroPacientes.TabIndex = 3;
            btnRegistroPacientes.UseVisualStyleBackColor = true;
            // 
            // btnAgendaCitas
            // 
            btnAgendaCitas.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__2_;
            btnAgendaCitas.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgendaCitas.Location = new Point(38, 369);
            btnAgendaCitas.Margin = new Padding(4, 5, 4, 5);
            btnAgendaCitas.Name = "btnAgendaCitas";
            btnAgendaCitas.Size = new Size(150, 75);
            btnAgendaCitas.TabIndex = 4;
            btnAgendaCitas.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            btnConsulta.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__4_;
            btnConsulta.BackgroundImageLayout = ImageLayout.Stretch;
            btnConsulta.Location = new Point(38, 454);
            btnConsulta.Margin = new Padding(4, 5, 4, 5);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(150, 75);
            btnConsulta.TabIndex = 5;
            btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnHistorialMedico
            // 
            btnHistorialMedico.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_54_PM__3_;
            btnHistorialMedico.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistorialMedico.Location = new Point(38, 539);
            btnHistorialMedico.Margin = new Padding(4, 5, 4, 5);
            btnHistorialMedico.Name = "btnHistorialMedico";
            btnHistorialMedico.Size = new Size(150, 75);
            btnHistorialMedico.TabIndex = 6;
            btnHistorialMedico.UseVisualStyleBackColor = true;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.White;
            pnlContenido.Controls.Add(label1);
            pnlContenido.Controls.Add(dgvRecientes);
            pnlContenido.Location = new Point(229, 168);
            pnlContenido.Margin = new Padding(4, 5, 4, 5);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1666, 857);
            pnlContenido.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 55);
            label1.Name = "label1";
            label1.Size = new Size(361, 38);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos a Vital Dent";
            label1.Click += label1_Click;
            // 
            // dgvRecientes
            // 
            dgvRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecientes.Location = new Point(132, 116);
            dgvRecientes.Name = "dgvRecientes";
            dgvRecientes.RowHeadersWidth = 62;
            dgvRecientes.Size = new Size(1420, 630);
            dgvRecientes.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = Properties.Resources.Group_59;
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.Location = new Point(38, 822);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 75);
            btnSalir.TabIndex = 8;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmInicio
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
            Name = "frmInicio";
            Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)pcbSuperior).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).EndInit();
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
        private DataGridView dgvRecientes;
        private Label label1;
    }
}
