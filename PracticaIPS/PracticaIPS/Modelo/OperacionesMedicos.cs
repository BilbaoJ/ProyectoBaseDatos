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
    public class OperacionesMedicos
    {
        public static bool registrarMedico(string cedula, string nombre, string apellido,
            string especialidad, double salarioCita, string añosExperiencia)
        {

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);

                sqlConnection.Open();

                string query = @"INSERT INTO tbMedicos (Cedula, Nombre, Apellido, Especialidad, SalarioCita, AñosExperiencia) " +
                    "VALUES (@cedula, @nombre, @apellido, @especialidad, @salarioCita, @añosExperiencia);";

                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@cedula", cedula);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@especialidad", especialidad);
                command.Parameters.AddWithValue("@salarioCita", salarioCita);
                command.Parameters.AddWithValue("@añosExperiencia", añosExperiencia);
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
            DataTable dtMedicos = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);


            sqlConnection.Open();

            string sql = "SELECT Cedula, Nombre, Apellido, Especialidad, SalarioCita, AñosExperiencia FROM tbMedicos;";

            SqlDataAdapter adaptador = new SqlDataAdapter(sql, sqlConnection);

            adaptador.Fill(dtMedicos);
            sqlConnection.Close();



            return dtMedicos;
        }

        public static bool editar(string cedula, string nombre, string apellido, double salario)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Conexion.conexion);

                sqlConnection.Open();

                string query = @"UPDATE tbMedicos SET Nombre = @nombre, Apellido = @apellido, SalarioCita = @salarioCita
                                WHERE Cedula = @cedula;";


                SqlCommand command = new SqlCommand(query, sqlConnection);

                command.Parameters.AddWithValue("@cedula", cedula);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@salarioCita", salario);

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
