using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminMeuDiagnostico.API.Controllers
{
    [ApiController]
    [Route("admin/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("API rodando!");
    }
}
