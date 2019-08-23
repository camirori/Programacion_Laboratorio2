using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej07Guia_Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();
            //int dias;
            TimeSpan dias;

            Console.WriteLine("Ingrese fecha de nacimiento:");
            fecha = DateTime.Parse(Console.ReadLine());
            dias = DateTime.Now - fecha;

            Console.WriteLine("Dias vividos: {0}", dias.Days);
            Console.ReadKey();
        }
    }
}

/*
 * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
*/
