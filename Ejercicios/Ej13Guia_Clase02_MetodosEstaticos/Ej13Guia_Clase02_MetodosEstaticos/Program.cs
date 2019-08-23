using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13Guia_Clase02_MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputDecimal;
            double outputDecimal;
            string inputBinario;
            string outputBinario;

            Console.WriteLine("inputDecimal:");
            inputDecimal = double.Parse(Console.ReadLine());
            outputBinario = Conversor.DecimalBinario(inputDecimal);
            Console.WriteLine("outputBinario: " + outputBinario);

            Console.WriteLine("\ninputBinario:");
            inputBinario = Console.ReadLine();
            outputDecimal = Conversor.BinarioDecimal(inputBinario);
            Console.WriteLine("outputDecimal: {0}", outputDecimal);

            Console.ReadKey();
        }
    }
}
/*
 * 13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero.
*/
