using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42Guia_Excepciones_Clase17
{
    public class UnaException: Exception
    {
        public UnaException(Exception innerException): base("C_UnaException",innerException)
        {

        }
    }
}
