using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej06Guia_Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fin;
            Console.WriteLine("Ingrese año de incio");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año de fin");
            fin = int.Parse(Console.ReadLine());

            Console.WriteLine("Años bisiestos:");
            for(;inicio<=fin;inicio++)
            {
                if(inicio%4==0)
                {
                    if (inicio % 100 == 0 && inicio % 400 != 0)
                        continue;
                    else
                        Console.WriteLine("{0}", inicio);
                }
            }
            Console.ReadKey();
        }
    }
}

/*
 * Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
*/
