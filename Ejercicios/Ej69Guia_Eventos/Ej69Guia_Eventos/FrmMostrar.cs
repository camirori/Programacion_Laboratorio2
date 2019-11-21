using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej69Guia_Eventos
{
    public partial class FrmMostrar : Form
    {
        
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string dato)
        {
            lblEtiqueta.Text = dato;
        }


    }
    public delegate void ActualizarDelegado(string dato);
}
