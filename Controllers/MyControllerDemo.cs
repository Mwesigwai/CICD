using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyControllerDemo : ControllerBase
    {
        [HttpGet]
        public ActionResult GetMyName()
        {
            return Ok("Isaac");
        }
    }
}
