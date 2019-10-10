using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        #region Campos
        private string autor;
        private TipoComic tipoComic;
        #endregion

        #region Metodos
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic)
            :base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder mensaje = new StringBuilder(base.ToString());
            mensaje.AppendFormat("\nAutor: {0}", this.autor);
            mensaje.AppendFormat("\nTipo Comic: {0}", this.tipoComic);
            return mensaje.ToString();
        }
        #endregion

        #region Tipos anidados
        public enum TipoComic {Occidental, Oriental}
        #endregion
    }
}
