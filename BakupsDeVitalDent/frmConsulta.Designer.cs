namespace BakupsDeVitalDent
{
	partial class frmConsulta
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
			pcbLupa = new PictureBox();
			btnBuscar = new Button();
			txtBuscarPacientes = new TextBox();
			lblConsulta = new Label();
			dgvPacientes = new DataGridView();
			this.btnSiguiente = new Button();
			btnAnterior = new Button();
			((System.ComponentModel.ISupportInitialize)pcbLupa).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
			SuspendLayout();
			// 
			// pcbLupa
			// 
			pcbLupa.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
			pcbLupa.Location = new Point(163, 69);
			pcbLupa.Name = "pcbLupa";
			pcbLupa.Size = new Size(24, 25);
			pcbLupa.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbLupa.TabIndex = 45;
			pcbLupa.TabStop = false;
			// 
			// btnBuscar
			// 
			btnBuscar.BackColor = Color.FromArgb(244, 249, 252);
			btnBuscar.Location = new Point(916, 64);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(150, 30);
			btnBuscar.TabIndex = 44;
			btnBuscar.Text = "Buscar";
			btnBuscar.UseVisualStyleBackColor = false;
			// 
			// txtBuscarPacientes
			// 
			txtBuscarPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBuscarPacientes.Location = new Point(193, 69);
			txtBuscarPacientes.Multiline = true;
			txtBuscarPacientes.Name = "txtBuscarPacientes";
			txtBuscarPacientes.PlaceholderText = "Buscar Paciente";
			txtBuscarPacientes.Size = new Size(717, 25);
			txtBuscarPacientes.TabIndex = 43;
			// 
			// lblConsulta
			// 
			lblConsulta.AutoSize = true;
			lblConsulta.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblConsulta.Location = new Point(12, 9);
			lblConsulta.Name = "lblConsulta";
			lblConsulta.Size = new Size(99, 30);
			lblConsulta.TabIndex = 46;
			lblConsulta.Text = "Consulta";
			// 
			// dgvPacientes
			// 
			dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPacientes.Location = new Point(267, 122);
			dgvPacientes.Name = "dgvPacientes";
			dgvPacientes.Size = new Size(670, 380);
			dgvPacientes.TabIndex = 47;
			// 
			// btnSiguiente
			// 
			this.btnSiguiente.BackColor = Color.FromArgb(244, 249, 252);
			this.btnSiguiente.Location = new Point(787, 520);
			this.btnSiguiente.Name = "btnSiguiente";
			this.btnSiguiente.Size = new Size(150, 30);
			this.btnSiguiente.TabIndex = 52;
			this.btnSiguiente.Text = "Siguiente";
			this.btnSiguiente.UseVisualStyleBackColor = false;
			// 
			// btnAnterior
			// 
			btnAnterior.BackColor = Color.FromArgb(244, 249, 252);
			btnAnterior.Location = new Point(631, 520);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(150, 30);
			btnAnterior.TabIndex = 51;
			btnAnterior.Text = "Anterior";
			btnAnterior.UseVisualStyleBackColor = false;
			// 
			// frmConsulta
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1195, 612);
			Controls.Add(this.btnSiguiente);
			Controls.Add(btnAnterior);
			Controls.Add(dgvPacientes);
			Controls.Add(lblConsulta);
			Controls.Add(pcbLupa);
			Controls.Add(btnBuscar);
			Controls.Add(txtBuscarPacientes);
			Name = "frmConsulta";
			Text = "frmConsulta";
			((System.ComponentModel.ISupportInitialize)pcbLupa).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pcbLupa;
		private Button btnBuscar;
		private TextBox txtBuscarPacientes;
		private Label lblConsulta;
		private DataGridView dgvPacientes;
		private Button btnSiguiente;
		private Button btnAnterior;
	}
}