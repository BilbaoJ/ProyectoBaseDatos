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
    class OperacionesPacientes
    {
        public static bool registrarPaciente(string identificacion, string nombre, string apellido,
            string fhNacimiento, string direccion, string telefono, string email, string fhRegistro)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);

                sqlConnection.Open();

                string query = @"INSERT INTO tbPacientes (Identificacion, Nombre, Apellido, FhNacimiento, Direccion, Telefono, Email, FhRegistro) " +
                    "VALUES (@identificacion, @nombre, @apellido, @fhNacimiento, @direccion, @telefono, @email, @fhRegistro);";

                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@identificacion", identificacion);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@fhNacimiento", Convert.ToDateTime(fhNacimiento));
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@fhRegistro", Convert.ToDateTime(fhRegistro));
                command.ExecuteNonQuery();

                sqlConnection.Close();

                return true;

            }
            catch (SqlException ex)
            {
                return false;

            }
        }

        public static DataTable mostrar()
        {
            DataTable dtPacientes = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);


            sqlConnection.Open();

            string sql = "SELECT P.Identificacion, P.Nombre, P.Apellido, P.FhNacimiento, P.Direccion, P.Telefono, P.Email, P.FhRegistro FROM tbPacientes AS P;";

            SqlDataAdapter adaptador = new SqlDataAdapter(sql, sqlConnection);

            adaptador.Fill(dtPacientes);
            sqlConnection.Close();

            return dtPacientes;
        }

        public static DataTable mostrarPacientesConMultas()
        {
            DataTable dtPacientes = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);


            sqlConnection.Open();

            string sql = "SELECT P.Identificacion, P.Nombre, P.Apellido, P.FhNacimiento, P.Direccion, P.Telefono, P.Email, P.FhRegistro, P.Multas FROM tbPacientes AS P WHERE P.Multas > 0 ;";

            SqlDataAdapter adaptador = new SqlDataAdapter(sql, sqlConnection);

            adaptador.Fill(dtPacientes);
            sqlConnection.Close();

            return dtPacientes;
        }

        public static bool editar(string identificacion, string email, string direccion, string telefono)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);

                sqlConnection.Open();

                string query = @"UPDATE tbPacientes SET Direccion = @direccion, Telefono = @telefono, Email = @email
                                WHERE Identificacion = @identificacion;";


                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@identificacion", identificacion);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@telefono", telefono);

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
