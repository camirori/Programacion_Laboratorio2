using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;

namespace Ej42Guia_Excepciones_Clase17
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("yyyyMMdd-hhmm") + ".txt";

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
                    ArchivoTexto.Guardar(ruta,exception.Message);
                    exception = exception.InnerException;
                } while (exception != null);
            }

            Console.Write(ArchivoTexto.Leer(ruta));

            Console.ReadKey();
        }
    }
}
