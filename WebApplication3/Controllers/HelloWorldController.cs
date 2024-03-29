using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HelloWorldController
    {
        [HttpGet]
        public string Hello()
        {
            return ("Hello World!");
        }

        [HttpGet("{name}")]
        public string HelloWithName(string name)
        {
            return ($"Hello {name}!");
        }
    }
}
