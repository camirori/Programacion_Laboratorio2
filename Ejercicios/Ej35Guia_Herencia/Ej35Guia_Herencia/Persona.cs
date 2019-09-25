using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej35Guia_Herencia
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\n\nDNI: {0}\tNombre: {1}", this.dni, this.nombre);
            return mensaje.ToString();
        }

        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
