﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42Guia_Excepciones_Clase17
{
    class ClaseC
    {
        public void MetodoInstancia()
        {
            try
            {
                new ClaseB();
            }
            catch(UnaException d)
            {
                throw new MiException(d);
            }
        }

    }
}
