using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;   //b

        //constructores
        static Dolar()  //e
        {
            new Dolar(0, 1);
        }
        public Dolar(double cantidad)
        {
            new Dolar(cantidad, 1);
        }
        public Dolar(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;    //la cotiz es de la clase, no de this
        }

        //Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()    //b
        {
            return cotizRespectoDolar;      //no se usa this porque va a devolver la cotiz de la clase
        }

        //c
        //Explicit operator
        public static explicit operator Euro (Dolar d)
        {
            double cantidad = d.cantidad * Euro.GetCotizacion();
            Euro nuevo = new Euro(cantidad);
            return nuevo;
        }
        public static explicit operator Pesos (Dolar d)
        {
            double cantidad = d.cantidad * Pesos.GetCotizacion();
            Pesos nuevo = new Pesos(cantidad);
            return nuevo;
        }
        //Implicit operator
        public static implicit operator Dolar (double d)
        {
            Dolar retorno = new Dolar(d);     //d es la cantidad
            return retorno;
        }

        //a  sumar, restar y comparar



    }
}
