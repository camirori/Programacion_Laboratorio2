﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Producto producto;
        Comiqueria comiqueria;

        public VentasForm(Producto producto,Comiqueria comiqueria)
        {
            InitializeComponent();
            this.producto = producto;
            this.comiqueria = comiqueria;
            ActualizarPrecio();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(numericUpDownCantidad.Value>producto.Stock)
            {
                MessageBox.Show("Superó el stock disponible. Modifique la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comiqueria.Vender(producto, Convert.ToInt32(numericUpDownCantidad.Value));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
                
        }

        private void ActualizarPrecio()
        {
            double precio = Venta.CalcularPrecioFinal(producto.Precio, Convert.ToInt32(numericUpDownCantidad.Value));
            lblPrecioFinalValor.Text = precio.ToString("0.00");
        }
    }
}
