using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        [HttpGet]
        public string Hello()
        {
            return "hello";
        }

        [HttpPost]
        public string Hi()
        {
            return "Hi";
        }
    }
}
