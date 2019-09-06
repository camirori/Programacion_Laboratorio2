using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesMedida
{
    public class Kelvin
    {
        private double grados;

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return this.grados;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin k = new Kelvin((f.GetGrados() + 459.67) * 5 / 9);
            return k;
        }
        public static explicit operator Kelvin(Celsius c)
        {
            return (Kelvin)((Fahrenheit)c);
        }

    }
}
