using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFormulario
{
    public partial class TxtNombre : Form
    {
        public TxtNombre()
        {
            InitializeComponent();
        }

        private void SaludarOnClick(object sender, EventArgs e)
        {
            string Nombre= this.textBox1.Text;
            MessageBox.Show("Hola "+Nombre,"Saludo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
