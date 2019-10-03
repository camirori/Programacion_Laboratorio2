using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        #region Campos
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        #endregion
        #region Propiedades
        internal DateTime Fecha
        {
            get { return this.fecha; }
        }
        #endregion

        #region Metodos
        static Venta()
        {
            porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            return (precioUnidad * cantidad) * (1 + porcentajeIva);
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\nfecha {0:dd/MM/yy HH:mm} -", this.fecha);
            mensaje.AppendFormat("descripción {0} -", this.producto.Descripcion);
            mensaje.AppendFormat("precioFinal {0:0.00}", this.precioFinal);

            return mensaje.ToString();
        }

        #endregion
    }
}
