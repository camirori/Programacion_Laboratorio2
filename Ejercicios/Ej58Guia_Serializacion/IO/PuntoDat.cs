using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat: Archivo,IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                using (FileStream fs = new FileStream(ruta, FileMode.OpenOrCreate))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, objeto);  
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            try
            {
                this.ValidarArchivo(ruta, false);                   //no valida que ya exista el archivo, lo va a crear después, valida solo que el nombre del archivo a crear tenga la ext correcta
                if (!Directory.Exists(Path.GetDirectoryName(ruta))) 
                    throw new DirectoryNotFoundException();
                using (FileStream fs = new FileStream(ruta, FileMode.Create))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, objeto); 
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public PuntoDat Leer(string ruta)
        {
            try
            {
                this.ValidarArchivo(ruta, true);
                PuntoDat aux = new PuntoDat();
                using (FileStream fs = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    aux = (PuntoDat)ser.Deserialize(fs);
                }
                return aux;
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
                if (base.ValidarArchivo(ruta, validaExistencia) && Path.GetExtension(ruta) == ".dat")   //ruta.EndsWith(".dat")
                    return true;
                else
                    throw new ArchivoIncorrectoException("El archivo no es un dat.");
            }
            catch (FileNotFoundException e)
            {

                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }
        }
    }
}
