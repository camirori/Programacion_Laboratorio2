using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52Guia_Interfaces_Clase21
{
    public class Lapiz: IAcciones
    {
        private float tamanioMina;

        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }
        public float UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina=value; }
        }

        #region Metodos
        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
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
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.UnidadesDeEscritura -= (float)(0.1 * texto.Length);
            return new EscrituraWrapper(texto, this.Color);
        }
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        #endregion
    
    }
}
