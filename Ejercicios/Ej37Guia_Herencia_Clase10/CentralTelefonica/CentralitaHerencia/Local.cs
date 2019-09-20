using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local: Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #region Metodos
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo) { }
        public Local(string origen, float duracion, string destino, float costo): base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("{0}\tCosto Llamada: {1:C}", base.Mostrar(), this.CostoLlamada);
            return mensaje.ToString();
        }

        #endregion
    }
}
