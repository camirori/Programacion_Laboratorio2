using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14Guia_C_MetodosEstaticos
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double input)
        {
            double resultado;

            resultado = input * input;

            return resultado;
        }

        public static double CalcularTriangulo(double basee, double altura)
        {
            double resultado;

            resultado = (basee * altura) / 2;

            return resultado;
        }
        public static double CalcularCirculo(double radio)
        {
            double resultado;

            resultado = Math.PI * Math.Pow(radio, 2);

            return resultado;
        }
    }
}
