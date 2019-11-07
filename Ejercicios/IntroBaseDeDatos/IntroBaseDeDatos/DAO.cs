using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroBaseDeDatos
{
    public static class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString;

        static DAO()
        {
            connectionString = @"Server = .\SQLEXPRESS ; Database = BDVet ; Trusted_Connection = true;";
            connection = new SqlConnection(connectionString);

            command = new SqlCommand();
            command.Connection = connection;    // lo puedo indicar en el ctor new SqlCommand(comando, connection);
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void InsertarCliente(string nombre, string apellido, string dni, DateTime? fecha)
        {
            try
            {
                connection.Open();  //p/abrir la conexiòn con la base de datos
                string comando =String.Format("INSERT INTO CLIENTES (nombre, apellido, dni, fecha_nacimiento)"+
                    "VALUES ('{0}','{1}','{2}',{3});",nombre,apellido,dni,fecha);
                command.CommandText = comando;  // lo puedo indicar en el ctor new SqlCommand(comando, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                
            }
        }
                                                                                                   //? lo hace nullable
        public static void ModificarCliente(int id, string nombre, string apellido, string dni, DateTime? fecha_nacimiento)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                //los objetos dentro tienen que implementar la interfaz IDisposable

                string comando = "UPDATE CLIENTES SET nombre=@nombre, apellido=@apellido, dni=@dni, fecha_nacimiento=@fecha_nacimiento WHERE id=@id;";
                SqlCommand command = new SqlCommand(comando,connection);

                command.Parameters.AddWithValue("@nombre", nombre); //p armar relaciones entre un identificador y un param
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();  //p/abrir la conexiòn con la base de datos
                command.ExecuteNonQuery();
            }  
        }

        public static void BorrarCliente(int id)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "DELETE FROM CLIENTES WHERE id=@id;";
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@id", id);

                connection.Open();  //p/abrir la conexiòn con la base de datos
                command.ExecuteNonQuery();
            }
        }
        public static void InsertarMascota(string nombre, int idHumano)
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "INSERT INTO MASCOTAS (nombre, idHumano) VALUES (@nombre,@idHumano);";
                SqlCommand command = new SqlCommand(comando, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@idHumano", idHumano);

                connection.Open();  //p/abrir la conexiòn con la base de datos
                command.ExecuteNonQuery();
            }
        }

        public static List<Cliente> LeerClientes()
        {
            using (SqlConnection connection = new SqlConnection(DAO.connectionString))
            {
                string comando = "SELECT id, nombre, apellido, dni, fecha_nacimiento FROM CLIENTES;";
                SqlCommand command = new SqlCommand(comando, connection);
                
                connection.Open();  //p/abrir la conexiòn con la base de datos
                SqlDataReader dataReader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();

                while(dataReader.Read())    //Read() se desplaza al sig registro
                {
                    int id = dataReader.GetInt32(0);    //el num es el orden de columna que indico arriba
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    string dni = dataReader.GetString(3);
                    DateTime? fechaNacimiento = null;
                    if (!dataReader.IsDBNull(4))
                        fechaNacimiento = dataReader.GetDateTime(4);

                    Cliente cliente = new Cliente(id, nombre, apellido, dni, fechaNacimiento);
                    clientes.Add(cliente);
                }
                return clientes;
            }
        }


    }
}
