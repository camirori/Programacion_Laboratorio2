using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej17Guia_C_Objetos
{
    class Boligrafo
    {
        //prop
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        //metodos
        public ConsoleColor GetColor()
        {
            ConsoleColor retorno;
            retorno = this.color;
            return retorno;
        }
        public short GetTinta()
        {
            short retorno;
            retorno = this.tinta;
            return retorno;
        }
        private void SetTinta(short tinta)
        {
            if (tinta <= cantidadTintaMaxima)
                this.tinta = tinta;
            else
                Console.WriteLine("Nivel de tinta supera el maximo");
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            float porcentaje = 0;

            if (gasto <= this.tinta)
            {
                porcentaje = ((float)gasto / this.tinta) * 10;
                this.tinta -= (short)gasto;
                retorno = true;
            }
            else
            {
                Console.WriteLine("Gasto mayor a la tinta disponible");
            }
            dibujo = new String('*', (int)porcentaje);

            return retorno;
        }
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        //constructor
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
    }
}
