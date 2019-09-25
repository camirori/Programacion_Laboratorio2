using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej29Guia_Colecciones
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }
        public float PromedioGoles
        {
            get { return (partidosJugados == 0) ? 0 : (float)totalGoles / partidosJugados; }
        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }


        private Jugador()
        {
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre): this(dni,nombre,0,0) { }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this()   //va a reemplazar los valores del constructor sin param?
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("DNI: {0}\tNombre: {1}\tPartidos jugados: {2}\tTotal Goles: {3}\tPromedio Goles: {4}", this.dni, this.nombre, this.partidosJugados, this.totalGoles, this.PromedioGoles);
            return mensaje.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return string.Equals(j1.dni, j2.dni);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
