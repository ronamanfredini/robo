namespace robo.Models
{
    public class Robo
    {
        public readonly Braco bracoEsquerdo;

        public readonly Braco bracoDireito;

        public readonly Cabeca cabeca;
        public Robo()
        {
            bracoEsquerdo = new Braco(Braco.Lados.esquerdo);
            bracoDireito = new Braco(Braco.Lados.direito);
        }
    }
}
