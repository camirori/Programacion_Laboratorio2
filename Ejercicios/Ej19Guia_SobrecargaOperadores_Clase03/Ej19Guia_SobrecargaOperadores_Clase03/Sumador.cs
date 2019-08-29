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


    }
}
