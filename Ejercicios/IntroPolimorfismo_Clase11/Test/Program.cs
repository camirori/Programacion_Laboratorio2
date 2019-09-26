using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroPolimorfismo_Clase11;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(2);
            Rectangulo rectangulo = new Rectangulo(4,8);
            Cuadrado cuadrado = new Cuadrado(3);

            Console.WriteLine(circulo.Dibujar());
            Console.WriteLine("{0:0.00}",circulo.CalcularSuperficie());
            Console.WriteLine("{0:0.00}", circulo.CalcularPerimetro());

            Console.WriteLine(rectangulo.Dibujar());
            Console.WriteLine("{0:0.00}", rectangulo.CalcularSuperficie());
            Console.WriteLine("{0:0.00}", rectangulo.CalcularPerimetro());

            Console.WriteLine(cuadrado.Dibujar());
            Console.WriteLine("{0:0.00}", cuadrado.CalcularSuperficie());
            Console.WriteLine("{0:0.00}", cuadrado.CalcularPerimetro());

            Console.ReadKey();
        }
    }
}
