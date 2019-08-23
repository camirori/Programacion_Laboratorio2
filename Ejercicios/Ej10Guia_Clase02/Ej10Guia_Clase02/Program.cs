using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10Guia_Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string dibujo;
            string tabulado;

            Console.WriteLine("Altura piramide:");
            altura = int.Parse(Console.ReadLine());
            for (int i = 1; i <= altura; i++)
            {
                tabulado = new string(' ', altura - i);
                dibujo = new string('*', (i * 2) - 1);
                Console.WriteLine("\n" + tabulado + dibujo);
            }
            Console.ReadKey();
        }
    }
}
/*
 * 10. Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
una pirámide como la siguiente:
    *
   ***
  *****
 *******
*********
Nota: Utilizar estructuras repetitivas y selectivas
*/