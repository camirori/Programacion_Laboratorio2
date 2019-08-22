using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03Guia_Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Numero:");
            input = int.Parse(Console.ReadLine());

            Console.WriteLine("Primos:");
            for (int i=1; i<=input;i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("{0}",i);
            }

            Console.ReadKey();
        }
    }
}
