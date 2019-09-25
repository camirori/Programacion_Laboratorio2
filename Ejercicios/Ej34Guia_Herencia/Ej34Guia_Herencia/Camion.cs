using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34Guia_Herencia
{
    public class Camion: VehiculoTerrestre
    {
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int carga)
            : base(cantidadRuedas,cantidadPuertas,color,cantidadMarchas)
        {
            this.pesoCarga = carga;
        }
    }
}
