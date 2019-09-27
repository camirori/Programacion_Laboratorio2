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
    public partial class FrmMostrar : Form
    {
        public Centralita central;
        private Llamada.TipoLlamada tipoLlamada;

        public FrmMostrar(Centralita central)
        {
            InitializeComponent();
        }

        public Llamada.TipoLlamada FacturarTipoLlamada
        {
            set { this.tipoLlamada = value; }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            float ganacia;
            switch(tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    ganacia= central.GananciasPorLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    ganacia = central.GananciasPorProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                default:
                    ganacia = central.GananciasPorTotal;
                    break;
            }
            rTxtFacturacion.Text = String.Format("Ganacia por tipo de llamada {0}: {1:0.00}", tipoLlamada, ganacia);
        }
    }
}
