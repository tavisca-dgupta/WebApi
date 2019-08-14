using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloHiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {

            return "hello World";
        }

        // GET api/values/5
        [HttpGet("{greet}")]
        public ActionResult<string> Get(string greet)
        {
            if (Greet.greetPeople(greet) == "greet")
                return Ok("value");
           return Ok(Greet.greetPeople(greet));
        }
    }
}