using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;   //b
        #endregion

        #region Constructores
        static Dolar()  //e
        {
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion): this(cantidad)
        {
            cotizRespectoDolar = cotizacion;        //no es constante, es una variable, pero cuando se modifique impacta en toda la clase por ser estàtica
        }
        #endregion

        #region Getters + Setters
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
        public static bool operator ==(Dolar d, Euro e) //comparo cantidades
        {
            return (e.GetCantidad() == ((Euro)d).GetCantidad()) ;
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return (p.GetCantidad() == ((Pesos)d).GetCantidad());
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad() == d2.GetCantidad());
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
            return retorno;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
            return retorno;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
            return retorno;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
            return retorno;
        }
        #endregion






    }
}
