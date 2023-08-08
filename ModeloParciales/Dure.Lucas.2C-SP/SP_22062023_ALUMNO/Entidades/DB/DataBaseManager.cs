using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Exceptions;
using Entidades.Interfaces;

namespace Entidades.DataBase
{
    public static class DataBaseManager
    {
        private static SqlConnection connection;
        private static string stringConnection;

        static DataBaseManager()
        {
            DataBaseManager.stringConnection = "Server=.;Database=20230622SP;Trusted_Connection=True;";
        }

        public static string GetImagenComida(string tipo)
        {
            try
            {
                using (DataBaseManager.connection = new SqlConnection(stringConnection))
                {
                    string sentencia = $"SELECT * FROM comidas WHERE tipo_comida = @tipo;";
                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    cmd.Parameters.AddWithValue("tipo", tipo);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        return reader.GetString(2);
                    }
                    throw new ComidaInvalidaExeption("El tipo de comida es inexistente");
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseManagerException($"Error al intentar leer a la base de datos", ex);
            }
        }

        public static bool GuardarTicket<T>(string nombreEmpleado, T comida) where T : IComestible, new()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string sentencia = "insert into tickets (empleado, ticket) values (@empleado, @ticket);";
                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    cmd.Parameters.AddWithValue("empleado", nombreEmpleado);
                    cmd.Parameters.AddWithValue("ticket", comida.Ticket);
                    connection.Open();
                    if(cmd.ExecuteNonQuery() > 0) 
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseManagerException($"Error al intentar Escribir en la base de datos", ex);
            }
        }


    }
}
