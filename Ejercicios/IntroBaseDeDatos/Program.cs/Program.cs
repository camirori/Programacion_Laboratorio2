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
                DAO.InsertarCliente("Camila", "Rori", "38668299", DateTime.Now);
            }
            catch (Exception e)
            {

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
