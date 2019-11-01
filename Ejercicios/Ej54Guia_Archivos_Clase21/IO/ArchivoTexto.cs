using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string ruta, string info)
        {
            using (StreamWriter str = new StreamWriter(ruta, true))
            {
                str.WriteLine(info);
            }
        }
        public static string Leer(string ruta)
        {
            string info = "";
            string linea = "";
            if(!File.Exists(ruta))
                throw new FileNotFoundException();
            StreamReader str = new StreamReader(ruta);
            while(true)
            {
                linea = str.ReadLine();
                if (linea != null)
                    info += (linea + "\n");
                else
                    break ;
            }
            str.Close();
            return info;
        }

    }
}
