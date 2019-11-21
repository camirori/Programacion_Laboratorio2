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
    public partial class FrmTestDelegados : Form
    {
        public event ActualizarDelegado BtnActualizar;
        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.BtnActualizar(txtDatos.Text);
            

        }
    }
}
