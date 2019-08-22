using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01Guia_Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            string buffer;
            int max = 0;
            int min = 0;
            int acumulado = 0;
            int promedio;
            int i;

            for(i=0; i<5;i++)
            {
                Console.WriteLine("Numero:");
                buffer = Console.ReadLine();
                input = int.Parse(buffer);
                acumulado += input;
                if (input < min || i == 0)
                    min = input;
                if (input > max || i == 0)
                    max = input;
            }
            promedio = acumulado / i;

            Console.WriteLine("Min: {0}\nMax: {1}\nPromedio: {2}", min, max, promedio);
            Console.ReadKey();

            
        }
    }
}
