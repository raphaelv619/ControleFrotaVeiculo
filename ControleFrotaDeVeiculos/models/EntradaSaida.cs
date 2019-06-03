using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFrotaDeVeiculos.models
{
    class EntradaSaida
    {
        public Veiculos Veiculos { get; set; }
        public Motorista Motorista { get; set; }
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public String HrEntrada { get; set; }
        public String HrSaida { get; set; }
        public String KmInicial { get; set; }
        public String KmFinal { get; set; }
    }
}
