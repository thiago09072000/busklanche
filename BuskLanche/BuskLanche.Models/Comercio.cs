using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuskLanche.Models
{
    public class Comercio : Usuario
    {
        public string Cnpj { get; set; }

        public string NomeComercio { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Cep { get; set; }

        public string Complemento { get; set; }

        public string CpfRepresentante { get; set; }

        public string TelefoneRepresentante { get; set; }

        public string EstiloDoLanche { get; set; }

        public string HorarioAbertura { get; set; }

        public string HorarioEncerramento { get; set; }

        public string DescricaoComercio { get; set; }

        public string Disponibilidade
        {
            get
            {
                //Ex.: 06:00 - 18:00
                return string.Format("{0} - {1}", HorarioAbertura, HorarioEncerramento);
            }
        }

        public string Distancia { get; set; }

        public string Duracao { get; set; }

        public decimal NotaMedia { get; set; }

        public List<Cardapio> Cardapio { get; set; }

        public Comercio()
        {
            this.Cardapio = new List<Models.Cardapio>();
        }
    }
}