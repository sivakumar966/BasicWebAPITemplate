using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesStoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            logger.LogInformation("Hello the time is {now}" , DateTime.Now);
            return Ok("Hello");
        }
    }
}
