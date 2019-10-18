using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36Guia_Herencia
{
    class AutoF1: VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get { return caballosDeFuerza; }
            set { caballosDeFuerza = value; }
        }


        public AutoF1(short numero, string escuderia) : base(numero, escuderia) { }
        public AutoF1(short numero, string escuderia,short caballosDeFuerza): this(numero,escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder(base.ToString());
            mensaje.AppendFormat("\tCaballos De Fuerza: {0}", this.CaballosDeFuerza);
            return mensaje.ToString();
        }

        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            return String.Equals(a1.Escuderia, a2.Escuderia) && a1.Numero == a2.Numero;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
