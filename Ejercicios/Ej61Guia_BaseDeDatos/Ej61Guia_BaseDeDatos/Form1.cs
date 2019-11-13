using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej61Guia_BaseDeDatos
{
    public partial class Form1 : Form
    {
        int idItemSeleccionado;
        
        public Form1()
        {
            InitializeComponent();
            ActualizarLista();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            idItemSeleccionado=PersonaDAO.Guardar(txtNombre.Text, txtApellido.Text);
            //queda como seleccionado el último elemento generado
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Persona persona = (Persona)lstPersonas.SelectedItem; uso el id de item seleccionado con doble click
            PersonaDAO.Modificar(txtNombre.Text, txtApellido.Text, idItemSeleccionado);

            /*btnModificar actualizará la información de la Persona que se seleccionó con doble click en el ListBox*/
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //Persona persona = (Persona)lstPersonas.SelectedItem;
            PersonaDAO.Borrar(idItemSeleccionado);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

            ActualizarLista();
        }

        private void lstPersonas_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = ((Persona)lstPersonas.SelectedItem).Nombre;
            txtApellido.Text = ((Persona)lstPersonas.SelectedItem).Apellido;
            idItemSeleccionado= ((Persona)lstPersonas.SelectedItem).Id;

        }

        public void ActualizarLista()
        {
            lstPersonas.DataSource = PersonaDAO.Leer();
        }


    }
}

/*i. ListBox mostrará la lista de Personas devuelta por el método Leer de Persona, 
 * invocado al presionar el botón btnLeer. 
 * ii. btnModificar actualizará la información de la Persona que se seleccionó con doble click 
 * en el ListBox. 
 * iii. Al hacer doble click sobre una persona, esta se deberá cargar en los TextBox. 
 * iv. btnGuardar agregará una Persona en la base de datos. 
 * v. btnEliminar borrará de la base a la persona seleccionada en el ListBox.
*/