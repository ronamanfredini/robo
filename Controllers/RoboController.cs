using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using robo.Models;
using robo.Utils;

namespace robo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        private readonly IOptions<ServicosGlobais> _servicosGlobais;
        public RoboController(IOptions<ServicosGlobais> servicosGlobais)
        {
            _servicosGlobais = servicosGlobais;
        }

        [HttpGet]
        public ResponseWrapper<Robo> Get()
        {
            return new ResponseWrapper<Robo>() { records = _servicosGlobais.Value.robo };
        }

        [HttpPatch]
        public ResponseWrapper<Robo> Patch(Movimento movimento)
        {
            Robo roboSessao = _servicosGlobais.Value.robo;
            roboSessao.ResolverMovimento(movimento);
            return new ResponseWrapper<Robo>() { records = roboSessao };
        }
    }
}
