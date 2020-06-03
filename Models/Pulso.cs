namespace robo.Models
{
    public class Pulso : Componente
    {
        public Pulso(string prefixoId) : base(new string[7] { "Rotação para -90º", "Rotação para -45º", "Em Repouso", "Rotação para 45º", "Rotação para 90º", "Rotação para 135º", "Rotação para 180º" })
        {
            estadoAtualIndex = 2;
            id = prefixoId + "pulso";
        }
    }
}
