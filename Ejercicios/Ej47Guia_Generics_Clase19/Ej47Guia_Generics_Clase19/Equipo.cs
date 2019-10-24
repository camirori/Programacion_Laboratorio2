using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej47Guia_Generics_Clase19
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.fechaCreacion = DateTime.Today;
        }

        public static bool operator ==(Equipo eq1,Equipo eq2)
        {
            if (eq1.nombre == eq2.nombre && DateTime.Equals(eq1.fechaCreacion, eq2.fechaCreacion))
                return true;
            else
                return false;
        }
        public static bool operator !=(Equipo eq1, Equipo eq2)
        {
            return !(eq1 == eq2);
        }

        public string Ficha()
        {
            StringBuilder mensaje = new StringBuilder("\n");
            mensaje.AppendFormat("{0} fundado el {1:dd/MM/yy}",this.nombre,this.fechaCreacion);
            return mensaje.ToString();
        }
    }
}
