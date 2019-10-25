using System;
using System.IO;
using System.Windows.Forms;
using BiblioClases;

namespace ArchivoLocoForm
{
    public partial class FormLoco : Form
    {
        private const string EXTENSION_VALIDA = ".txt";

        public FormLoco()
        {
            InitializeComponent();
            richTextBoxTexto.Text = "";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string contenido = richTextBoxTexto.Text;
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Archivador.GuardarTexto(path,"archivo"+EXTENSION_VALIDA,contenido,true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.OK== openFileDialog.ShowDialog())
                {
                    string archivo=openFileDialog.FileName;

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (Path.GetExtension(path+"\\"+archivo)== EXTENSION_VALIDA)
                    {
                        string mensaje = Archivador.LeerTexto(path + "\\archivo" + EXTENSION_VALIDA);
                        MessageBox.Show(mensaje);
                    }
                    else
                        MessageBox.Show("Extension no valida");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
