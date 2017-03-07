using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace PostmanAPI.Controllers
{
    [Route("api/[controller]")]
    public class ManipulationController : Controller
    {
        private HttpContext _context;
        private List<Demo> _demoList;
        public ManipulationController(HttpContext context, List<Demo> demoList)
        {
            _context = context;
            _demoList = demoList;
        }

        [HttpGet("echoheaders")]
        public Dictionary<string, string> EchoHeaders()
        {
            return _context.Request.Headers.ToDictionary(h => h.Key, h => h.Value.FirstOrDefault());            
        }   

        [HttpGet("echocookies")]
        public Dictionary<string, string> EchoCookies()
        {
            return _context.Request.Cookies.ToDictionary(h => h.Key, h => h.Value);
        }       

        [HttpGet("resource/{resourceId}")]
        public string GetMethod(int resourceId){
            var resource = _demoList.FirstOrDefault(d => d.Id == resourceId);
            var jsonResource = JsonConvert.SerializeObject(resource);
            return string.Format("This method is retrieving a resource with id {0}: {1}", resourceId, jsonResource);
        }

        [HttpPost("resource")]
        public string PostMethod([FromBody] Demo demo){
            var jsonDemo = JsonConvert.SerializeObject(demo);
            var old = string.Format("The old collection is: {0}", JsonConvert.SerializeObject(_demoList));
            _demoList.Add(demo);
            var newCollection = string.Format("The new collection is: {0}", JsonConvert.SerializeObject(_demoList));
            return string.Format("This method is creating a new resource with the payload: {0}\n{1}\n{2}", jsonDemo,old, newCollection);
        }

        [HttpPut("resource/{resourceId}")]
        public string PutMethod(int resourceId, [FromBody] Demo demo ){
            var jsonDemo = JsonConvert.SerializeObject(demo);
            var oldResource = _demoList.FirstOrDefault(d => d.Id == resourceId);
            var old = string.Format("The old resource is: {0}", JsonConvert.SerializeObject(oldResource));
            _demoList.Remove(oldResource);          
            oldResource.Id = demo.Id;
            oldResource.Name = demo.Name;  
            _demoList.Add(oldResource);     
            var newResource = _demoList.FirstOrDefault(d => d.Id == demo.Id);
            var newString = string.Format("The new resource is: {0}", JsonConvert.SerializeObject(newResource));            
            return string.Format("This method is updating a resource with id: {3} with the payload: {0}\n{1}\n{2}", jsonDemo,old, newString, resourceId);
        }

        [HttpDelete("resource/{resourceId}")]
        public string DeleteMethod(int resourceId){
            var resource = _demoList.FirstOrDefault(d => d.Id == resourceId);
            var old = string.Format("The old collection is: {0}", JsonConvert.SerializeObject(_demoList));
            _demoList.Remove(resource);          
            var newCollection = string.Format("The new collection is: {0}", JsonConvert.SerializeObject(_demoList));
            return string.Format("This method is deleting the resource with id {0}\n{1}\n{2}", resourceId,old, newCollection);
        }

        [HttpGet("echoparameters")]
        public Dictionary<string, string> EchoParameters(){
            var parsedQuery = QueryHelpers.ParseQuery(_context.Request.QueryString.Value);
            return parsedQuery.ToDictionary(q => q.Key, q => q.Value.FirstOrDefault());            
        }

        [HttpPost("echobody")]
        public object EchoBody([FromBody] object body){
            return body;                    
        }
    }    
}
