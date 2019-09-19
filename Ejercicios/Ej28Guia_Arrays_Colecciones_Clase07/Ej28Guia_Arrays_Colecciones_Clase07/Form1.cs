using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej28Guia_Arrays_Colecciones_Clase07
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            string texto = rTxtBx.Text;
            string[] arrayPalabras = texto.Split(' ');
            for(int i=0;i<arrayPalabras.Length;i++)
            {
                if (diccionario.ContainsKey(arrayPalabras[i]))
                    diccionario[arrayPalabras[i]] = ++diccionario[arrayPalabras[i]]; //diccionario[arrayPalabras[i]]++
                else
                    diccionario.Add(arrayPalabras[i], 1);
            }

            diccionario.OrderByDescending();
            int top = 0;
            StringBuilder mensaje = new StringBuilder("");
            foreach(KeyValuePair<string,int> palabra in diccionario)
            {
                mensaje.AppendFormat("{0}\t{1}\n", palabra.Key, palabra.Value);
                top++;
                if (top > 2)
                    break;
            }

            MessageBox.Show(mensaje.ToString());

        }

        private int ordenar(KeyValuePair<string,int> clave, int i)
        {

        }


    }

}

//convierto el diccionario en lista para ordenarlo

    