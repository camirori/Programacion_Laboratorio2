using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Ej57Guia_Serializacion_Clase22
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(Persona p)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory ;
            //serializar en archivo
            try
            {
                //XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8);
                //XmlSerializer ser = new XmlSerializer(typeof(Persona));
                //ser.Serialize(writer, p);
                //writer.Close();
                //return true;
                if (!Directory.Exists(ruta))
                    throw new DirectoryNotFoundException();
                using (XmlTextWriter writer = new XmlTextWriter(ruta + "Archivo" + ".xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Persona));
                    ser.Serialize(writer, p);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static Persona Leer()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "Archivo" + ".xml";

            //deserialice un archivo y retorne una Persona
            //Persona buffer = new Persona();
            //XmlTextReader reader = new XmlTextReader(ruta);
            //XmlSerializer ser = new XmlSerializer(typeof(Persona));
            //buffer = (Persona)ser.Deserialize(reader);
            //reader.Close();
            try
            {
                if (!File.Exists(ruta))
                    throw new FileNotFoundException();
                Persona buffer = new Persona();
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Persona));
                    buffer = (Persona)ser.Deserialize(reader);
                }
                return buffer;
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public override string ToString()
        {
            string retorno = this.nombre + " " + this.apellido + "\n";
            return retorno;
        }
    }
}
