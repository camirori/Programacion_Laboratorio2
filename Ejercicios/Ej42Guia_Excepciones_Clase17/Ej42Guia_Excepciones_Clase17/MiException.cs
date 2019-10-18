using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42Guia_Excepciones_Clase17
{
    class MiException: Exception
    {
        public MiException(Exception innerException) : base("D_MiException", innerException)
        {

        }
    }
}
