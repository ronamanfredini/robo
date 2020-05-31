namespace robo.Models
{
    public class Componente
    {
        public static string STATE_REPOUSO = "Em Repouso";
        public enum Movimentos { retroceder, avancar };
        protected int estadoAtualIndex { get; set; }

        public string[] estados;
        public string EstadoAtual => estados[estadoAtualIndex];
        
        public Componente() {}

        protected Componente(string[] estados)
        {
            this.estados = estados;
        }

        public virtual bool Mover(Movimentos movimento) {
            if (movimento == Movimentos.avancar && ++estadoAtualIndex == estados.Length)
                return false;

            if (movimento == Movimentos.retroceder && --estadoAtualIndex < 0)
                return false;

            return true;
        }
    }
}
