﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52Guia_Interfaces_Clase21
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }
    }
}
