using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej57Guia_Serializacion_Clase22
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(Persona p)
        {
            //serializar en archivo
        }

        public static Persona Leer()
        {
            //deserialice un archivo y retorne una Persona
        }

        public override string ToString()
        {
            string retorno = this.nombre + " " + this.nombre;
            return retorno;
        }
    }
}
