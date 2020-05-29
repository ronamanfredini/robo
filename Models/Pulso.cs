
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace robo.Models
{
    public class Pulso : Componente
    {
        public Pulso() : base(new string[7] { "Rotação para -90º", "Rotação para -45º", "Em Repouso", "Rotação para 45º", "Rotação para 90º", "Rotação para 135º", "Rotação para 180º" })
        {
            this.estadoAtual = 2;
        }
    }
}
