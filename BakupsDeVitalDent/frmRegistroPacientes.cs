using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakupsDeVitalDent
{
    public partial class frmRegistroPacientes : Form
    {
        public frmRegistroPacientes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Clear();

            txtApellidoPaterno.Clear();

            txtApellidoMaterno.Clear();

            txtTelefono.Clear();

            txtCorreoElectronico.Clear();

            txtAlergia.Clear();

            txtEstado.Clear();

            txtMunicipio.Clear();

            txtLocalidad.Clear();

            txtColonia.Clear();

            txtCalle.Clear();

            txtCodigoPostal.Clear();

            cmbGenero.SelectedIndex = -1;

            cmbTipoSangre.SelectedIndex = -1;

            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Primero validamos los campos obligatorios
            if (!ValidarCampos())
                return; // Si faltan campos, se detiene aquí

            clsRegistroPacientes paciente = new clsRegistroPacientes();

            paciente.Nombre1 = txtNombre.Text;
            paciente.ApellidoPaterno1 = txtApellidoPaterno.Text;
            paciente.ApellidoMaterno1 = txtApellidoMaterno.Text;

            paciente.FechaNacimiento1 = dtpFechaNacimiento.Value;

            paciente.Genero1 = cmbGenero.Text;

            paciente.Telefono1 = txtTelefono.Text;

            paciente.Correo1 = txtCorreoElectronico.Text;

            paciente.TipoSangre1 = cmbTipoSangre.Text;

            paciente.Alergias1 = txtAlergia.Text;

            paciente.Estado1 = txtEstado.Text;

            paciente.Municipio1 = txtMunicipio.Text;

            paciente.Localidad1 = txtLocalidad.Text;

            paciente.Colonia1 = txtColonia.Text;

            paciente.Calle1 = txtCalle.Text;

            paciente.CodigoPostal1 = txtCodigoPostal.Text;

            if (paciente.GuardarPaciente())
            {
                MessageBox.Show("Paciente registrado correctamente.");

                Limpiar();
            }
        }
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = CalcularEdad(dtpFechaNacimiento.Value).ToString();
        }

        private void frmRegistroPacientes_Load(object sender, EventArgs e)
        {
            txtEdad.Text = CalcularEdad(dtpFechaNacimiento.Value).ToString();
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtNombre, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtApellidoPaterno.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtApellidoPaterno, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtApellidoPaterno, "");
            }
        }

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtApellidoMaterno.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtApellidoMaterno, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtApellidoMaterno, "");
            }
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (!long.TryParse(txtTelefono.Text, out _))
            {
                errorProvider1.SetError(txtTelefono, "Solo números.");
                e.Cancel = true;
            }
            else if (txtTelefono.Text.Length != 10)
            {
                errorProvider1.SetError(txtTelefono, "El teléfono debe tener exactamente 10 dígitos.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
            }
        }

        private void txtAlergia_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAlergia.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtAlergia, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAlergia, "");
            }
        }

        private void txtEstado_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEstado.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtEstado, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEstado, "");
            }
        }

        private void txtMunicipio_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtMunicipio.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtMunicipio, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMunicipio, "");
            }
        }

        private void txtCodigoPostal_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtCodigoPostal.Text, out _))
            {
                errorProvider1.SetError(txtCodigoPostal, "Solo números.");
                e.Cancel = true;
            }
            else if (txtCodigoPostal.Text.Length != 5)
            {
                errorProvider1.SetError(txtCodigoPostal, "El código debe tener exactamente 5 dígitos.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCodigoPostal, "");
            }
        }

        private void txtLocalidad_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLocalidad.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtLocalidad, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLocalidad, "");
            }
        }

        private void txtColonia_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtColonia.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtColonia, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtColonia, "");
            }
        }

        private void txtCalle_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCalle.Text, @"^[\p{L}\s]+$"))
            {
                errorProvider1.SetError(txtCalle, "Solo se permiten letras (incluye acentos y ñ).");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCalle, "");
            }
        }

        private bool ValidarCampos()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                camposFaltantes.Add("Nombre");

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
                camposFaltantes.Add("Apellido Paterno");

            if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
                camposFaltantes.Add("Apellido Materno");

            if (cmbGenero.SelectedIndex == -1)
                camposFaltantes.Add("Género");

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                camposFaltantes.Add("Teléfono");

            if (cmbTipoSangre.SelectedIndex == -1)
                camposFaltantes.Add("Tipo de sangre");

            if (string.IsNullOrWhiteSpace(txtAlergia.Text))
                camposFaltantes.Add("Alergia");

            if (string.IsNullOrWhiteSpace(txtEstado.Text))
                camposFaltantes.Add("Estado");

            if (string.IsNullOrWhiteSpace(txtMunicipio.Text))
                camposFaltantes.Add("Municipio");

            if (string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
                camposFaltantes.Add("Código Postal");

            if (string.IsNullOrWhiteSpace(txtLocalidad.Text))
                camposFaltantes.Add("Localidad");

            if (string.IsNullOrWhiteSpace(txtColonia.Text))
                camposFaltantes.Add("Colonia");

            if (camposFaltantes.Count > 0)
            {
                string mensaje = "Faltan campos por rellenar:\n- " + string.Join("\n- ", camposFaltantes);
                MessageBox.Show(mensaje, "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Limpiar todos los campos? ", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al limpiar el registro: " + ex.Message,
                                    "Error Operacional", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
