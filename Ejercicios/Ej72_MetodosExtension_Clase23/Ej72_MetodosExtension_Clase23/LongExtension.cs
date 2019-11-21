using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej72_MetodosExtension_Clase23
{
    public static class LongExtension
    {
        public static int CantidadDeDigitos(this long obj)
        {
            return (obj.ToString()).Length;
        }

    }
}
