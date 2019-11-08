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
        string path = Environment.CurrentDirectory;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] palabras = richTextBox1.Text.Split(' ');
            toolStripStatusLabel1.Text= palabras.Length.ToString(); 
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".txt";
            dialog.InitialDirectory = path;
                       
            if(DialogResult.OK == dialog.ShowDialog())  //si click cancel no entra
            {
                this.path = dialog.FileName;
                richTextBox1.Text=ArchivoTexto.Leer(path);
            }
                
            richTextBox1.Focus();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e) //guardar
        {
            if (this.path == null)
                GuardarComo();
            else
                ArchivoTexto.Guardar(this.path, richTextBox1.Text);
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e) // guardar como
        {
            GuardarComo();
        }

        public void GuardarComo()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = this.path;
            if(DialogResult.OK==dialog.ShowDialog())    
                ArchivoTexto.Guardar(dialog.FileName, richTextBox1.Text);
        }
    }
}

//Que se cierre el menu