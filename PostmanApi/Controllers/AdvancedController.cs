using Microsoft.AspNetCore.Mvc;
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
