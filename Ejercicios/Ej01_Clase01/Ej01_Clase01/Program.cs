using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01_Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            string nombre = "camila";
            string apellido = "rori";

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hola {0} {1}",nombre,apellido);

            
            Console.ReadKey();
        }
    }
}
