using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej68Guia_Eventos
{
    public partial class FrmPersona : Form
    {
        private Persona persona;
        public event DelegadoString EventoString;
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void bnCrear_Click(object sender, EventArgs e)
        {
            if(persona==null)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                bnCrear.Text = "Actualizar";
                this.EventoString("Persona creada");
            }
            else
            {
                persona.Apellido = txtApellido.Text;
                persona.Nombre = txtNombre.Text;
                this.EventoString("Persona modificada");
            }
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio+"\n"+persona.Mostrar());
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            this.EventoString += NotificarCambio;
        }
    }

    
}
