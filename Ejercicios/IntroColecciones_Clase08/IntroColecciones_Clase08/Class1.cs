using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroColecciones_Clase08
{
    class Class1
    {
        public static int Comparar(int x, int y)
        {
            if (x > y)
                return -1;  //Si es mayor es predecesor
            else if (x < y)
                return 1;
            else
                return 0;
        }
    }
}
