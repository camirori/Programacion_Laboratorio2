using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42Guia_Excepciones_Clase17
{
    public class ClaseB
    {
        public ClaseB()
        {
            try
            {
                new ClaseA();
            }
            catch(DivideByZeroException c)
            {
                throw new UnaException(c);
            }
        }
    }
}
