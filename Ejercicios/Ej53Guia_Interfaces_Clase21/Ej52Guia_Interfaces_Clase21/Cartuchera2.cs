using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52Guia_Interfaces_Clase21
{
    public class Cartuchera2
    {
        public List<Boligrafo> boligrafos;
        public List<Lapiz> lapices;

        public Cartuchera2()
        {
            boligrafos = new List<Boligrafo>();
            lapices = new List<Lapiz>();
        }

        public bool ProbarElementos()
        {
            bool retorno = true;

            foreach (Lapiz util in lapices)
            {
                ((IAcciones)util).Escribir("1");
            }
            foreach (Boligrafo util in boligrafos)
            {
                util.Escribir("1");
                if (util.UnidadesDeEscritura <= 0)
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
