using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02Guia_Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int cuadrado;
            int cubo;

            Console.WriteLine("Numero:");
            input = int.Parse(Console.ReadLine());  // o Convert.ToInt32(string)

            while (input <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Numero:");
                input = int.Parse(Console.ReadLine());  
            } 

            cuadrado = (int)Math.Pow(input, 2);
            cubo = (int)Math.Pow(input, 3);

            Console.Clear();    //para limpiar la consola
            Console.WriteLine("Cuadrado: {0}\nCubo: {1}", cuadrado, cubo);

            Console.ReadKey();
        }
    }
}
