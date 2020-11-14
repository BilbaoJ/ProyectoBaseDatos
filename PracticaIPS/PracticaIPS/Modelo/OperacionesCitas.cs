using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaIPS
{
    class OperacionesCitas
    {
        public static int guardarCita(string medico, string paciente, string fecha) {

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);

                sqlConnection.Open();

                string query = @"INSERT INTO tbCitas (CedulaMedico, IdentificacionPaciente, FechaCita) " +
                    "VALUES (@cedulaMedico, @identificacionPaciente, @fechaCita);";

                SqlCommand command = new SqlCommand(query, sqlConnection);

                string queryMulta = "SELECT Multas FROM tbPacientes WHERE '" + paciente + "' = Identificacion;";

                SqlCommand commandMulta = new SqlCommand(queryMulta, sqlConnection);

                if(commandMulta.ExecuteScalar() != DBNull.Value) { 
                
                    double multas = Convert.ToDouble(commandMulta.ExecuteScalar());

                    if (multas > 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                string queryCitas = "SELECT CitasPendientes FROM vistaCitasPendientes WHERE '" + paciente + "' = IdentificacionPaciente;";

                SqlCommand commandCitas = new SqlCommand(queryCitas, sqlConnection);

                int citasPendientes = Convert.ToInt32(commandCitas.ExecuteScalar());

                if (citasPendientes == 1)
                {
                    string queryTipoCita = "SELECT Especialidad FROM vistaTipoCitas WHERE '" + paciente + "' = IdentificacionPaciente;";

                    SqlCommand commandTipoCita = new SqlCommand(queryTipoCita, sqlConnection);

                    string tipoCita = Convert.ToString(commandTipoCita.ExecuteScalar());

                    string queryMedico = "SELECT Especialidad FROM tbMedicos WHERE '" + medico + "' = Cedula;";

                    SqlCommand commandMedico = new SqlCommand(queryMedico, sqlConnection);

                    string EspecialidadMedico = Convert.ToString(commandMedico.ExecuteScalar());

                    if (tipoCita == EspecialidadMedico)
                    {
                        throw new DuplicateNameException();
                    }
                }
                else if (citasPendientes == 2)
                {
                    throw new InvalidOperationException();
                }
                
                
                command.Parameters.AddWithValue("@cedulaMedico", medico);
                command.Parameters.AddWithValue("@identificacionPaciente", paciente);
                command.Parameters.AddWithValue("@fechaCita", Convert.ToDateTime(fecha));
                command.ExecuteNonQuery();

                sqlConnection.Close();

                return 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 1;
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                return 2;
            }
            catch(DuplicateNameException ex)
            {
                return 3;
            }
            catch (InvalidOperationException ex)
            {
                return 4;
            }

        }

        public static DataTable mostrarCitasIncumplidas()
        {
            DataTable dtCitasIncumplidas = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);


            sqlConnection.Open();

            string sql = "SELECT CedulaMedico, IdentificacionPaciente, FechaCita FROM tbCitas WHERE CitaIncumplida = '0';";

            SqlDataAdapter adaptador = new SqlDataAdapter(sql, sqlConnection);

            adaptador.Fill(dtCitasIncumplidas);
            sqlConnection.Close();



            return dtCitasIncumplidas;
        }

        public static DataTable mostrarCitas()
        {
            DataTable dtCitasIncumplidas = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);


            sqlConnection.Open();

            string sql = "SELECT CedulaMedico, IdentificacionPaciente, FechaCita FROM tbCitas;";

            SqlDataAdapter adaptador = new SqlDataAdapter(sql, sqlConnection);

            adaptador.Fill(dtCitasIncumplidas);
            sqlConnection.Close();

            return dtCitasIncumplidas;
        }

        public static DataTable mostrarCitasDePaciente(string identificacion)
        {
            DataTable dtCitasPacientes = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);


            sqlConnection.Open();

            string sql = "SELECT CedulaMedico, IdentificacionPaciente, FechaCita FROM tbCitas " +
                "WHERE IdentificacionPaciente = '"+ identificacion +"';";

            SqlDataAdapter adaptador = new SqlDataAdapter(sql, sqlConnection);

            adaptador.Fill(dtCitasPacientes);
            sqlConnection.Close();

            return dtCitasPacientes;
        }

        public static bool confirmarCita(string cedula, string identificacion)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);

                sqlConnection.Open();

                string query = @"UPDATE tbCitas SET CitaIncumplida = 1 WHERE CedulaMedico = @cedula AND 
                                IdentificacionPaciente = @identificacion;";

                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@cedula", cedula);
                command.Parameters.AddWithValue("@identificacion", identificacion);

                command.ExecuteNonQuery();
                sqlConnection.Close();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
    }
}
