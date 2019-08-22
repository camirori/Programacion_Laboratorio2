using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04Guia_Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulado = 0;
            int primosEncontrados;
            int i;
            int divisor;

            Console.WriteLine("Numeros primos");
            for(i=1, primosEncontrados = 0; primosEncontrados < 4; i++,acumulado=0)
            {
                for(divisor = 1; divisor < i; divisor++)
                {
                    if (i % divisor == 0)
                        acumulado += divisor;
                }
                if(acumulado == i)
                {
                    Console.WriteLine("Primo {0}", i);
                    primosEncontrados++;
                }
            }
            if(primosEncontrados==0)
                Console.WriteLine("No encontrados");
            Console.ReadKey();
        }
    }
}
/*
 * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.
*/