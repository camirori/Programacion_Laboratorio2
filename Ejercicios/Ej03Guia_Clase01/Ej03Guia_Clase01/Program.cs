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
            int divisor;
            bool primo;

            Console.WriteLine("Numero:");
            input = int.Parse(Console.ReadLine());

            Console.WriteLine("Primos:");
            for (int i=2; i<=input;i++)
            {
                for (divisor = 2, primo = true; divisor < i && primo == true; divisor++)
                {
                    if (i % divisor == 0)
                        primo = false;
                }
                if (primo == true)
                    Console.WriteLine("{0:#,###.00}", i);
            }

            Console.ReadKey();
        }
    }
}
