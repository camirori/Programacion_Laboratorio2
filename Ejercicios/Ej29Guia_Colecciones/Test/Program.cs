using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej29Guia_Colecciones;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador(38668299, "A");
            Jugador jugador2 = new Jugador(34664299, "B", 10, 5);

            Console.WriteLine(jugador1.MostrarDatos());

            Console.WriteLine(jugador2.MostrarDatos());

            Console.ReadKey();
        }
    }
}
