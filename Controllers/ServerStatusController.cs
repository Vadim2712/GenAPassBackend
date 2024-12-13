using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenAPassBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServerStatusController : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(new { status = "Server is running", timestamp = System.DateTime.UtcNow });
        }
    }
}
