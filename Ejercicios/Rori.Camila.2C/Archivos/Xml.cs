using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Archivos
{
    public class Xml<T>: IFiles<T>
    {
        /// <summary>
        /// retornará la ruta al escritorio
        /// </summary>
        public static string GetDirectoryPath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }
        }

        /// <summary>
        ///  comprobará si el archivo existe o no
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        public bool FileExists(string nombreArchivo)
        {
            if (File.Exists(GetDirectoryPath + nombreArchivo))
                return true;
            return false;
        }

        /// <summary>
        /// Guarda un Objecto en un archivo XML
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="objeto"></param>
        public void Guardar(string nombreArchivo, T objeto)
        {
            this.Guardar(nombreArchivo, objeto, System.Text.Encoding.UTF8);
        }
        /// <summary>
        /// Guarda un Objecto en un archivo XML
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="objeto"></param>
        /// <param name="encoding"></param>
        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(GetDirectoryPath + nombreArchivo, encoding);
                if (!Directory.Exists(GetDirectoryPath))
                    throw new DirectoryNotFoundException();
                try
                {
                    writer = new XmlTextWriter(GetDirectoryPath + nombreArchivo, encoding);
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, objeto);
                }
                catch (Exception ex)
                {
                    throw new ErrorArchivosException("Se produjo un error al serializar", ex);
                }
                finally
                {
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("Se produjo un error al serializar", ex);
            }

        }
        /// <summary>
        /// Lee un Objecto de un archivo XML
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Leer(string nombreArchivo, out T objeto)
        {

            return this.Leer(nombreArchivo, out objeto, System.Text.Encoding.UTF8);
        }
        /// <summary>
        /// Lee un Objecto de un archivo XML
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="objeto"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {

            XmlTextReader reader = new XmlTextReader(GetDirectoryPath + nombreArchivo);

            try
            {
                if (!File.Exists(GetDirectoryPath + nombreArchivo))
                    throw new ErrorArchivosException("El archivo no existe");
                XmlSerializer ser = new XmlSerializer(typeof(T));
                    objeto = (T)ser.Deserialize(reader);
            }
            catch (Exception ex)
            {
                    throw new ErrorArchivosException("Se produjo un error al deserializar", ex);
            }
            finally
            {
                reader.Close();
            }

            
            return true;

        }

    }
}
