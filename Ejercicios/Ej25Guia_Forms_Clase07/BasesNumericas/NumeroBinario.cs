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

        public static bool Validar(string b)
        {
            string caracteresPermitidos = "01";
            foreach(char caracter in b)
            {
                if (!caracteresPermitidos.Contains(caracter))
                    return false;
            }
            return true;
        }


        #region Sobrecargas
        #region Operadores
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double suma = (double)d + Conversor.BinarioDecimal((string)b);
            return Conversor.DecimalBinario(suma); 
        }
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double resta = Conversor.BinarioDecimal((string)b) - (double)d;
            return Conversor.DecimalBinario(resta);
        }
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.BinarioDecimal((string)b) == (double)d;
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
