using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BiblioClases
{
    public static class Archivador
    {
        public static void GuardarTexto(string path, string archivo, string contenido, bool anexa)
        {
            if (Directory.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path+"\\"+archivo,anexa);
                writer.WriteLine(contenido);
                writer.Close();
            }
            else
                throw new Exception("La ruta no existe");
            
        }
        public static string LeerTexto(string ruta)
        {
            if(File.Exists(ruta))
            {
                StreamReader reader = new StreamReader(ruta);
                string mensaje=reader.ReadToEnd();
                reader.Close();
                return mensaje.ToString();
            }
            else
                throw new Exception("La ruta no existe");
        }

    }
}
