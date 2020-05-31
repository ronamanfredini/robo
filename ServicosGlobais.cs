using robo.Models;

namespace robo
{
    public class ServicosGlobais
    {
        public Robo robo { get; set; }
        public ServicosGlobais()
        {
            robo = new Robo();
        }
    }
}
