using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ej61Guia_BaseDeDatos
{
    public static class PersonaDAO
    {
        private static string connectionString = @"Server = .\SQLEXPRESS ; Database = DBPersona ; Trusted_Connection = true;";

        //Insert, Update y Delete:
        public static int Guardar(string nombre, string apellido)
        {
            int idGenerado;
            using (SqlConnection connection = new SqlConnection(PersonaDAO.connectionString))
            {
                string comando = "INSERT INTO PERSONAS (nombre, apellido) VALUES (@nombre,@apellido);SELECT CAST(scope_identity() AS int);";       //se puede recibir por param
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);   //p armar relaciones entre un identificador y un param
                connection.Open();      // p / abrir la conexiòn con la base de datos
                idGenerado=(int)command.ExecuteScalar();
            }
            return idGenerado;
        }
        public static void Modificar(string nombre, string apellido, int id)
        {
            using (SqlConnection connection = new SqlConnection(PersonaDAO.connectionString))
            {
                string comando = "UPDATE PERSONAS SET nombre = @nombre, apellido = @apellido WHERE id = @id; ";       //se puede recibir por param
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();      // p / abrir la conexiòn con la base de datos
                command.ExecuteNonQuery();
            }
        }
        public static void Borrar(int id)
        {
            using (SqlConnection connection = new SqlConnection(PersonaDAO.connectionString))
            {
                string comando = "DELETE FROM PERSONAS WHERE id=@id;";     
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();      
                command.ExecuteNonQuery();
            }
        }

        //Select:
        public static List<Persona> Leer()      //cada registro va a ser un elemento de la lista
        {
            using (SqlConnection connection = new SqlConnection(PersonaDAO.connectionString))
            {
                string comando = "SELECT id,nombre,apellido FROM PERSONAS;";
                SqlCommand command = new SqlCommand(comando, connection);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();     //s/doc dentro de otro using
                List<Persona> lista = new List<Persona>();

                while (dataReader.Read())           //Read() se desplaza al sig registro
                {
                    int id = dataReader.GetInt32(0);    //el num es el orden de columna en el comando
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    Persona persona = new Persona(id,nombre,apellido);
                    lista.Add(persona);
                }
                dataReader.Close();
                return lista;
            }
        }

        public static Persona LeerPorID(int id)      //cada registro va a ser un elemento de la lista
        {
            using (SqlConnection connection = new SqlConnection(PersonaDAO.connectionString))
            {
                string comando = "SELECT nombre,apellido FROM PERSONAS WHERE id=@id;";
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();     //s/doc dentro de otro using

                string nombre = dataReader.GetString(0);
                string apellido = dataReader.GetString(1);
                Persona persona = new Persona(id, nombre, apellido);

              
                dataReader.Close();
                return persona;
            }
        }




    }
}
