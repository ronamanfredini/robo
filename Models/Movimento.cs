using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace robo.Models
{
    public class Movimento
    {
        public enum Tipo { posicao, inclinacao }
        public Tipo tipo { get; set; }
        public string parte { get; set; }
        public Componente.Movimentos direcao { get; set; }
    }
}
