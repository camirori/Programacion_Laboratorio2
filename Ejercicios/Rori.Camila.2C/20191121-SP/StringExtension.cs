using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191121_SP
{
    public static class StringExtension
    {
        public static string EstadoSimulacion(this String obj , bool estado)
        {
            if (estado == true)
                return "Orbitando";
            return "Detenido";
        }

    }
}
