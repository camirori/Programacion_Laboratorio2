using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej52Guia_Interfaces_Clase21;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Cartuchera1 cartuchera1 = new Cartuchera1();
            cartuchera1.cartuchera.Add(miLapiz);
            cartuchera1.cartuchera.Add(miBoligrafo);

            Cartuchera2 cartuchera2 = new Cartuchera2();
            cartuchera2.lapices.Add(miLapiz);
            cartuchera2.boligrafos.Add(miBoligrafo);

            bool retorno = true;
            do
                retorno=cartuchera1.ProbarElementos();
            while (retorno == true);

            Console.WriteLine(retorno);

            do
                retorno = cartuchera2.ProbarElementos();
            while (retorno == true);

            Console.WriteLine(retorno);

            Console.ReadKey();
        }
    }
}
