using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej64Guia_Threads_Clase24
{
    public class Caja
    {
        private List<String> filaClientes;

        public Caja()
        {
            FilaClientes = new List<string>();
        }

        public List<string> FilaClientes { get => filaClientes; set => filaClientes = value; }

        public void AtenderClientes()
        {
            foreach(String cliente in this.FilaClientes)
            {
                Console.WriteLine("\n{0} {1}", Thread.CurrentThread.Name,cliente);
            }
        }

        
    }
}
