using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevaClase
{
    public class Mensaje <T,Pepe> where T:struct
                                  where Pepe:class,new()
    {
        private T mensaje;
        private Pepe atributo;

        public Mensaje(T paramA, Pepe paramB)
        { }
    }


}
