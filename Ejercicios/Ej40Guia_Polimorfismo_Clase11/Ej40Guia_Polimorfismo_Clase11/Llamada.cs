using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    abstract public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public abstract float CostoLlamada { get; }
        #endregion

        #region Metodos
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\n\nDuración: {0} \tNumero de origen: {1} \tNumero de destino: {2}", this.duracion, this.nroOrigen, this.nroDestino);
            return mensaje.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
                return 1;
            else if (llamada1.duracion < llamada2.duracion)
                return -1;
            else
                return 0;
        }

        #endregion

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.GetType() == l2.GetType())&& (l1.;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public enum TipoLlamada { Local, Provincial, Todas }
    }
}
