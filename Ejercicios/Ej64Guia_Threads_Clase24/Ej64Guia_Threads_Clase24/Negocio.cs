using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej64Guia_Threads_Clase24
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<String> clientes;

        public List<String> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }


        public Caja Caja1
        {
            get { return caja1; }
            set { caja1 = value; }
        }
        public Caja Caja2
        {
            get { return caja2; }
            set { caja2 = value; }
        }

        public Negocio(Caja c1, Caja c2)
        {
            this.caja1 = c1;
            this.caja2 = c2;
            this.clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach(String cliente in this.clientes)
            {
                if(caja1.FilaClientes.Count<caja2.FilaClientes.Count)
                    this.caja1.FilaClientes.Add(cliente);
                else
                    this.caja2.FilaClientes.Add(cliente);
                Thread.Sleep(1000);
            }
            
            //if (Thread.CurrentThread != null && Thread.CurrentThread.IsAlive) 
            //{ Thread.CurrentThread.Abort(); }


        }
    }
}
