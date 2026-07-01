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
			pictureBox1 = new PictureBox();
			button1 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			dataGridView1 = new DataGridView();
			button2 = new Button();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_06_23_at_2_04_17_PM__1_;
			pictureBox1.Location = new Point(163, 69);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(24, 25);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 45;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(244, 249, 252);
			button1.Location = new Point(916, 64);
			button1.Name = "button1";
			button1.Size = new Size(150, 30);
			button1.TabIndex = 44;
			button1.Text = "Buscar";
			button1.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(193, 69);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "Buscar Paciente";
			textBox1.Size = new Size(717, 25);
			textBox1.TabIndex = 43;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(99, 30);
			label1.TabIndex = 46;
			label1.Text = "Consulta";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(267, 122);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(670, 380);
			dataGridView1.TabIndex = 47;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(244, 249, 252);
			button2.Location = new Point(787, 520);
			button2.Name = "button2";
			button2.Size = new Size(150, 30);
			button2.TabIndex = 52;
			button2.Text = "Siguiente";
			button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(244, 249, 252);
			button3.Location = new Point(631, 520);
			button3.Name = "button3";
			button3.Size = new Size(150, 30);
			button3.TabIndex = 51;
			button3.Text = "Anterior";
			button3.UseVisualStyleBackColor = false;
			// 
			// frmConsulta
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1195, 612);
			Controls.Add(button2);
			Controls.Add(button3);
			Controls.Add(dataGridView1);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "frmConsulta";
			Text = "frmConsulta";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Button button1;
		private TextBox textBox1;
		private Label label1;
		private DataGridView dataGridView1;
		private Button button2;
		private Button button3;
	}
}