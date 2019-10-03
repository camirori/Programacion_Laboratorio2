using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        #region Campos
        private double altura;
        #endregion

        #region Metodos
        public Figura(int stock, double precio, double altura)
            :this("Figura "+altura.ToString()+" cm", stock,precio,altura){}

        public Figura(string descripcion, int stock, double precio, double altura)
            :base(descripcion,stock,precio)
        {
            this.altura = altura;
        }
        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder(base.ToString());
            mensaje.AppendFormat("\nAltura: {0:0.00} cm", this.altura);

            return mensaje.ToString();
        }
        #endregion
    }
}
