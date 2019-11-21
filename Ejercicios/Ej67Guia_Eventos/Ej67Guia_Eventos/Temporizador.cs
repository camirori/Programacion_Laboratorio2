using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej67Guia_Eventos
{
    public class Temporizador
    {
        private Thread hilo;
        private int intervalo;
        public event encargadoTiempo EventoTiempo;
        public delegate void encargadoTiempo();

        public bool Activo
        {
            get { return (this.hilo != null && this.hilo.IsAlive); }
            set 
            { 
                if(value==true)
                {
                    if(this.hilo == null || !this.hilo.IsAlive)
                    {
                        hilo = new Thread(Corriendo);
                        hilo.Start();
                    }

                }
                else
                {
                    if (this.hilo != null && this.hilo.IsAlive)
                        this.hilo.Abort();
                }
                    
            }
        }

        public int Intervalo { get => intervalo / 1000; set => intervalo = value*1000; }

        private void Corriendo()
        {
            while(true)
            {
                Thread.Sleep(this.intervalo);
                this.EventoTiempo();
            }

        }
    }
}
