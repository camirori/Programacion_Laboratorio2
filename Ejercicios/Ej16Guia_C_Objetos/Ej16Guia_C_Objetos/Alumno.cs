using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16Guia_C_Objetos
{
    class Alumno
    {
        //prop
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        //consutructor
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        //metodos
        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random buffer = new Random();
                this._notaFinal = buffer.Next(0, 10);
            }
            else
                this._notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0} {1} \nLegajo {2}", this.nombre, this.apellido, this.legajo);
            Console.WriteLine("Nota 1: {0} \nNota 2: {1}", this._nota1, this._nota2);
            if (this._notaFinal != -1)
                Console.WriteLine("Nota final: {0}", this._notaFinal);
            else
                Console.WriteLine("Alumno desaprobado");

        }
    }
}
