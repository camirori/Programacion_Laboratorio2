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

namespace CentralTelefonica
{
    public partial class FrmMenu : Form
    {
        public static Centralita central = new Centralita();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(central);
            llamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(central);
            mostrar.FacturarTipoLlamada = Llamada.TipoLlamada.Todas;
            mostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(central);
            mostrar.FacturarTipoLlamada = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProv_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(central);
            mostrar.FacturarTipoLlamada = Llamada.TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(central.Leer(), "Log llamadas");
            this.Close();
        }
    }
}
