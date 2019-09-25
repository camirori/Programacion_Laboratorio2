using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej34Guia_Herencia
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas,short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
        }
    }
}
