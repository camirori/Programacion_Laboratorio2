using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPolimorfismo_Clase11
{
    public sealed class Cuadrado: Rectangulo
    {
        public Cuadrado(double lado): base(lado,lado){}
    }
}
