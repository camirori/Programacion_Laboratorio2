using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej48Guia_Generics_Clase20
{
    class Recibo: Documento
    {
        public Recibo(): this(0)
        {

        }
        public Recibo(int numero) : base(numero)
        {

        }
    }
}
