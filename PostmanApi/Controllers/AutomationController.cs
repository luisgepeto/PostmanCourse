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
    public class AutomationController : Controller
    {
        private HttpContext _context;        
        public AutomationController(HttpContext context)
        {
            _context = context;
        }
        private const string _token = "This represents an authorization token";
        
        [HttpGet("echovariable/{variableValue}")]
        public string EchoVariable(int variableValue){
            return variableValue.ToString();
        }    

        [HttpGet("responsedata/{resourceId}")]
        public Demo ResponseData(int resourceId){
            return new Demo(){
                Id =resourceId,
                Name = "my name "+ resourceId 
            };
        }    

        [HttpGet("firstchained")]
        public object GetFirstChained(){
            return new {Token = _token};
        }

        [HttpPost("secondchained")]
        public IActionResult  PostSecondChained(){
            var authHeader =  _context.Request.Headers.Where(h => h.Key == "Authorization");
            if (authHeader.Any() && authHeader.Single().Value == _token) return Ok("You are authorized");
            return Unauthorized();
        }        
    }    
}
