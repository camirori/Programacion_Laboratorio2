using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;            //para que el negocio tiene un numero de caja si no se valida al atender?
        private Queue<Cliente> cliente;
        private string nombre;

        public Cliente Cliente
        {
            get { return this.cliente.Dequeue(); }
            set                                 // solo + puede agregar un cliente?
            {
                if (this != value)
                    this.cliente.Enqueue(value);
            } 
        }
        public int ClientesPendientes
        {
            get { return this.cliente.Count(); }
        }

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.cliente = new Queue<Cliente>();
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            if (n.cliente.Contains(c))
                return true;
            else
                return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.cliente.Enqueue(c);
                return true;
            }
            else
                return false;
        }
        public static bool operator ~(Negocio n)                //no tiene en cuenta el numero de puesto del negocio y num del puesto que atiende
        {
            if (PuestoAtencion.NumeroActual == n.Cliente.Numero)
            {
                return PuestoAtencion.Atender(n.Cliente);
            }
            else
                return false;
        }

    }
}
