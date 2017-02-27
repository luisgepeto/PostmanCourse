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

        [HttpGet("simplejson")]
        public object SimpleJson()
        {
            return new {
                Id = 1,
                Name="Some Name", 
                Children = new List<string>(){
                    "this is item 1", "this is item 2"
                }
            };
        }
        
        [HttpGet("simplexml")]
        public object SimpleXML()
        {
            //TODO this is not returning xml
            return SimpleJson();
        }

    }
}
