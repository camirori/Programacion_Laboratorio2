using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO;
using System.IO;

namespace Ej56Guia_Archivos
{
    public partial class Form1 : Form
    {
        string path = null;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0 caracteres";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //si fueran palabras:
            //string[] palabras = richTextBox1.Text.Split(' ');
            //toolStripStatusLabel1.Text= palabras.Length.ToString(); 

            toolStripStatusLabel1.Text = (richTextBox1.Text.Count<char>()).ToString() +" caracteres";
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.HideDropDown();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".txt";
            dialog.InitialDirectory = (this.path == null) ? AppDomain.CurrentDomain.BaseDirectory : this.path;

            if (DialogResult.OK == dialog.ShowDialog())  //si click cancel no entra
            {
                this.path = dialog.FileName;
                richTextBox1.Text=ArchivoTexto.Leer(path);
            }
            richTextBox1.Focus();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e) //guardar
        {
            toolStripMenuItem1.HideDropDown();
            if (this.path == null)  //si ya se abrió o guardó un archivo path no va a ser null
                GuardarComo();
            else
                ArchivoTexto.Guardar(this.path, richTextBox1.Text);
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e) // guardar como
        {
            toolStripMenuItem1.HideDropDown();  //Que se cierre el menu
            GuardarComo();
        }

        public void GuardarComo()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = (this.path == null) ? AppDomain.CurrentDomain.BaseDirectory : this.path;
            if (DialogResult.OK==dialog.ShowDialog())
            {
                this.path = dialog.FileName;
                ArchivoTexto.Guardar(this.path, richTextBox1.Text);
            }
                

        }
    }
}

