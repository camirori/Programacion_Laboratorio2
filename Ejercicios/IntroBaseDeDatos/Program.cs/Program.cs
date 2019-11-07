using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroBaseDeDatos;

namespace Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DAO.InsertarCliente("Camila", "Rori", "38668299", DateTime.Today);
                DAO.InsertarCliente("d", "c", "38668299", DateTime.Now);
                Console.WriteLine("Registro insertado");
                DAO.ModificarCliente(1, "a", "b", "1", DateTime.Now);
                Console.WriteLine("Registro modificado");
                DAO.BorrarCliente(1);
                Console.WriteLine("Registro borrado");
                DAO.InsertarMascota("Ema", 22);
                Console.WriteLine("Registro insertado");
                DAO.InsertarMascota("Nadia", 21);
                Console.WriteLine("Registro insertado");

                List<Cliente> clientes = DAO.LeerClientes();
                foreach (Cliente cliente in clientes)
                    Console.WriteLine(cliente.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
