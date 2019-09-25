using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej30Guia_Colecciones
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores): this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\n\nCantidad competidores {0}\tCantidad de vueltas: {1}", this.cantidadCompetidores, this.cantidadVueltas);

            foreach (AutoF1 auto in competidores)
            {
                mensaje.Append(auto.MostrarDatos());
            }
            return mensaje.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count() >= c.cantidadCompetidores && c == a)
                return false;
            else
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                Random vueltas = new Random();
                a.CantidadCombustible = (short)vueltas.Next(15, 101);
                return false;
            }
                
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            return c.competidores.Remove(a);
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c==a);
        }
    }
}
