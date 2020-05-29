using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace robo.Models
{
    public class Cotovelo : Componente
    {
        public Cotovelo() : base(new string[4] { "Em Repouso", "Levemente Contraído", "Contraído", "Fortemente Contraído" })
        {
            this.estadoAtual = 0;
        }
    }
}
