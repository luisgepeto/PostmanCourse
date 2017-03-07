using System.Collections.Generic;
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
        public ExtendedDemo SimpleJson()
        {
            return new ExtendedDemo(){
                Id = 1,
                Name="Some Name", 
                Children = new List<string>(){
                    "this is item 1", "this is item 2"
                }
            };
        }
        
        [HttpGet("simplexml")]
        public ExtendedDemo SimpleXML()
        {            
            return SimpleJson();
        }

    }
}
