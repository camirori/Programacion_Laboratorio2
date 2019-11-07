using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroBaseDeDatos
{
    public class Mascota
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int idHumano;

        public int MyProperty
        {
            get { return idHumano; }
            set { idHumano = value; }
        }


    }
}
