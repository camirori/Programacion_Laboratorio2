using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej33Guia_Encapsulamiento
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if (i < this.paginas.Count && i >= 0)
                    return this.paginas[i];
                else
                    return String.Empty;
            }
            set
            {
                if(i>=0)
                {
                    if (i < this.paginas.Count)
                        this.paginas[i]= value;             //reemplaza lo que ya està
                    else if(i>= this.paginas.Count) 
                        this.paginas.Add(value);
                }
            }
        }
    }
}

//El indexador leerá la página pedida, siempre y cuando el subíndice se encuentre dentro de un rango correcto, sino retornará un string vacio “”. 
//En el set, la asignará si esta ya existe.Si el índice es superior al máximo existente, agregará una nueva página.