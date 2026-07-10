namespace BakupsDeVitalDent
{
    partial class frmInicio
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
            lblBienvenido = new Label();
            dgvRecientes = new DataGridView();
            btnNuevoPaciente = new Button();
            btnEliminarPaciente = new Button();
            button2 = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(29, 27);
            lblBienvenido.Margin = new Padding(2, 0, 2, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(301, 32);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenidos a Vital Dent";
            // 
            // dgvRecientes
            // 
            dgvRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecientes.Location = new Point(145, 93);
            dgvRecientes.Margin = new Padding(2);
            dgvRecientes.Name = "dgvRecientes";
            dgvRecientes.RowHeadersWidth = 62;
            dgvRecientes.Size = new Size(1062, 454);
            dgvRecientes.TabIndex = 1;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.BackColor = Color.FromArgb(244, 249, 252);
            btnNuevoPaciente.Location = new Point(805, 552);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(200, 45);
            btnNuevoPaciente.TabIndex = 45;
            btnNuevoPaciente.Text = "Nuevo Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.BackColor = Color.FromArgb(255, 205, 210);
            btnEliminarPaciente.Location = new Point(1011, 552);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(200, 45);
            btnEliminarPaciente.TabIndex = 46;
            btnEliminarPaciente.Text = "Eliminar Paciente";
            btnEliminarPaciente.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 249, 252);
            button2.Location = new Point(599, 552);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 47;
            button2.Text = "Modificar Paciente";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(244, 249, 252);
            btnActualizar.Location = new Point(393, 552);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(200, 45);
            btnActualizar.TabIndex = 48;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1315, 627);
            Controls.Add(btnActualizar);
            Controls.Add(button2);
            Controls.Add(btnEliminarPaciente);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(dgvRecientes);
            Controls.Add(lblBienvenido);
            Margin = new Padding(2);
            Name = "frmInicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)dgvRecientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private DataGridView dgvRecientes;
        private Button btnNuevoPaciente;
        private Button btnEliminarPaciente;
        private Button button2;
        private Button btnActualizar;
    }
}