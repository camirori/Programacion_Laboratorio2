﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13Guia_Clase02_MetodosEstaticos
{
    class Conversor
    {
        static public string DecimalBinario(double inputDecimal)
        {
            string outputBinario = "";
            int resto;
            int cociente = (int)inputDecimal;
            double parteDecimal = inputDecimal - cociente;

            while (cociente >= 2)
            {
                resto= cociente % 2;
                cociente /= 2;
                outputBinario = string.Concat(resto, outputBinario);    //resto.ToString()+binarioOutput;
            } 
            outputBinario = string.Concat(cociente, outputBinario);
            for(int i=0;i<4 && parteDecimal>0; i++)
            {
                if(parteDecimal*2>0)
                {

                }
            }

            return outputBinario;
        }
        static public double BinarioDecimal(string inputBinario)
        {
            double outputDecimal = 0;
            char[] array = inputBinario.ToCharArray();
            Array.Reverse(array);

            for (int i=0;i<inputBinario.Length;i++)
            {
                outputDecimal += (char.GetNumericValue(array[i])*Math.Pow(2, i));
            }
            
            return outputDecimal;
        }
    }
}

/*
 * 13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero.
*/
