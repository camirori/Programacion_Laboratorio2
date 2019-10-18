using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42Guia_Excepciones_Clase17
{
    class ClaseA
    {
        //A
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("A_DivideByZeroException");
        }

        public ClaseA()
        {
            try
            {
                ClaseA.MetodoEstatico();
            }
            catch(DivideByZeroException b)
            {
                throw b;
            }
        }
    }
}
