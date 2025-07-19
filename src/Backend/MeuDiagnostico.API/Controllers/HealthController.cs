using Microsoft.AspNetCore.Mvc;

namespace MeuDiagnostico.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("API rodando!");
    }
}
