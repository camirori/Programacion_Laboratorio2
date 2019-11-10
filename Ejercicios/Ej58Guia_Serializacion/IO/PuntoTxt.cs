using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<String>
    {
        public bool Guardar(string ruta, string objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                using (StreamWriter sw = new StreamWriter(ruta)) 
                { 
                    sw.WriteLine(objeto); 
                }
                return true;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool GuardarComo(string ruta, string objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, false);                   //no valida que ya exista el archivo, lo va a crear después, valida solo que el nombre del archivo a crear tenga la ext correcta
                if (!Directory.Exists(Path.GetDirectoryName(ruta)))
                    throw new DirectoryNotFoundException();
                using (StreamWriter sw = new StreamWriter(ruta)) 
                { 
                    sw.WriteLine(objeto); 
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string Leer(string ruta)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                string linea;
                string info = "";
                using (StreamReader str = new StreamReader(ruta))
                {
                    while ((linea = str.ReadLine()) != null)
                    { info += (linea + "\n"); }
                }
                return info;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia) && Path.GetExtension(ruta) == ".txt")   //ruta.EndsWith(".txt")
                    return true;
                else
                    throw new ArchivoIncorrectoException("El archivo no es un txt.");
            }
            catch (FileNotFoundException e)
            {

                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }
        }
    }
}
