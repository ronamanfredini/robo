namespace robo.Models
{
    public class Cabeca : Componente
    {
        public static string STATE_ROTACAO_MENOS_90 = "Rotação -90º";
        public static string STATE_ROTACAO_MENOS_45 = "Rotação -45º";

        public readonly string[] inclinacoes = { "Para Cima", "Em Repouso", "Para Baixo" };
        protected int inclinacaoAtualIndex { get; set; }

        public string InclinacaoAtual => inclinacoes[inclinacaoAtualIndex];
        public Cabeca() : base(new string[3] { STATE_ROTACAO_MENOS_90, STATE_ROTACAO_MENOS_45, STATE_REPOUSO})
        {
            this.estadoAtualIndex = 2;
            this.inclinacaoAtualIndex = 1;
        }

        public bool AlterarInclinacao()
        {

            return true;
        }
    }
}
