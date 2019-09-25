using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej33Guia_Encapsulamiento
{
    class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get
            {
                if (i < paginas.Count() && i >= 0)
                    return paginas[i];
                else
                    return "";
            }
            set
            {
                if (i < paginas.Count() && i >= 0)
                    paginas[i] = value;
                else if(i> paginas.Count())
                    paginas.Add(value);
            }
        }
    }
}

//El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango correcto, sino retornará un string vacio “”. 
//En el set, la asignará si esta ya existe.Si el índice es superior al máximo existente, agregará una nueva página.