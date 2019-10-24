using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36Guia_Herencia
{
    public class MotoCross: VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia) { }
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder(base.ToString());
            mensaje.AppendFormat("\tCilindrada: {0}", this.Cilindrada);
            return mensaje.ToString();
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return String.Equals(a1.Escuderia, a2.Escuderia) && a1.Numero == a2.Numero && a1.Cilindrada == a2.Cilindrada;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
