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
    public class TestingController : Controller
    {
        private List<Demo> _demoList;
        public TestingController(List<Demo> demoList)
        {        
            _demoList = demoList;
        }

        [HttpGet("simpletest")]
        public List<Demo> SimpleTest()
        {
            return _demoList;
        }   
        
        [HttpPut("complextest/{resourceId}")]
        public IActionResult ComplexTest(int resourceId, [FromBody] Demo demo)
        {            
            var oldResource = _demoList.FirstOrDefault(d => d.Id == resourceId);            
            if (oldResource == null) return NotFound(resourceId);
            _demoList.Remove(oldResource);          
            oldResource.Id = demo.Id;
            oldResource.Name = demo.Name;  
            _demoList.Add(oldResource);     
            return Ok(oldResource);            
        }   

        [HttpGet("randomerror/{randomId}")]
        public Demo RandomError(int randomId){
            var random = (new Random()).Next(10);
            return new Demo(){
                Id = random,
                Name = "My Name is: "+ random
            };
        }
    }
     
}
