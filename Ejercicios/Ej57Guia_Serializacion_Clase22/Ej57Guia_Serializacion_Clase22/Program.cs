using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej57Guia_Serializacion_Clase22
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("a", "b");

            Persona.Guardar(persona);
            Console.WriteLine(Persona.Leer().ToString());

            Console.ReadKey();
        }
    }
}
