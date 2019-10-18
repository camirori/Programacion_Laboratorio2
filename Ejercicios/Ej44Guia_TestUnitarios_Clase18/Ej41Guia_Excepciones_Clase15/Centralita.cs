using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas);}
        }
        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }
        #endregion

        #region Metodos
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulado = 0;
            if(tipo==Llamada.TipoLlamada.Local || tipo==Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if(llamada is Local)
                        acumulado += ((Local)llamada).CostoLlamada;
                }
            }
            if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if(llamada is Provincial)
                        acumulado += ((Provincial)llamada).CostoLlamada;
                }
            }
            return acumulado;
        }
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }

        protected string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\n\n\nRazon social: {0} \tGanancia total: {1:C2}\tGanancia por locales {2:C2}\tGanancia por provinciales {3:C2}", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal,this.GananciasPorProvincial);
            foreach(Llamada llamada in listaDeLlamadas)
            {
                if(llamada is Local)
                    mensaje.Append(((Local)llamada).ToString());
                else if (llamada is Provincial)
                    mensaje.Append(((Provincial)llamada).ToString());
            }
            return mensaje.ToString();
            //expondrá la razón social, la ganancia total, ganancia por llamados locales
            //y provinciales y el detalle de las llamadas realizadas.
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion

        #region Sobrecarga
        public static bool operator ==(Centralita c,Llamada llamada)
        {
            foreach(Llamada llamadaActual in c.listaDeLlamadas)
            {
                if (llamadaActual == llamada)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c==llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            else
                throw new CentralitaException("La llamada ya existe", "clase", "metodo");
            return c;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
