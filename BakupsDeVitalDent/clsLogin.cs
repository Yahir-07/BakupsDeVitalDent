using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakupsDeVitalDent
{
    internal class clsLogin
    {
        // Propiedades de acceso
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public static bool EsDoctor { get => esDoctor; set => esDoctor = value; }
        public static bool EsSecretaria { get => esSecretaria; set => esSecretaria = value; }


        // Información del usuario que inició sesión
        public static int IdTrabajador;
        public static string NombreTrabajador;
        public static string Perfil;

        // Permisos
        private static bool esDoctor;
        private static bool esSecretaria;



        // Asignar permisos según el perfil
        private void AsignarPermisos()
        {
            switch (Perfil)
            {
                case "Doctor":
                    EsDoctor = true;
                    EsSecretaria = false;
                    break;

                case "Secretaria":
                    EsDoctor = false;
                    EsSecretaria = true;
                    break;

                default:
                    EsDoctor = false;
                    EsSecretaria = false;
                    break;
            }
        }

        // Validar acceso
        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"
                    SELECT

                    T.ID_TRABAJADOR,

                    CONCAT(
                        T.NOMBRE,' ',
                        T.APELLIDO_PATERNO,' ',
                        T.APELLIDO_MATERNO
                    ) AS NOMBRE_COMPLETO,

                    CASE
                        WHEN D.ID_DOCTOR IS NOT NULL
                        THEN 'Doctor'
                        ELSE 'Secretaria'
                    END AS PERFIL

                    FROM TRABAJADOR T

                    INNER JOIN EMPLEADO E
                        ON T.ID_TRABAJADOR = E.ID_TRABAJADOR

                    LEFT JOIN DOCTOR D
                        ON E.ID_EMPLEADO = D.ID_EMPLEADO

                    WHERE

                    T.CORREO_ELECTRONICO = @usuario

                    AND

                    T.PASSWORD = @password;";

                    using (MySqlCommand consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", Usuario);
                        consulta.Parameters.AddWithValue("@password", Password);

                        using (MySqlDataReader resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                // Guardar datos del usuario
                                IdTrabajador = Convert.ToInt32(resultado["ID_TRABAJADOR"]);
                                NombreTrabajador = resultado["NOMBRE_COMPLETO"].ToString();
                                Perfil = resultado["PERFIL"].ToString();

                                // Asignar permisos
                                AsignarPermisos();

                                MessageBox.Show(
                                    $"Bienvenido {NombreTrabajador}\n\nPerfil: {Perfil}",
                                    "VitalDent",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                return true;
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Correo o contraseña incorrectos.",
                                    "VitalDent",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
