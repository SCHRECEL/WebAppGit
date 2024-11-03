using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppGit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        public NameController() { }
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(new { Name = "Earl Schreck" });
        }

    }
}
