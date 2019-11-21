using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej72_MetodosExtension_Clase23
{
    public static class StringExtension
    {
        public static int ContarLetras(this String obj)
        {
            return obj.Count<char>();
        }
        public static int ContarPalabras(this String obj)
        {
            string[] palabras = obj.Split(' ');
            return palabras.Count();
        }

        public static int ContarSignosPuntuacion(this String obj)
        {
            string signosPuntuacion = ".,;";
            int contador = 0;

            foreach(Char signo in obj)
            {
                if (signosPuntuacion.Contains<char>(signo))
                    contador++;
            }

            return contador;
        }
    }
}
