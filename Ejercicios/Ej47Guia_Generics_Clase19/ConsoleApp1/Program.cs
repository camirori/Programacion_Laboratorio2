using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej47Guia_Generics_Clase19;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("futbol");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("futbol");

            EquipoFutbol EqFutbol1 = new EquipoFutbol("eq1");
            EquipoFutbol EqFutbol2 = new EquipoFutbol("eq2");
            EquipoFutbol EqFutbol3 = new EquipoFutbol("eq3");
            EquipoBasquet EqBasquet1 = new EquipoBasquet("eq4");
            EquipoBasquet EqBasquet2 = new EquipoBasquet("eq5");
            EquipoBasquet EqBasquet3 = new EquipoBasquet("eq6");

            bool buffer;
            buffer=torneoFutbol + EqFutbol1;
            buffer = torneoFutbol + EqFutbol2;
            buffer = torneoFutbol + EqFutbol3;

            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido()); 
            

            Console.ReadKey();
        }
    }
}
