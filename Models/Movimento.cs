using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace robo.Models
{
    public class Movimento
    {
        public string parte { get; set; }
        public Componente.Movimentos direcao { get; set; }
    }
}
