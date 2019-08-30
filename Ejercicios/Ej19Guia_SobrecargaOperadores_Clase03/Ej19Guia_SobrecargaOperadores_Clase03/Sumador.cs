using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej19Guia_SobrecargaOperadores_Clase03
{
    class Sumador
    {
        private int cantidadSumas;

        //constructores
        public Sumador()
        {
            new Sumador(0);
        }
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        //metodos
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        //c conversion explicita
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }

        //d
        public static long operator +(Sumador s1, Sumador s2)
        {
            long suma = s1.cantidadSumas + s2.cantidadSumas;
            return suma;
        }

        //e
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
                return true;
            else
                return false;
        }


    }
}
