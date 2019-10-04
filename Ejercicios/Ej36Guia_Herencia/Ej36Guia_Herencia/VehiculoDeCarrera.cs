using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36Guia_Herencia
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }
        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\nEscudería {0}\tNumero: {1}\tEn competencia: {2}\tCantidad combustible: {3}\tVueltas restantes: {4}", this.escuderia, this.numero, this.enCompetencia, this.cantidadCombustible, this.vueltasRestantes);
            return mensaje.ToString();
        }
    }
}
