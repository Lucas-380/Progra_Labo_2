using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public class PersonaDAO
    {
        static string stringConnection = "Server=.;Database=EjercicioI01;Trusted_Connection=True;";

        public static void Guardar(Persona persona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string sentencia = "insert into Persona (Nombre, Apellido) values (@nombre, @apellido);";
                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                    cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al insertar una persona: " + ex.Message, ex);
            }
        }

        public static List<Persona> Leer()
        {
            try
            {
                List<Persona> personas = new List<Persona>();
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string sentencia = "SELECT * FROM Persona;";
                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        personas.Add(new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                    }
                }
                return personas;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al eliminar persona: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Persona LeerPorId(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string sentencia = "SELECT * FROM Persona WHERE ID = @id;";
                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        return new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                    throw new Exception("No existe la persona con ese ID");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al eliminar persona: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void Modificar(int id, string nombreActualizado, string apellidoActualizado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string sentencia = "update Persona set nombre = @nombre, apellido = @apellido where ID = @id";
                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nombre", nombreActualizado);
                    cmd.Parameters.AddWithValue("apellido", apellidoActualizado);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al modificar persona: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void Borrar(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string sentencia = "delete from Persona where ID = @id";
                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al eliminar persona: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
