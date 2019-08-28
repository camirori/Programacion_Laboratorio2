using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15Guia_C_MetodosEstaticos
{
    class Calculadora
    {
        static public int Calcular(int op1, int op2, char signo)
        {
            int resultado = new int();

            switch (signo)
            {
                case '+':
                    resultado = op1 + op2;
                    break;
                case '-':
                    resultado = op1 - op2;
                    break;
                case '*':
                    resultado = op1 * op2;
                    break;
                case '/':
                    if (Calculadora._Validar(op2) == true)
                        resultado = op1 / op2;
                    else
                        Console.WriteLine("El divisor no puede ser 0");
                    break;
            }
            return resultado;
        }

        static private bool _Validar(int divisor)
        {
            if (divisor != 0)
                return true;
            else
                return false;
        }

        static public void Mostrar(int resultado)
        {
            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
