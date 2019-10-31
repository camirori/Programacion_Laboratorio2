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
            this.central = central;
        }

        public Llamada.TipoLlamada FacturarTipoLlamada
        {
            set {
                this.tipoLlamada = value;
                this.CalcularGanancias(value);
            }

        }
        public void CalcularGanancias(Llamada.TipoLlamada tipoLlamada)
        {
            float ganacia;
            switch(tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    ganacia= this.central.GananciasPorLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    ganacia = this.central.GananciasPorProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                default:
                    ganacia = this.central.GananciasPorTotal;
                    break;
            }
            rTxtFacturacion.Text = String.Format("Ganacia por tipo de llamada {0}: {1:0.00}", tipoLlamada, ganacia);
        }


    }
}
