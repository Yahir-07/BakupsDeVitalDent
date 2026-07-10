using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace BakupsDeVitalDent
{
    internal class clsRegistroPacientes
    {
        string Nombre;
        string ApellidoPaterno;
        string ApellidoMaterno;
        DateTime FechaNacimiento;
        string Genero;
        string Telefono;
        string Correo;
        string TipoSangre;
        string Alergias;
        string Estado;
        string Municipio;
        string Localidad;
        string Colonia;
        string Calle;
        string CodigoPostal;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string ApellidoPaterno1 { get => ApellidoPaterno; set => ApellidoPaterno = value; }
        public string ApellidoMaterno1 { get => ApellidoMaterno; set => ApellidoMaterno = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string TipoSangre1 { get => TipoSangre; set => TipoSangre = value; }
        public string Alergias1 { get => Alergias; set => Alergias = value; }
        public string Estado1 { get => Estado; set => Estado = value;  }
        public string Municipio1 { get => Municipio; set => Municipio = value; }
        public string Localidad1 { get => Localidad; set => Localidad = value; }
        public string Colonia1 { get => Colonia; set => Colonia = value; }
        public string Calle1 { get => Calle; set => Calle = value; }
        public string CodigoPostal1 { get => CodigoPostal; set => CodigoPostal = value; }

        public bool GuardarPaciente()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();

                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = @"INSERT INTO PACIENTE
                    (
                        NOMBRE,
                        APELLIDO_PATERNO,
                        APELLIDO_MATERNO,
                        TELEFONO,
                        CORREO_ELECTRONICO,
                        CALLE,
                        COLONIA,
                        CIUDAD,
                        ESTADO,
                        LOCALIDAD,
                        CODIGO_POSTAL,
                        FECHA_NAC,
                        GENERO,
                        TIPO_SANGRE,
                        ALERGIAS
                    )

                    VALUES

                    (
                        @nombre,
                        @apaterno,
                        @amaterno,
                        @telefono,
                        @correo,
                        @calle,
                        @colonia,
                        @ciudad,
                        @estado,
                        @localidad,
                        @cp,
                        @fecha,
                        @genero,
                        @sangre,
                        @alergias
                    );";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);

                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@apaterno", ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@amaterno", ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.Parameters.AddWithValue("@correo", Correo);
                    cmd.Parameters.AddWithValue("@calle", Calle);
                    cmd.Parameters.AddWithValue("@colonia", Colonia);
                    cmd.Parameters.AddWithValue("@ciudad", Municipio);
                    cmd.Parameters.AddWithValue("@estado", Estado);
                    cmd.Parameters.AddWithValue("@localidad", Localidad);
                    cmd.Parameters.AddWithValue("@cp", CodigoPostal);
                    cmd.Parameters.AddWithValue("@fecha", FechaNacimiento);
                    cmd.Parameters.AddWithValue("@genero", Genero);
                    cmd.Parameters.AddWithValue("@sangre", TipoSangre);
                    cmd.Parameters.AddWithValue("@alergias", Alergias);

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }
    }
}
