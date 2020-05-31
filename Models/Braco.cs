namespace robo.Models
{
    public class Braco
    {
        public enum Lados { esquerdo, direito };
       
        public Lados lado;

        public Cotovelo cotovelo { get; }

        public Pulso pulso { get; }
        public Braco(Lados lado)
        {
            this.lado = lado;
            pulso = new Pulso();
            cotovelo = new Cotovelo();
        }

        public bool MoverPulso(Componente.Movimentos movimento)
        {
            if (cotovelo.EstadoAtual == Cotovelo.STATE_FORTEMENTE_CONTRAIDO)
                return pulso.Mover(movimento);

            return false;
        }
    }
}
