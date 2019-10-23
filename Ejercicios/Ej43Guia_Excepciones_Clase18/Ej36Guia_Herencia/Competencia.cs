using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36Guia_Herencia
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public TipoCompetencia Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }

        public VehiculoDeCarrera this[int i]  
        {
            get { return competidores[i]; }
        }


        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo): this()
        {
            this.CantidadVueltas = cantidadVueltas;
            this.CantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\n\nCantidad competidores {0}\tCantidad de vueltas: {1}", this.CantidadCompetidores, this.CantidadVueltas);

            foreach (VehiculoDeCarrera auto in competidores)
            {
                mensaje.Append(auto.MostrarDatos());
            }
            return mensaje.ToString();
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno;
            try
            {
                retorno= c == a;
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "+", ex);
            }


            if (c.competidores.Count() >= c.CantidadCompetidores)       
                return false;
            else
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.CantidadVueltas;
                Random vueltas = new Random();
                a.CantidadCombustible = (short)vueltas.Next(15, 101);
                return true;
            }
                
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            return c.competidores.Remove(a);
        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            TipoCompetencia tipo;
            tipo = (a.GetType() == typeof(AutoF1)) ? TipoCompetencia.F1 : TipoCompetencia.MotoCross;
            bool retorno= c.tipo == tipo;

            if (retorno == false)
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia","Competencia","==");

            return retorno;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c==a);
        }

        public enum TipoCompetencia { F1, MotoCross}
    }
}
