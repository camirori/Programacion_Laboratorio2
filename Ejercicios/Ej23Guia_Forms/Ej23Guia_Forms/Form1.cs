using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ej23Guia_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertEuro_Click(object sender, EventArgs e)
        {
            Euro input = new Euro(Convert.ToDouble(txtEuroIn.Text));
            txtEuroEuro.Text = input.GetCantidad().ToString("0.00");
            txtEuroDolar.Text = ((Dolar)input).GetCantidad().ToString("0.00");
            txtEuroPeso.Text = ((Pesos)input).GetCantidad().ToString("0.00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCotiDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotiEuro.Text = Euro.GetCotizacion().ToString();
            txtCotiPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void BtnConvertDolar_Click(object sender, EventArgs e)
        {
            Dolar input = new Dolar(Convert.ToDouble(txtDolarIn.Text));
            txtDolarDolar.Text = input.GetCantidad().ToString("0.00");
            txtDolarEuro.Text = ((Euro)input).GetCantidad().ToString("0.00");
            txtDolarPeso.Text = ((Pesos)input).GetCantidad().ToString("0.00");
        }

        private void BtnConvertPeso_Click(object sender, EventArgs e)
        {
            Pesos input = new Pesos(Convert.ToDouble(txtPesoIn.Text));
            txtPesoPeso.Text = input.GetCantidad().ToString("0.00");
            txtPesoDolar.Text = ((Dolar)input).GetCantidad().ToString("0.00");
            txtPesoEuro.Text = ((Euro)input).GetCantidad().ToString("0.00");
        }

        private void BtnLockCoti_Click(object sender, EventArgs e)
        {
            if(btnLockCoti.Text == "C")
            {
                btnLockCoti.Text = "A";
                txtCotiDolar.Enabled = true;
                txtCotiEuro.Enabled = true;
                txtCotiPeso.Enabled = true;
            }
            else if (btnLockCoti.Text == "A")
            {
                btnLockCoti.Text = "C";
                txtCotiDolar.Enabled = false;
                txtCotiEuro.Enabled = false;
                txtCotiPeso.Enabled = false;
            }
        }

        private void TxtCotiEuro_Leave(object sender, EventArgs e)
        {
            double coti;
            if (Double.TryParse(txtCotiEuro.Text,out coti))
                Euro.SetCotizacion(coti);
            else
                txtCotiEuro.Focus();
        }

        private void TxtCotiDolar_Leave(object sender, EventArgs e)
        {
            double coti;
            if (Double.TryParse(txtCotiDolar.Text, out coti))
                Dolar.SetCotizacion(coti);
            else
                txtCotiDolar.Focus();
        }



        private void TxtCotiPeso_Leave(object sender, EventArgs e)
        {
            double coti;
            if (Double.TryParse(txtCotiPeso.Text, out coti))
                Pesos.SetCotizacion(coti);
            else
                txtCotiPeso.Focus();
        }
    }
}
