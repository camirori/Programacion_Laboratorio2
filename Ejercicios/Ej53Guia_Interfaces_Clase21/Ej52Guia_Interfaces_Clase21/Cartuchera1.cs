using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52Guia_Interfaces_Clase21
{
    public class Cartuchera1
    {
        public List<IAcciones> cartuchera;

        public Cartuchera1()
        {
            cartuchera = new List<IAcciones>();
        }

        public bool ProbarElementos()
        {
            bool retorno= true;
            foreach(IAcciones util in cartuchera)
            {
                util.Escribir("1");
                if (util.UnidadesDeEscritura <= 0 && util.GetType()==typeof(Boligrafo))
                {
                    if (util.UnidadesDeEscritura < 0)
                        retorno = false;
                    util.Recargar(1);
                }
                    
            }

            return retorno;
        }

    }
}
