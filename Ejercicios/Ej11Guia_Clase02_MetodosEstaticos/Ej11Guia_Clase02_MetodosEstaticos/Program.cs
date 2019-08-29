using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11Guia_Clase02_MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int max = 0;
            int min = 0;
            int acumulado = 0;
            int promedio;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Numero:");
                if (Int32.TryParse(Console.ReadLine(),out input) && Validacion.Validar(input, -100, 100))
                {
                    acumulado += input;
                    if (input < min || i == 0)
                        min = input;
                    if (input > max || i == 0)
                        max = input;
                }
                else
                    Console.WriteLine("Fuera de rango");
            }
            promedio = acumulado / i;

            Console.WriteLine("Min: {0}\nMax: {1}\nPromedio: {2}", min, max, promedio);
            Console.ReadKey();

        }
    }
}

/*
 * 11. Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.
*/
