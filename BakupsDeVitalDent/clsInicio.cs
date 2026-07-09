using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BakupsDeVitalDent
{
    internal class clsInicio
    {
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;
        public DataTable cargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    //Unimos las 4 tablas mediante INNER JOIN para mostrar descripciones claras en el Grid
                    string sql = "SELECT paciente AS ID_PACIENTE, " +
                                 "I.nombrePaciente AS NOMBRE, " +
                                 "I.ApellidoPaterno AS APELLIDO_PARTENO, " +
                                 "I.ApellidoMaterno AS APELLIDO_PARTENO, " +
                                 "I.Telefono AS TELEFONO, " +
                                 "I.Fecha AS FECHA, " +
                                 
                                 "FROM tblcitas D " +
                                 "INNER JOIN tblpacienteI ON D.ID_PACIENTE = U.intID_PACIENTE;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {

                        using (consulta = new MySqlDataAdapter(sql, conexion))
                        {
                            consulta.Fill(tabla);
                        }//liberar la consulta
                    }//Liberar la consulta
                }//liberar la conexion externa automaticamente
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexión al cargar catálogo de recientes: " + ex.Message);
            }
            return tabla;
        }
    }
}
