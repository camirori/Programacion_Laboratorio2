using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        short horas = 0;
        short minutos = 0;
        short segundos = 0;
        Thread hilo;
        private delegate void Callback();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.hilo == null || !this.hilo.IsAlive)
            {
                this.hilo = new Thread(new ThreadStart(ActualizarCronometro));
                this.hilo.Start();
                btnIniciar.Text = "Detener";
            }
            else
            {
                this.hilo.Abort();
                btnIniciar.Text = "Iniciar";
            }
            
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            horas = 0;
            minutos = 0;
            segundos = 0;
            ActualizarLabel();
        }

        

        private void ActualizarLabel()
        {
            if (this.lblCronometro.InvokeRequired)
            {
                this.lblCronometro.Invoke(new Callback(this.ActualizarLabel));
            }
            else
            {
                this.lblCronometro.Text = string.Format("{0:00} : {1:00} : {2:00}", horas, minutos, segundos);
            }
        }

        public void ActualizarCronometro()
        {
            while (true)
            {
                
                segundos++;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                    if (minutos == 60)
                    {
                        minutos = 0;
                        horas++;
                    }
                }
                this.ActualizarLabel();
                Thread.Sleep(1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo != null && this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }
    }
}
