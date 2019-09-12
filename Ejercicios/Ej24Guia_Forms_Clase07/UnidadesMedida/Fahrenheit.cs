using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadesMedida
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return this.grados;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit f = new Fahrenheit(c.GetGrados() * (9 / 5) + 32);
            return f;
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit f = new Fahrenheit(k.GetGrados() * 9 / 5 - 459.67);
            return f;
        }

        public static implicit operator double(Fahrenheit f)
        {
            return f.grados;
        }
    }
}
