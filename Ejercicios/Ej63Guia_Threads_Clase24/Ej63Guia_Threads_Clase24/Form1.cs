using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ej63Guia_Threads_Clase24
{
    public partial class Form1 : Form
    {
        private Thread hilo;
        private delegate void Callback(object o);

        public Form1()
        {
            InitializeComponent();
            hilo = new Thread(new ThreadStart(AsignarHora));
        }

        private void AsignarHora()
        {
            String hora;
            while(true)
            {
                hora = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                ActualizarLabel(hora);
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel(object o)
        {
            if (this.lblHora.InvokeRequired)
            {
                //object[] parametros = new object[] { o };
                //this.lblHora.Invoke(new Callback(this.ActualizarLabel), parametros);
                object[] parametros = new object[] { o };
                Callback callback = new Callback(this.ActualizarLabel);
                this.lblHora.Invoke(callback, parametros);
            }
            else
            {
                this.lblHora.Text = (string)o;
            }   
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo != null && this.hilo.IsAlive)  
                { this.hilo.Abort(); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hilo.Start();
        }
    }
}
