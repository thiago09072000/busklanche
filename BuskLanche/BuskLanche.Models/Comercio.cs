using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuskLanche.Models
{
    public class Comercio
    {
        public int Id { get; set; }

        public string Cnpj { get; set; }

        public string NomeComercio { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Cep { get; set; }

        public string Complemeneto { get; set; }

        public string NomeRepresentante { get; set; }

        public string EmailRepresentante { get; set; }

        public string SenhaRepresentante { get; set; }

        public string CpfRepresentante { get; set; }

        public string TelefoneRepresentante { get; set; }

        public string EstiloDoLanche { get; set; }

        public string HorarioAbertura { get; set; }

        public string HorarioEncerramento { get; set; }

        public string DescricaoComercio { get; set; }
    }
}
