using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace robo.Models
{
    public class Cabeca : Componente
    {
        public readonly string[] inclinacoes = { "Para Cima", "Em Repouso", "Para Baixo" };
        public int inclinacaoAtual { get; set; }
        public Cabeca() : base(new string[3] { "Rotação -90º", "Rotação -45º", "Em Repouso" })
        {
            this.estadoAtual = 2;
            this.inclinacaoAtual = 1;
        }

        public bool AlterarInclinacao()
        {

            return true;
        }
    }
}
