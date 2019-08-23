using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12Guia_Clase02_MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulado = 0;
            char respuesta = 's';
            int input;

            do
            {
                Console.WriteLine("Numero a sumar:");
                input = int.Parse(Console.ReadLine());
                acumulado += input;
                Console.WriteLine("¿Continuar? (S/N)");
                respuesta = char.Parse(Console.ReadLine());
            } while (ValidarRespuesta.ValidaS_N(respuesta));

            Console.WriteLine("Suma: {0}", acumulado);
            Console.ReadKey();
        }
    }
}

/*
 * 12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.
*/
