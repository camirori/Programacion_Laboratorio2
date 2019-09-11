using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasesNumericas;

namespace Ej22Guia_SobrecargaOperadores_Clase06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "0100";
            double num = 4;

            NumeroBinario binario = str;
            NumeroDecimal dec = num;

            double resultado;
            resultado= dec + binario;

            Console.WriteLine("{0} + {1} = {2}",(double)dec,(string)binario,resultado);

            bool comparar = binario == dec;
            Console.WriteLine("{0} == {1} = {2}", (double)dec, (string)binario, comparar);

            Console.ReadKey();
            


        }
    }
}
