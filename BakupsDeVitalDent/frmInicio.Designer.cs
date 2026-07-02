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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbSuperior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ptbSuperior
            // 
            ptbSuperior.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_53_PM__1_;
            ptbSuperior.BackgroundImageLayout = ImageLayout.Stretch;
            ptbSuperior.Location = new Point(-1, -2);
            ptbSuperior.Margin = new Padding(4, 5, 4, 5);
            ptbSuperior.Name = "ptbSuperior";
            ptbSuperior.Size = new Size(1896, 175);
            ptbSuperior.TabIndex = 0;
            ptbSuperior.TabStop = false;
            // 
            // ptbMenu
            // 
            ptbMenu.Image = Properties.Resources.WhatsApp_Image_2026_06_22_at_3_27_53_PM;
            ptbMenu.Location = new Point(-1, 168);
            ptbMenu.Margin = new Padding(4, 5, 4, 5);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Size = new Size(233, 857);
            ptbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMenu.TabIndex = 1;
            ptbMenu.TabStop = false;
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
            pnlContenido.Controls.Add(dataGridView1);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(132, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1421, 628);
            dataGridView1.TabIndex = 0;
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
            Controls.Add(ptbMenu);
            Controls.Add(ptbSuperior);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInicio";
            Text = "frmInicio";
            ((System.ComponentModel.ISupportInitialize)ptbSuperior).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
