using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroBaseDeDatos
{
    public class Cliente
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

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private DateTime? fechaNacimiento;

        public DateTime? FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private List<Mascota> mascotas;

        public List<Mascota> Mascotas
        {
            get { return mascotas; }
            set { mascotas = value; }
        }

        public Cliente(int id, string nombre, string apellido, string dni, DateTime? fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.mascotas = new List<Mascota>();
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("ID: {0}", this.id);
            mensaje.AppendFormat("\tNombre: {0}", this.Nombre);
            mensaje.AppendFormat("\tApellido: {0}", this.Apellido);
            mensaje.AppendFormat("\tDNI: {0}", this.dni);
            mensaje.AppendFormat("\tFecha Nacimiento: {0:dd/MM/yy}", this.fechaNacimiento);

            return mensaje.ToString(); 
        }






    }
}
