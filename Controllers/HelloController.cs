using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WelshAppApi.Controllers
{
    [ApiController]
    [Route("api/hello")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetHelloMessage()
        {
            return Ok("Hello Welshish!");
        }
    }
}
