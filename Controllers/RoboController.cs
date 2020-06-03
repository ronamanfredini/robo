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
        public BaseResponse<Robo> Get()
        {
            return new BaseResponse<Robo>() { records = _servicosGlobais.Value.robo };
        }

        [HttpPatch]
        public BaseResponse<Robo> Patch(Movimento movimento)
        {
            Robo roboSessao = _servicosGlobais.Value.robo;
            try
            {
                roboSessao.ResolverMovimento(movimento);
                return new BaseResponse<Robo>() { records = roboSessao };
            }
            catch (System.Exception e)
            {
                return new BaseResponse<Robo>() { records = roboSessao, message = e.Message, success = false };
            }
        }
    }
}
