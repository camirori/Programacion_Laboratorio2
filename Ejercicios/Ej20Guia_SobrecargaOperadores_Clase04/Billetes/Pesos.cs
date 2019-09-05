using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;   //b

        //constructores
        static Pesos()  //e
        {
            new Pesos(0, 38.33);
        }
        public Pesos(double cantidad)
        {
            new Pesos(cantidad, 38.33);
        }
        public Pesos(double cantidad, double cotizacion)
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
        public static explicit operator Dolar(Pesos d)
        {
            double cantidad = d.cantidad * Dolar.GetCotizacion();
            Dolar nuevo = new Dolar(cantidad);
            return nuevo;
        }
        public static explicit operator Euro(Pesos d)
        {
            Dolar bufferDolar = (Dolar)d;
            Euro nuevo = (Euro)bufferDolar;
            return nuevo;
        }
        //Implicit operator
        public static implicit operator Pesos(double d)
        {
            Pesos retorno = new Pesos(d);     //d es la cantidad
            return retorno;
        }
    }
}
