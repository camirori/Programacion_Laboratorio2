using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;   //b
        #endregion

        #region Constructores
        static Pesos()  //e
        {
            cotizRespectoDolar = 38.33;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion): this(cantidad)
        {
            cotizRespectoDolar = cotizacion;    //la cotiz es de la clase, no de this
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()    //b
        {
            return cotizRespectoDolar;      //no se usa this porque va a devolver la cotiz de la clase
        }
        public static void SetCotizacion(double cotizacion)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Sobrecargas
        //c
        //Explicit operator
        public static explicit operator Dolar(Pesos d)
        {
            double cantidad = d.cantidad / Pesos.GetCotizacion();
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

        //a  sumar, restar y comparar
        public static bool operator ==(Pesos p, Dolar d) //comparo cantidades
        {
            return (d == p);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return e == p;
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(d == p);
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(e == p);
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return (Pesos)(d + p);
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return (Pesos)((Dolar)p - (Pesos)d);
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return p + (Dolar)e;
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return p - (Dolar)e;
        }
        #endregion

    }
}
