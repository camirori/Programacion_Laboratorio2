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

            MessageBox.Show(mensajeTop(diccionario));

        }


        private static string mensajeTop(Dictionary<string,int> diccionario)
        {
            List<int> listaValues = new List<int>(diccionario.Values);
            listaValues.Sort();
            
            int top = 0;
            StringBuilder mensaje = new StringBuilder("");
            foreach (int valor in listaValues)
            {
                mensaje.AppendFormat("{0}\t{1}\n", diccionario., palabra.Value);
                top++;
                if (top > 2)
                    break;
            }
            return mensaje.ToString();
        }
        /*
        private static int ordenar(KeyValuePair<string,int> clave, int i)
        {
            if(clave[i] > clave[i])
        }*/


    }

}

//convierto el diccionario en lista para ordenarlo

    