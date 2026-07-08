using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakupsDeVitalDent
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
                {
                    MessageBox.Show("Ingrese el correo electrónico.",
                                    "VitalDent",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtNombreUsuario.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show("Ingrese la contraseña.",
                                    "VitalDent",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtContrasena.Focus();
                    return;
                }

                clsLogin login = new clsLogin();

                login.Usuario = txtNombreUsuario.Text.Trim();
                login.Password = txtContrasena.Text;

                if (login.ValidarAcceso())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
