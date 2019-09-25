using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej35Guia_Herencia
{
    class DirectorTecnico: Persona
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        private DirectorTecnico(string nombre): base(nombre) {}
        public DirectorTecnico(string nombre, DateTime fechaNacimiento):base(nombre) //en el enunciado no dice que tenga dni como param // debería usar this?
        {
            this.fechaNacimiento = fechaNacimiento;
        }


        public new string MostrarDatos()
        {
            StringBuilder mensaje = new StringBuilder(base.MostrarDatos());
            mensaje.AppendFormat("\tFecha de nacimiento: {0}", this.fechaNacimiento);
            return mensaje.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return string.Equals(dt1.Nombre, dt2.Nombre) && dt1.fechaNacimiento==dt2.fechaNacimiento;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

    }
}
