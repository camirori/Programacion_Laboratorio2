using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;   //b
        #endregion

        #region Constructores
        static Euro()  //e
        {
            cotizRespectoDolar = 0.8620;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion): this(cantidad)
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
        #endregion

        #region Sobrecarga
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

        //a  sumar, restar y comparar
        public static bool operator ==(Euro e, Dolar d) //comparo cantidades
        {
            return (d == e);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return ((Pesos)e).GetCantidad() == p.GetCantidad();
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(d == e);
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return (Euro)(d + e);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return (Euro)((Dolar)e - (Euro)d);
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return (Euro)(e + (Dolar)p);
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return (Euro)(e - (Dolar)p);
        }
        #endregion

    }
}
