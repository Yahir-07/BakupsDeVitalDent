using System.Security.Principal;

namespace BakupsDeVitalDent
{
    public partial class frmPrincipal : Form
    {
        clsPrincipal Principal;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGeneral_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Location = new Point(btn.Location.X + 3, btn.Location.Y + 3);
        }

        private void btnGeneral_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Location = new Point(btn.Location.X - 3, btn.Location.Y - 3);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            btnInicio.Parent = pcbMenu;
            btnRegistroPacientes.Parent = pcbMenu;
            btnAgendaCitas.Parent = pcbMenu;
            btnConsulta.Parent = pcbMenu;
            btnHistorialMedico.Parent = pcbMenu;
            btnInicio.BackColor = Color.Transparent;
            btnRegistroPacientes.BackColor = Color.Transparent;
            btnAgendaCitas.BackColor = Color.Transparent;
            btnConsulta.BackColor = Color.Transparent;
            btnHistorialMedico.BackColor = Color.Transparent;

            btnInicio.Enabled = clsLogin.EsDoctor;
            btnRegistroPacientes.Enabled = clsLogin.EsDoctor;
            btnAgendaCitas.Enabled = clsLogin.EsDoctor;
            btnConsulta.Enabled = clsLogin.EsDoctor;
            btnHistorialMedico.Enabled = clsLogin.EsDoctor;

            btnInicio.Enabled = clsLogin.EsDoctor || clsLogin.EsSecretaria;
            btnRegistroPacientes.Enabled = clsLogin.EsDoctor || clsLogin.EsSecretaria;
            btnAgendaCitas.Enabled = clsLogin.EsDoctor || clsLogin.EsSecretaria;

            // Cargar el formulario Inicio al abrir frmPrincipal
            Principal = new clsPrincipal();
            Principal.agregarAlContenedor(new frmInicio(), pnlContenido);

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal = new clsPrincipal();
            Principal.agregarAlContenedor(new frmInicio(), pnlContenido);
        }

        private void btnRegistroPacientes_Click(object sender, EventArgs e)
        {
            Principal = new clsPrincipal();
            Principal.agregarAlContenedor(new frmRegistroPacientes(), pnlContenido);
        }

        private void btnAgendaCitas_Click(object sender, EventArgs e)
        {
            Principal = new clsPrincipal();
            Principal.agregarAlContenedor(new frmAgendaCitas(), pnlContenido);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Principal = new clsPrincipal();
            Principal.agregarAlContenedor(new frmConsulta(), pnlContenido);
        }

        private void btnHistorialMedico_Click(object sender, EventArgs e)
        {
            Principal = new clsPrincipal();
            Principal.agregarAlContenedor(new frmHistorialMedico(), pnlContenido);
        }

        private void btnSalir_Sistema_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show($"¿Seguro que quieres salir del sistema? ", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
