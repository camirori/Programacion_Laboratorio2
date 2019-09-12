using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej26Guia_Arrays_Colecciones_Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random aleatorio = new Random();

            Console.WriteLine("A.");
            for (int i=0;i<array.Length;i++)
            {
                do
                    array[i] = aleatorio.Next(-100,101);
                while (array[i] == 0);
            }
            foreach(int i in array)
            {
                Console.WriteLine("{0}", i);
            }

            
            Array.Sort(array);
            Console.WriteLine("\nB.");
            for (int i=array.Length-1;i>0 && array[i]>0;i--)
            {
                Console.WriteLine("{0}", array[i]);
            }

            Console.WriteLine("\nC.");
            for (int i = 0; i < array.Length && array[i] < 0; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }

            Console.ReadKey();

        }
    }
}
