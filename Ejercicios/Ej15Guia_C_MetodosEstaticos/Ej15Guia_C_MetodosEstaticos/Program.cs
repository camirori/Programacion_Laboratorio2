using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15Guia_C_MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            int operando1;
            int operando2;
            char signo;
            char continuar = 's';

            do
            {
                Console.WriteLine("Operando 1");
                operando1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Operando 2");
                operando2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Operacion");
                signo = char.Parse(Console.ReadLine());

                Calculadora.Mostrar(Calculadora.Calcular(operando1, operando2, signo));

                Console.WriteLine("Continuar? s/n");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's' || continuar == 'S');

        }
    }
}

/*
 * 15. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división). 
 * Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * ó /). 
 * El usuario decidirá cuándo finalizar el programa. 
 * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase): 
 * a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación. 
 * b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
 * Este método devolverá TRUE si el número es distinto de CERO. 
 */
