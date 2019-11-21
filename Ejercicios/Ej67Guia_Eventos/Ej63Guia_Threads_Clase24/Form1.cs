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
using Ej67Guia_Eventos;

namespace Ej63Guia_Threads_Clase24
{
    public partial class Form1 : Form
    {
        
        //private delegate void Callback();
        Temporizador temp = new Temporizador();

        public Form1()
        {
            InitializeComponent();
            
            temp.EventoTiempo += ActualizarLabel;
            temp.Intervalo = 1;
            
        }

        

        private void ActualizarLabel()
        {
            if (this.lblHora.InvokeRequired)
            {
                Temporizador.encargadoTiempo callback = new Temporizador.encargadoTiempo(this.ActualizarLabel); //puede ser un delegado propio de la clase, callback, o el delegado del método
                this.lblHora.Invoke(callback);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"); ;
            }   
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            temp.Activo = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp.Activo = true;
        }
    }
}
