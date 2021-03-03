using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning
{
   	[ApiVersion("1.0")]
	[ApiVersion("2.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet("Version")]
        [MapToApiVersion("1.0")]
        public ActionResult<string> Version()
        {
            return Ok("1");
        }

        [HttpGet("Version")]
        [MapToApiVersion("2.0")]
        public ActionResult<string> Version2()
        {
            return Ok("2");
        }
    }
}
