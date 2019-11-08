﻿using System;
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
            

            //linea = str.ReadLine();
            //while (linea != null)
            //{
            //    info += (linea + "\n");
            //    linea = str.ReadLine();
            //}
            //str.Close();

            using(StreamReader str = new StreamReader(ruta))
            {
                while ((linea = str.ReadLine()) != null)
                {
                    info += (linea + "\n");
                }
            }

            return info;
        }

    }
}
