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
    }
}
