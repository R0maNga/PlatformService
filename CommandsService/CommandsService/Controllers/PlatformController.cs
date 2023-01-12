using System;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/platforms")]
    [ApiController]
    public class PlatformController:ControllerBase
    {
        public PlatformController()
        {
            
        }
        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("Inbound POST #CS");
            return Ok("Test PC");
        }
    }
}
