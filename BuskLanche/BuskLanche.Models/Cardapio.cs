﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuskLanche.Models
{
    class Cardapio
    {
        public int Id { get; set; }

        public Comercio IdComercio  { get; set; }

        public string Nome { get; set; }

        public string Ingrediente { get; set; }

        public string Preco { get; set; }

    }
}