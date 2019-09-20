using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial: Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #region Metodos
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.duracion * (float)0.99;
                case Franja.Franja_2:
                    return this.duracion * (float)1.25;
                case Franja.Franja_3:
                    return this.duracion * (float)0.66;
                default:
                    return 0;
            }
        }
        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("{0}\tCosto Llamada: {1:C2} \tFranja Horaria: {2}", base.Mostrar(), this.CostoLlamada,this.franjaHoraria);
            return mensaje.ToString();
        }
        public Provincial(Franja miFranja, Llamada llamada): this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino) { }
        public Provincial(string origen, Franja miFranja, float duracion, string destino): base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        #endregion

        public enum Franja { Franja_1, Franja_2, Franja_3}
    }
}
