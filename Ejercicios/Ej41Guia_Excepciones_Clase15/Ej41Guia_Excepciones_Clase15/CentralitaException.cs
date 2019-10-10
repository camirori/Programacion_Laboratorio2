using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej41Guia_Excepciones_Clase15
{
    class CentralitaException: Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreMetodo
        {
            get { return nombreMetodo; }
            set { nombreMetodo = value; }
        }


        public string NombreClase
        {
            get { return nombreClase; }
            set { nombreClase = value; }
        }

        public CentralitaException(string mensaje, string clase, string metodo):this(mensaje,clase,metodo,)
        {

        }
        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException): base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

    }
}
