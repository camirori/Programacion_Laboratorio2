using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Campos
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get { return this.descripcion; }
        }
        public double Precio
        {
            get { return this.precio; }
        }
        public int Stock
        {
            get { return this.stock; }
            set {
                if (value>=0){
                    this.stock = value;     
                }
            }
        }
        #endregion

        #region Metodos
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\n\nDescripción: {0} {1}",this.GetType(),this.Descripcion);
            mensaje.AppendFormat("\nCódigo: {0}", this.codigo);
            mensaje.AppendFormat("\nPrecio: ${0:0.00}", this.Precio);
            mensaje.AppendFormat("\nStock: {0} unidades", this.Stock);
            return mensaje.ToString();
        }
        #endregion
    }
}
