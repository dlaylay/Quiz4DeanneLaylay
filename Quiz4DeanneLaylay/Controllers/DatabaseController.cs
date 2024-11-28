using Microsoft.AspNetCore.Mvc;

namespace Quiz4DeanneLaylay.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Database access has already been done on Nov 28, 2024, by Deanne");
        }
    }
}
