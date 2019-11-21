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
    public partial class FrmAltaAlumno : Form
    {
        Entidades.Alumno alumno;
        public event FrmDatosAlumno.ActualizarAlumnoDelegado ActualizarAlumnoEvento;

        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void lblFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            txtFoto.Text = openFileDialog.FileName;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            alumno = new Entidades.Alumno(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDni.Text), txtFoto.Text);
            ActualizarAlumnoEvento(alumno);
        }
    }
}
