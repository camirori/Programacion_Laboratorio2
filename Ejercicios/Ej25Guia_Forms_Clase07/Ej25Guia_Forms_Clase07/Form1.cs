using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasesNumericas;

namespace Ej25Guia_Forms_Clase07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumeroBinario.Validar(txtBinIn.Text))
                txtDecOut.Text = Conversor.BinarioDecimal(txtBinIn.Text).ToString();
            else
                txtBinIn.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double inputDecimal;
            if (Double.TryParse(txtDecIn.Text, out inputDecimal))
                txtBinOut.Text = Conversor.DecimalBinario(inputDecimal).ToString();
            else 
                txtDecIn.Focus();
        }

        private void txtBinIn_Leave(object sender, EventArgs e)
        {
            if(!NumeroBinario.Validar(txtBinIn.Text))
                txtBinIn.Focus();           
        }

        private void txtDecIn_Leave(object sender, EventArgs e)
        {
            double buffer;
            if (!Double.TryParse(txtDecIn.Text, out buffer))
                txtDecIn.Focus();
        }

        private void txtBinIn_Click(object sender, EventArgs e)
        {
            txtBinIn.SelectAll();
        }
    }
}
