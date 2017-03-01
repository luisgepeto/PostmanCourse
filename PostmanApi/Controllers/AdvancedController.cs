using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace PostmanAPI.Controllers
{
    [Route("api/[controller]")]
    public class AdvancedController : Controller
    {
        public AdvancedController()
        {        
        }

        [HttpPost("importexport")]
        public string EchoHeaders([FromQuery] int sampleId, [FromBody] Demo someObject)
        {
            var objectString = JsonConvert.SerializeObject(someObject);
            return string.Format("I have received the following id: {0} and the following body: {1}", sampleId, objectString);
        }   

        
    }
     
}
