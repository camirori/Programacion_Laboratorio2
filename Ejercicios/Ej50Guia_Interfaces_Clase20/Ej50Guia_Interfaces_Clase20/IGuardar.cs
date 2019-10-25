using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej50Guia_Interfaces_Clase20
{
    interface IGuardar<T,V>
    {
        bool Guardar(Task obj);
        V Leer();
    }
}
