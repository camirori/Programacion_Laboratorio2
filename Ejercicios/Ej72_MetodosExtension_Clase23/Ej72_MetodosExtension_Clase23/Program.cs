using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej72_MetodosExtension_Clase23
{
    class Program
    {
        static void Main(string[] args)
        {
            string obj = "ABC";
            Console.WriteLine(obj.ContarLetras());

            string palabras = "A B C";
            Console.WriteLine(palabras.ContarPalabras());


            long numero = 100000;

            Console.WriteLine("Numero de {0} digitos",numero.CantidadDeDigitos());


            string palabra = "aaa,aaa,";
            Console.WriteLine("Signos: {0}",palabra.ContarSignosPuntuacion());

            Console.ReadKey();
        }
    }
}
