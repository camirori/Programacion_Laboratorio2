using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Campos
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Propiedades
        public Producto this[Guid codigo]
        {
            get
            {
                foreach(Producto producto in this.productos)
                {
                    if ((Guid)producto == codigo)
                    {
                        return producto;
                    }
                }
                return null;
            }
        }
        #endregion

        #region Metodos
        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();
            foreach(Producto producto in productos)
            {
                diccionario.Add((Guid)producto, producto.Descripcion);
            }
            return diccionario;
        }
        public string ListarVentas()
        {
            StringBuilder mensaje = new StringBuilder();
            this.ventas.Sort(compararFecha);
            foreach(Venta venta in this.ventas)
            {
                mensaje.Append(venta.ObtenerDescripcionBreve());
            }
            return mensaje.ToString();
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        public void Vender(Producto producto,int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }

        public static bool operator ==(Comiqueria comiqueria,Producto producto)
        {
            foreach(Producto prodExistente in comiqueria.productos)
            {
                if (prodExistente.Descripcion == producto.Descripcion)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria!=producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        #endregion

        private static int compararFecha(Venta venta1,Venta venta2)
        {
            return DateTime.Compare(venta1.Fecha, venta2.Fecha);
        }
    }
}
