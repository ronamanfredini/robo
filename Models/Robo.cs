namespace robo.Models
{
    public class Robo
    {
        public Braco bracoEsquerdo { get; }
        public Braco bracoDireito { get; }
        public Cabeca cabeca { get; }
        public Robo()
        {
            bracoEsquerdo = new Braco(Braco.Lados.esquerdo);
            bracoDireito = new Braco(Braco.Lados.direito);
            cabeca = new Cabeca();
        }

        public bool ResolverMovimento(Movimento movimento)
        {
            bool resultado = false;
            switch (movimento.parte)
            {
                case "cabeca":
                    resultado = cabeca.Mover(movimento.direcao, movimento.tipo);
                    break;
                case "bracoDireito.cotovelo":
                    resultado = bracoDireito.cotovelo.Mover(movimento.direcao, movimento.tipo);
                    break;
                case "bracoDireito.pulso":
                    resultado = bracoDireito.MoverPulso(movimento.direcao);
                    break;
                case "bracoEsquerdo.cotovelo":
                    resultado = bracoEsquerdo.cotovelo.Mover(movimento.direcao, movimento.tipo);
                    break;
                case "bracoEsquerdo.pulso":
                    resultado = bracoEsquerdo.MoverPulso(movimento.direcao);
                    break;
            }
            
            return resultado;
        }
    }
}
