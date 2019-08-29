using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej11Guia_Clase02_MetodosEstaticos
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            if (valor >= min && valor <= max)
                retorno = true;
            return retorno;
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
