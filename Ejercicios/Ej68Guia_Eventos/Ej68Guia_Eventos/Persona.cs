using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej68Guia_Eventos
{
    class Persona
    {
        private string nombre;
        private string apellido;
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

        }
        public string Mostrar()
        {
            return this.Apellido + ", " + this.Nombre;
        }

    }

    public delegate void DelegadoString(string msg);
}
