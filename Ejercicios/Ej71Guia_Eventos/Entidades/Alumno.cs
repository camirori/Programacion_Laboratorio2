using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string fotoAlumno;

        public string RutadeLaFoto
        {
            get { return fotoAlumno; }
            set { fotoAlumno = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fotoAlumno = ruta;
        }

    }
}
