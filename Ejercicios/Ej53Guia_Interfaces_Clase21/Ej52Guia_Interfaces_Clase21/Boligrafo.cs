using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52Guia_Interfaces_Clase21
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }
        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        #region Metodos
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder("\n");
            mensaje.AppendFormat("\nTipo: {0}", this.GetType());
            mensaje.AppendFormat("\nColor escritura: {0}", this.Color);
            mensaje.AppendFormat("\nNivel de tinta/mina: {0:0.##}", this.UnidadesDeEscritura);

            return mensaje.ToString();
        }
        #endregion

        #region Interfaz
        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= (float)(0.3 * texto.Length);
            return new EscrituraWrapper(texto, this.Color);
        }
        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }
        #endregion
    }
}
