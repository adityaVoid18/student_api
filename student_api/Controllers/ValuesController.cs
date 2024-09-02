using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using student_api.Models;
using System.Reflection.Metadata.Ecma335;

namespace student_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly demoprojectContext demoproject;

        public ValuesController(demoprojectContext demoproject)
        {
            this.demoproject = demoproject;
        }

        [HttpGet]
        public string Get() {

            return "Hello World";
        }
    }
}
