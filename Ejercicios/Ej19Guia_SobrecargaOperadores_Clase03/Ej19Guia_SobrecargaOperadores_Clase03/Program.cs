using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej19Guia_SobrecargaOperadores_Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador prueba = new Sumador();
            Console.WriteLine(prueba.Sumar("a", "b"));

            Console.ReadKey();
        }
    }
}

/*19. Realizar una aplicación de consola. Agregar la clase Sumador.
a. Crear dos constructores:
i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
siguiente lógica:
i. En el caso de Sumar(long, long) sumará los valores numéricos
ii. En el de Sumar(string, string) concatenará las cadenas de texto.
Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
c. Generar una conversión explícita que retorne cantidadSumas.
d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
con dicho valor.
e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
cantidadSumas.
Agregar un segundo objeto del tipo Sumador en el Main y probar el código.

    */