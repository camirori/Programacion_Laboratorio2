using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesNumericas
{
    public class NumeroBinario
    {
        private string numero;

        public string GetNumero()
        {
            return this.numero;
        }

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        #region Sobrecargas
        #region Operadores
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double suma = d + Conversor.BinarioDecimal(b.numero);
            return Conversor.DecimalBinario(suma);
        }
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double resta = Conversor.BinarioDecimal(b) - d;
            return (NumeroBinario)resta;
        }
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.BinarioDecimal(b) == d;
        }
        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }
        #endregion

        #region Conversiones
        public static explicit operator string(NumeroBinario b)
        {
            return b.numero;
        }
        public static implicit operator NumeroBinario(string b)
        {
            NumeroBinario retorno = new NumeroBinario(b);
            return retorno;
        }

        #endregion

        #endregion
    }
}
