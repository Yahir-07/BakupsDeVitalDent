namespace BakupsDeVitalDent
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Mostrar primero el login como ventana modal
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, correr el principal
                    Application.Run(new frmPrincipal());
                }
                
                }
        }
    }
}