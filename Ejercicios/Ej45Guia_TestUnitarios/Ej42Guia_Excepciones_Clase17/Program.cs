using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42Guia_Excepciones_Clase17
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseC test = new ClaseC();
            try
            {
                test.MetodoInstancia();
            }
            catch(MiException e)
            {
                Exception exception = new Exception();
                exception = e;
                do
                {
                    Console.WriteLine(exception.Message);
                    exception = exception.InnerException;
                } while (exception != null);
            }

            Console.ReadKey();
        }
    }
}
