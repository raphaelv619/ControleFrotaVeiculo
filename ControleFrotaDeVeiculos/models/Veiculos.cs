using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFrotaDeVeiculos.models;

namespace ControleFrotaDeVeiculos
{
    class Veiculos
    {
        public String Placa { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Cor { get; set; }
        public String AnoMod { get; set; }
        public String AnoFabr { get; set; }
        public String Combustivel { get; set; }
        public String Kilometragem { get; set; }
        public String Situacao { get; set; }
        public String Motorista { get; set; }
        public String Renavam { get; set; }
        public String Chassi { get; set; }
        public String Motorizacao { get; set; }
        public String Tipo { get; set; }
        
        public Viagens Viagens { get; set; }
    }
}
