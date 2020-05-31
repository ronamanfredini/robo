using System;

namespace robo.Models
{
    public class Componente
    {
        public static string STATE_REPOUSO = "Em Repouso";
        public static string STATE_INCLINACAO_PARA_CIMA = "Para Cima";
        public static string STATE_INCLINACAO_PARA_BAIXO = "Para Baixo";

        public readonly string[] inclinacoes = { STATE_INCLINACAO_PARA_CIMA, STATE_REPOUSO, STATE_INCLINACAO_PARA_BAIXO };
        protected int inclinacaoAtualIndex { get; set; }
        public string InclinacaoAtual => inclinacoes[inclinacaoAtualIndex];
        public enum Movimentos { retroceder, avancar };
        protected int estadoAtualIndex { get; set; }

        public string[] estados;
        public string EstadoAtual => estados[estadoAtualIndex];
        
        public Componente() {}

        protected Componente(string[] estados)
        {
            this.estados = estados;
        }

        public virtual bool Mover(Movimentos movimento, Movimento.Tipo tipo) {
            try
            {
                Exception e = new Exception("Estado Inválido. Estado do componente resetado para o estado inicial.");
                if (tipo == Movimento.Tipo.posicao)
                {
                    if (movimento == Movimentos.avancar && ++estadoAtualIndex == estados.Length)
                        throw e;
                    if (movimento == Movimentos.retroceder && --estadoAtualIndex < 0)
                        throw e;
                } else if (tipo == Movimento.Tipo.inclinacao)
                {
                    if (movimento == Movimentos.avancar && ++inclinacaoAtualIndex == estados.Length)
                        throw e;
                    if (movimento == Movimentos.retroceder && --inclinacaoAtualIndex < 0)
                        throw e;
                }
            }
            catch (Exception e)
            {
                inclinacaoAtualIndex = 1;
                estadoAtualIndex = GetDefaultEstadoAtualIndex();
                throw e;
            }

            return true;
        }

        private int GetDefaultEstadoAtualIndex()
        {
            for (int i = 0; i < estados.Length; i++)
            {
                if (estados[i] == STATE_REPOUSO)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
