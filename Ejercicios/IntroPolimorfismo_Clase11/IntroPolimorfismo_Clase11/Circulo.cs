using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPolimorfismo_Clase11
{
    public sealed class Circulo: Figura
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo...";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }
        public override double CalcularPerimetro()
        {
            return 2*Math.PI*this.radio;
        }
    }
}
