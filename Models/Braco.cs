namespace robo.Models
{
    public class Braco
    {
        public enum Lados { esquerdo, direito };

        public Lados lado;

        public readonly Cotovelo cotovelo;

        public readonly Pulso pulso;
        public Braco(Lados lado)
        {
            this.lado = lado;
             pulso = new Pulso();
            cotovelo = new Cotovelo();
        }
    }
}
