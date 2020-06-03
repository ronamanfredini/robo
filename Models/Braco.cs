namespace robo.Models
{
    public class Braco
    {
        public enum Lados { esquerdo, direito };
       
        public Lados ladoIndex;
        public string lado => ladoIndex == 0 ? "Esquerdo" : "Direito";
        public Cotovelo cotovelo { get; }
        public Pulso pulso { get; }
        public Braco(Lados lado)
        {
            ladoIndex = lado;
            string prefixoId = lado == Lados.direito ? "bracoDireito": "bracoEsquerdo";
            prefixoId += '.';
            pulso = new Pulso(prefixoId);
            cotovelo = new Cotovelo(prefixoId);
        }

        public bool MoverPulso(Componente.Movimentos movimento)
        {
            if (cotovelo.EstadoAtual == Cotovelo.STATE_FORTEMENTE_CONTRAIDO)
                return pulso.Mover(movimento, Movimento.Tipo.posicao);

            throw new System.Exception("Pulso só pode ser movido se o cotovelo estiver no estado " + Cotovelo.STATE_FORTEMENTE_CONTRAIDO);
        }
    }
}
