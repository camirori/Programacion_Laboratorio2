using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual  //se llama a un numero y se pasa al siguiente, el numero es el mismo para todos los puestos
        {
            get{ return ++numeroActual; } 
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public static bool Atender(Cliente cli)    //se atiende al cliente si Puesto.NumeroActual==objCliente.Numero, debería ser de instancia para chequear el Puesto==negocio.puesto
        {
            Thread.Sleep(1000);
            return true;
        }

        public enum Puesto{ Caja1, Caja2 }

    }
}
