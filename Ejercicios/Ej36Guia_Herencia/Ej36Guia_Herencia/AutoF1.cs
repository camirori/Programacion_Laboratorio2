using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36Guia_Herencia
{
    class AutoF1: VehiculoDeCarrera
    {


        public AutoF1(short numero, string escuderia) : base(numero, escuderia) { }
        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\nEscudería {0}\tNumero: {1}\tEn competencia: {2}\tCantidad combustible: {3}\tVueltas restantes: {4}",this.escuderia,this.numero,this.enCompetencia,this.cantidadCombustible,this.vueltasRestantes);
            return mensaje.ToString();
        }

        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            return String.Equals(a1.escuderia, a2.escuderia) && a1.numero == a2.numero;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

    }
}
