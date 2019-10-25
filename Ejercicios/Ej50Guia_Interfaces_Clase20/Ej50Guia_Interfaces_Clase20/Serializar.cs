using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej50Guia_Interfaces_Clase20
{
    class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(Task obj)
        {
            return true;
        }
        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto Leído",typeof(V));
        }
    }
}
