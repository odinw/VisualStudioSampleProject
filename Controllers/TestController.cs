using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public TestController()
        { 
        
        }

        /// <summary>
        /// Sample Url: http://localhost:32773/Test/Status
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public IActionResult Status()
        {
            return Ok("Project Ready");
        }
    }
}
