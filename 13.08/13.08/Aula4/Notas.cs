﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._08.Aula4
{
    internal class Notas
    {
        public float Nota01 {  get; set; }
        public float Nota02 { get; set; }

        public float CalcularMdia() => (Nota01 + Nota02) / 2;

        public string Status() => "AP";

    }
}
