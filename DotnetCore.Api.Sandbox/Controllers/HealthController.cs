using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Api.Sandbox.Controllers
{
    [ServiceFilter(typeof(SampleFilter))]
    public class HealthController : Controller
    {
        [HttpGet("health")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}