using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PostmanAPI.Controllers
{
    [Route("api/[controller]")]
    public class BasicController : Controller
    {

        [HttpGet("simple")]
        public string Simple()
        {
            return "This is a simple result";
        }

    }
}
