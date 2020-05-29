namespace robo.Models
{
    public class Componente
    {
    public enum Movimentos { avancar, retroceder };

        public readonly string[] estados;

        public int estadoAtual;

        public Componente() {}

        protected Componente(string[] estados)
        {
            this.estados = estados;
        }

        public virtual bool Mover(Movimentos movimento) {
            if (movimento == Movimentos.avancar && ++estadoAtual == estados.Length)
                return false;

            if (movimento == Movimentos.retroceder && --estadoAtual < 0)
                return false;

            return true;
        }
    }
}
