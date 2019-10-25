using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej50Guia_Interfaces_Clase20
{
    class GuardarTexto<T, V> : IGuardar<T, V>
    {
        public bool Guardar(Task obj)
        {
            return true;
        }
        public V Leer()
        {
            return (V)Convert.ChangeType("Texto Leído", typeof(V));
        }
    }
}
