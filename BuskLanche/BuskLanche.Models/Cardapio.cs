using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuskLanche.Models
{
    public class Cardapio
    {
        public int Id { get; set; }

        public Comercio Comercio { get; set; }

        public string Nome { get; set; }

        public string Ingrediente { get; set; }

        public decimal Preco { get; set; }
    }
}

