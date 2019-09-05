using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {
        #region Propiedades
        private string codigoDeBarra;
        private string marca;
        private float precio;       //como muestro siempre 2 decimales?
        #endregion

        #region Get
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        #endregion

        #region Constructores
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        #endregion

        #region Metodos
        public static string MostrarProducto(Producto p)
        {
            return String.Format("\nCodigo de barra: {0}\n" +
                    "Marca: {1} \nPrecio: {2:#.00}\n", (string)p, p.GetMarca(), p.GetPrecio()); ;
        }
        #endregion

        #region Sobrecarga
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
                return true;
            else
                return false;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                return true;
            else
                return false;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }


        #endregion



    }
}
