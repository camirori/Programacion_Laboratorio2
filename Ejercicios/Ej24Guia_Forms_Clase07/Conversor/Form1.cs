using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnidadesMedida;

namespace Conversor
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Fahrenheit input = new Fahrenheit(Convert.ToDouble(txtFIn.Text));
            txtFF.Text = txtFIn.Text;
            txtFC.Text = ((Celsius)input).GetGrados().ToString("0.##");
            txtFK.Text = ((Kelvin)input).GetGrados().ToString("0.##");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Celsius input = new Celsius(Convert.ToDouble(txtCIn.Text));
            txtCC.Text = txtCIn.Text;
            txtCF.Text = ((Fahrenheit)input).GetGrados().ToString("0.##");
            txtCK.Text = ((Kelvin)input).GetGrados().ToString("0.##");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            Kelvin input = new Kelvin(Convert.ToDouble(txtKIn.Text));
            txtKK.Text = txtKIn.Text;
            txtKF.Text = ((Fahrenheit)input).GetGrados().ToString("0.##");
            txtKC.Text = ((Celsius)input).GetGrados().ToString("0.##");
        }
    }
}
