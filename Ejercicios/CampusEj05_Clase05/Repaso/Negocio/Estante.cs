using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Estante
    {
        #region Propiedades
        private Producto[] productos;
        public int ubicacionEstante;
        #endregion

        #region Constructores
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        #endregion

        #region Get
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            string retorno = String.Format("Ubicacion del estante: {0}\nProductos:\n", e.ubicacionEstante);
            for(int i=0; i<e.productos.Length; i++)         //puedo usar foreach
            {
                retorno += Producto.MostrarProducto(e.productos[i]);
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga
        /// <summary>
        /// Indica si el producto se encuentra en el estante
        /// </summary>
        /// <param name="e">Objeto estante</param>
        /// <param name="p">Objeto producto</param>
        /// <returns>true/false</returns>
        public static bool operator ==(Estante e, Producto p)
        {
            if (e.productos.Contains(p))
                return true;
            else
                return false;   
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            for(int i=0; i<e.productos.Length;i++)
            {
                if(e.productos[i] is null && e!=p) //!= comparo marca y codigo, no precio
                {
                    e.productos[i] = p;     //si hay lugar agrego el producto
                    return true;
                }
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p) //== comparo marca y codigo, no precio
                {
                    e.productos[i]=null;    //si es igual lo elimino 
                    return e;
                }
            }
            return e;
        }
        #endregion


    }
}
