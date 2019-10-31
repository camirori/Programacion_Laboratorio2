using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej51Guia_Interfaces_Clase21
{
    public interface IGuardar <T>
    {
        string RutaDeArchivo { get; set; }
        bool Guardar();
        T Leer();
    }
}
