using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuskLanche.Models
{
    public class Avaliacoes
    {
        public int Id { get; set; }

        public Comercio IdComercio { get; set; }

        public Consumidor IdConsumidor { get; set; }

        public string Avalicacao { get; set; }

        public string Comertario { get; set; }
    }
}
