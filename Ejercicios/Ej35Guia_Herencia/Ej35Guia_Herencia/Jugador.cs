using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej35Guia_Herencia
{
    public class Jugador: Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }
        public float PromedioGoles
        {
            get { return (partidosJugados == 0) ? 0 : (float)totalGoles / partidosJugados; }
        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; }
        }

        public Jugador(int dni, string nombre): this(dni,nombre,0,0) { }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): base(dni,nombre)
        {
            
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public new string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder(base.MostrarDatos());
            mensaje.AppendFormat("\tPartidos jugados: {0}\tTotal Goles: {1}\tPromedio Goles: {2}", this.partidosJugados, this.totalGoles, this.PromedioGoles);
            return mensaje.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return string.Equals(j1.Dni, j2.Dni);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
