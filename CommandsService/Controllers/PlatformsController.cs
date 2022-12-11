using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/commands/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundAction()
        {
            Console.WriteLine("--> inbound POST # Command Service");

            return Ok("Inbound test of Platforms Controller");
        }
    }
}
