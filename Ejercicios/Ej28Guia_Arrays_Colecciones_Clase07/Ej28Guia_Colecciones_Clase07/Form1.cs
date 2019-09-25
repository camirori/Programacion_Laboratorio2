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
            List<KeyValuePair<string, int>> listaValues = new List<KeyValuePair<string, int>>(diccionario.ToList());
            listaValues.Sort(comparar);

            // Versión Lambda del método Compare:
            //lista.Sort((x, y) => y.Value - x.Value);

            // OPCION 2: Ordenar usando LINQ y funciones lambda
            // Directamente sobre el diccionario.
            //contadorPalabras.OrderByDescending(keyValuePair => keyValuePair.Value);

            int top = 0;
            StringBuilder mensaje = new StringBuilder("");
            foreach (KeyValuePair<string, int> entrada in listaValues)
            {
                mensaje.AppendFormat("{0}\t{1}\n", entrada.Key, entrada.Value);
                top++;
                if (top > 2)
                    break;
            }
            return mensaje.ToString();
        }
        
        private static int comparar(KeyValuePair<string,int> clave1, KeyValuePair<string,int> clave2)
        {
            return clave2.Value-clave1.Value;
        }


    }

}

//convierto el diccionario en lista para ordenarlo

    