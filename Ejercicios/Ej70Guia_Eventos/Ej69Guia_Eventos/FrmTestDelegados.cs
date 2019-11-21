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
        public event FrmMostrar.ActualizarDelegado BtnActualizar;
        public event FrmMostrar.ActualizarDelegado BtnActualizarFoto;
        private string rutaFoto;
        public FrmTestDelegados()
        {
            InitializeComponent();
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.BtnActualizar(txtDatos.Text);
            this.BtnActualizarFoto(rutaFoto);

        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            rutaFoto = this.openFileDialog1.FileName;

        }
    }
}
