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

namespace WindowsFormsApp2
{
    public partial class HilosForm : Form
    {
        private delegate void Callback(object obj);

        public HilosForm()
        {
            InitializeComponent();
        }

        private void buttonEscribir_Click(object sender, EventArgs e)
        {
            this.richTextBoxTexto.Text += this.textBoxEscribir.Text + "\n";
            this.textBoxEscribir.Clear();
        }

        private void HilosForm_Load(object sender, EventArgs e)
        {
            //Thread hilo = new Thread(new ThreadStart(Contar));
            Thread hilo = new Thread(new ParameterizedThreadStart(ContarASaltos));
            
            hilo.Start(5);
        }

        //private void Contar()
        //{
        //    while(true)
        //    {
        //        this.ActualizarLabel();
        //        Thread.Sleep(1000);
        //    }
        //}

        private void ActualizarLabel()
        {
            if (this.labelContador.InvokeRequired)
            {
                Callback callback = new Callback(this.ActualizarLabel);
                this.labelContador.Invoke(callback);
            }
            else
            {
                this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + 1).ToString();
            }
        }


        private void ContarASaltos(object cantidadASaltar)
        {
            while (true)
            {
                this.ActualizarLabel(cantidadASaltar);
                Thread.Sleep(1000);
            }
        }

        private void ActualizarLabel(object cantidadASaltar)
        {
            if (this.labelContador.InvokeRequired)
            {
                object[] parametros = new object[] { cantidadASaltar };
                this.labelContador.Invoke(new Callback(this.ActualizarLabel), parametros);
            }
            else
            {
                this.labelContador.Text = (Convert.ToInt32(this.labelContador.Text) + (int)cantidadASaltar).ToString();
            }
        }

    }
}
