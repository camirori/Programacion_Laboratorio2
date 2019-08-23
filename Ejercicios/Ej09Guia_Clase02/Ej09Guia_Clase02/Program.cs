using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09Guia_Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string dibujo;

            Console.WriteLine("Altura piramide:");
            altura = int.Parse(Console.ReadLine());
            for(int i=1;i<=altura;i++)
            {
                dibujo = new string('*', (i*2)-1);
                Console.WriteLine("\n"+dibujo);
            }
            Console.ReadKey();
        }
    }
}

/*
 * Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas*/
