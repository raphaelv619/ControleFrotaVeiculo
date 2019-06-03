using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFrotaDeVeiculos.models
{
    class Motorista
    {
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String RG { get; set; }
        public String DtNascimento { get; set; }
        public String NCNH { get; set; }
        public String ValCNH { get; set; }

        public String Rua { get; set; }
        public String Cidade { get; set; }
        public String Bairro { get; set; }
        public String CEP { get; set; }
        public String Numero { get; set; }

        public String Telefone { get; set; }
        public String Celular { get; set; }
    }
}
