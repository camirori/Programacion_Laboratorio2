using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
using CentralTelefonica;

namespace CentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        public Centralita central;

        public FrmLlamador(Centralita central)
        {
            InitializeComponent();
            this.central = central;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        public Centralita Central
        {
            get { return this.central; }
        }

        #region PanelNumerico
        private void btnNum_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
                txtNroDestino.Text = "#";
            else
                txtNroDestino.Text += "#";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "1";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "2";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "3";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "4";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "5";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "6";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "7";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "8";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "9";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "9";
        }

        private void btnAst_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "*";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "0";
                cmbFranja.Enabled = false;
            }
            else
                txtNroDestino.Text += "0";
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
            cmbFranja.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmMenu.central = central;
            this.Close();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            if(cmbFranja.Enabled)
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                Provincial nuevaLlamada = new Provincial(txtNroOrigen.Text, franjas, aleatorio.Next(0,60),txtNroDestino.Text);
                central += nuevaLlamada;
            }
            else
            {
                Local nuevaLlamada = new Local(txtNroOrigen.Text, aleatorio.Next(0,60),txtNroDestino.Text, aleatorio.Next(0,6));
                central += nuevaLlamada;
            }
            
        }
    }
}
