using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05Guia_Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int acumuladoAnteriores = 0;
            int acumuladoPosteriores = 0;
            Console.WriteLine("Ingrese numero maximo a evaluar:");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("Centros numericos:");

            for (int potencialCentro=2; potencialCentro <= max; potencialCentro++,acumuladoAnteriores=0,acumuladoPosteriores=0)
            {
                for(int anteriores=0;anteriores< potencialCentro;anteriores++)
                {
                    acumuladoAnteriores += anteriores;
                }
                for(int posteriores=potencialCentro+1;acumuladoPosteriores<acumuladoAnteriores;posteriores++)
                {
                    acumuladoPosteriores += posteriores;
                    if(acumuladoPosteriores==acumuladoAnteriores)
                    {
                        Console.WriteLine("{0}", potencialCentro);
                    }
                }

            }
            Console.ReadKey();
                
        }
    }
}

/*
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas y selectivas.
*/
