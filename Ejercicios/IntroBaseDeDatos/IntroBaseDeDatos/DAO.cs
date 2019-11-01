using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroBaseDeDatos
{
    public class DAO
    {
        private static SqlConnection connection;
        private static SqlCommand command;

        static DAO()
        {
            string connectionString = @"Data Source= ./; Initial Catalog= BDVet; Integrated Security = true;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void InsertarCliente(string nombre, string apellido, string dni, DateTime fecha)
        {
            try
            {
                connection.Open();  //p/abrir la conexiòn con la base de datos
                string comando =String.Format("INSERT INTO CLIENTES (nombre, apellido, dni) VALUES ('{0}','{1}','{2}')",nombre,apellido,dni);
                command.CommandText = comando;
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                
            }
        }
    }
}
