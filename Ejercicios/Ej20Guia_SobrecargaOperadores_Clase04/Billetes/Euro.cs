using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;   //b

        //constructores
        static Euro()  //e
        {
            new Euro(0, 0.8620);
        }
        public Euro(double cantidad)
        {
            new Euro(cantidad, 0.8620);
        }
        public Euro(double cantidad, double cotizacion)
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
        public static explicit operator Dolar(Euro d)
        {
            double cantidad = d.cantidad * Dolar.GetCotizacion();
            Dolar nuevo = new Dolar(cantidad);
            return nuevo;
        }
        public static explicit operator Pesos(Euro d)
        {
            Dolar bufferDolar = (Dolar)d;
            Pesos nuevo = (Pesos)bufferDolar;
            return nuevo;
        }
        //Implicit operator
        public static implicit operator Euro(double d)
        {
            Euro retorno = new Euro(d);     //d es la cantidad
            return retorno;
        }
    }
}
