namespace robo.Models
{
    public class Cotovelo : Componente
    {
        public static string STATE_FORTEMENTE_CONTRAIDO = "Fortemente Contraído";
        public static string STATE_CONTRAIDO = "Contraído";
        public static string STATE_LEVEMENTE_CONTRAIDO = "Levemente Contraído";
        public Cotovelo(string prefixoId) : base(new string[4] { STATE_REPOUSO, STATE_LEVEMENTE_CONTRAIDO, STATE_CONTRAIDO, STATE_FORTEMENTE_CONTRAIDO })
        {
            estadoAtualIndex = 0;
            id = prefixoId + "cotovelo";
        }
    }
}
