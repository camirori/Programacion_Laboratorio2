using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    [Serializable]
    public class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if(validaExistencia==true)
            {
                if (File.Exists(ruta))
                    return true;
                else
                    throw new FileNotFoundException();
            }
            return true;
        }
    }
}
