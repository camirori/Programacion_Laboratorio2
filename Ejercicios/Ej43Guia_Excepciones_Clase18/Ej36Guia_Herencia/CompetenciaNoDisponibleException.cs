using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej36Guia_Herencia
{
    public class CompetenciaNoDisponibleException: Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }

        public string NombreClase
        {
            get { return nombreClase; }
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo): this(mensaje,clase,metodo,null)
        {
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException): base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder("");

            mensaje.AppendFormat("Excepción en el método {0} de la clase {1}:",this.NombreMetodo,this.NombreClase);
            mensaje.AppendLine(this.Message);

            Exception inner = this.InnerException;
            while(inner!=null)
            {
                mensaje.AppendLine(inner.Message);
                inner = inner.InnerException;
            }


            return base.ToString();
        }
    }
}
