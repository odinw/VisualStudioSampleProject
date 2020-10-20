using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Index([FromServices] IWebHostEnvironment env) => $"{env.ApplicationName}: {env.EnvironmentName}";
    }
}
