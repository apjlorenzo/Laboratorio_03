﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_03
{
    public class ClienteRegular : Cliente
    {
        public ClienteRegular(string nombre, string correo, string direccion) : base(nombre, correo, direccion)
        {
        }
    }
}
