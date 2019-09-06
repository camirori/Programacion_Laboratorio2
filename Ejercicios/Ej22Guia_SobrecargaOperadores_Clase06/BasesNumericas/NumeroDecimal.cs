using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesNumericas
{
    public class NumeroDecimal
    {
        private double numero;

        public double GetNumero()
        {
            return this.numero;
        }

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        #region Sobrecargas
        public static double operator + (NumeroDecimal d, NumeroBinario b)
        {
            
        }
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            
        }
        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            
        }
        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            
        }

        #region Conversiones
        public static explicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }
        public static implicit operator NumeroDecimal(double d)
        {
            NumeroDecimal retorno = new NumeroDecimal(d);
            return retorno;
        }

        #endregion

        #endregion
    }
}
