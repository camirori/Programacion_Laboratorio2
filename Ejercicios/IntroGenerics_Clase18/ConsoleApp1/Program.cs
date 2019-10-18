using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nuevaClase;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensaje<int,Auto> mensaje = new Mensaje<int, Auto>();
        }
    }

    public class Auto
    { }
}
