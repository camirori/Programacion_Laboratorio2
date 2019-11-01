﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej51Guia_Interfaces_Clase21;

namespace CentralitaHerencia
{
    public class Local: Llamada, IGuardar<Local>
    {
        protected float costo;

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        #region Metodos
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo) { }
        public Local(string origen, float duracion, string destino, float costo): base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendFormat("{0}\tCosto Llamada: {1:C}", base.Mostrar(), this.CostoLlamada);
            return mensaje.ToString();
        }

        #endregion

        #region Sobrecarga
        public override bool Equals(object obj)
        {
            return (obj is Local) ? true : false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

        #region Interfaz
        public string RutaDeArchivo { get; set; }
        public bool Guardar()
        {
            throw new NotImplementedException();
        }
        public Local Leer()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
