using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej61Guia_BaseDeDatos
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;



        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public Persona(int id, string nombre, string apellido):this(nombre,apellido)
        {
            this.Id = id;
            
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }


        public override string ToString()
        {
            String datos = string.Format("{0}, {1}", this.apellido, this.nombre);
            return datos;
        }
    }
}
