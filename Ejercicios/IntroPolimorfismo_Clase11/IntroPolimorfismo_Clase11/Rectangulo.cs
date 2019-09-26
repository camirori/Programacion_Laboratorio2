using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPolimorfismo_Clase11
{
    public class Rectangulo: Figura
    {
        double ladoA;
        double ladoB;

        public Rectangulo(double ladoA, double ladoB)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return this.ladoA * this.ladoA;
        }
        public override double CalcularPerimetro()
        {
            return this.ladoA*2+ this.ladoB*2;
        }
    }
}
