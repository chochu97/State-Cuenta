﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Apagado : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Encendido());
        }

        public override string Describir()
        {
            return "Switch apagado";
        }
    }
}
