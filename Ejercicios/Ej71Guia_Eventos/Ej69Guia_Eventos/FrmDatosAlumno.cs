using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Ej69Guia_Eventos
{
    public partial class FrmDatosAlumno : Ej69Guia_Eventos.FrmAltaAlumno
    {
        public delegate void ActualizarAlumnoDelegado(Entidades.Alumno alumno);
        public FrmDatosAlumno()
        {
            InitializeComponent();
        }

        public void ActualizarAlumno(Entidades.Alumno alumno)
        {
            this.txtApellido.Text = alumno.Apellido;
            this.txtNombre.Text = alumno.Nombre;
            this.txtDni.Text = alumno.Dni.ToString();
            this.txtFoto.Text = alumno.RutadeLaFoto;
            this.pictureBox1.ImageLocation = alumno.RutadeLaFoto;
            this.pictureBox1.Load();
        }
    }
}
