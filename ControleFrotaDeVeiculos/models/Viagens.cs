using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFrotaDeVeiculos.models;


namespace ControleFrotaDeVeiculos.models
{
    class Viagens
    {
        public int ID { get; set; }
        public Motorista Motorista {get; set;}
        public Veiculos Veiculos { get; set; }
        public DateTime dateViagem { get; set; }
        public DateTime dateViagemFeita { get; set; }
        public String Motivo { get; set; }
        public String Situacao { get; set; }
        public String KmInicial { get; set; }
        public String KmFinal { get; set; }
    }
}
