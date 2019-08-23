using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej08Guia_Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmpleados = 2;
            float importeACobrar; //((valorHora*cantidadHoras)+(antiguedad*valorAntiguedad))*(1-descuento)
            int valorAntiguedad = 150;
            float descuento;
            float porcentajeDescuento = 0.13F;
            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;

            for(int i=0;i<cantidadEmpleados;cantidadEmpleados++)
            {
                Console.WriteLine("Valor Hora:");
                valorHora = int.Parse(Console.ReadLine());
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Antigüedad:");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad de horas trabajadas en el mes: ");
                horasTrabajadas = int.Parse(Console.ReadLine());

                importeACobrar = (valorHora * horasTrabajadas) + (antiguedad * valorAntiguedad);

                Console.WriteLine("\nRecibo de sueldo\nNombre: {0}\nAntigüedad: {1,-10} Valor hora: {2}\nTotal bruto: {3}", nombre, antiguedad, valorHora, importeACobrar);

                descuento = importeACobrar * porcentajeDescuento;
                importeACobrar -= descuento;
                Console.WriteLine("\nDescuentos: {0:F2}\nNeto a cobrar: {1}", descuento, importeACobrar);
            }
            
            Console.ReadKey();
        }
    }
}
/*
 * Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.
*/
