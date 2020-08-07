using Microsoft.AspNetCore.Mvc;

namespace AspnetcoreEnvironment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnythingController : ControllerBase
    {
        // GET api/anything
        [HttpGet]
        public ActionResult<dynamic> Get()
        {
            string remoteIpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
            string localIpAddress = HttpContext.Connection.LocalIpAddress.ToString();

            return new { HttpContext.Request.Headers, remoteIpAddress, localIpAddress };
        }
    }
}
