using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej47Guia_Generics_Clase19
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }
            
            

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach(T equipoActual in torneo.equipos)
            {
                if (equipoActual == equipo)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder("\n");

            mensaje.AppendLine(this.nombre);
            foreach(T equipo in this.equipos)
            {
                mensaje.AppendLine(equipo.Ficha());
            }

            return mensaje.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random random = new Random();
            int resultado1 = random.Next(0,100);
            int resultado2 = random.Next(0,100);

            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("\n[{0}] [{1}] – [{2}] [{3}]", e1.nombre, resultado1, resultado2, e2.nombre);

            return mensaje.ToString();
        }

        public string JugarPartido()
        {
            Random indice = new Random();
            T equipo1 = this.equipos[indice.Next(this.equipos.Count)];
            T equipo2 = this.equipos[indice.Next(this.equipos.Count)];

            return this.CalcularPartido(equipo1, equipo2);
        }

    }
}
