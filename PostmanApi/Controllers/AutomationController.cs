using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace PostmanAPI.Controllers
{
    [Route("api/[controller]")]
    public class AutomationController : Controller
    {
        private HttpContext _context;  
        private StateMachine _stateMachine;      
        private EnvironmentContainer _environmentContainer;
        public AutomationController(HttpContext context, StateMachine stateMachine, EnvironmentContainer environmentContainer)
        {
            _context = context;
            _stateMachine = stateMachine;
            _environmentContainer = environmentContainer;            
        }
        private const string _token = "This represents an authorization token";
        
        [HttpGet("environment")]
        public EnvironmentContainer GetEnvironment(){
            return _environmentContainer;
        }
        
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

        [HttpGet("workflowstate")]
        public IActionResult GetWorkflowCurrentState(){
            return Ok(_stateMachine.GetCurrentState());
        } 

        [HttpGet("firstworkflow")]
        public IActionResult GetFirstWorkflow(){            
            return GetWorkflow(1);

        }

        [HttpGet("secondworkflow")]
        public IActionResult PostSecondWorkflow(){
            return GetWorkflow(2);
        }

        [HttpGet("thirdworkflow")]
        public IActionResult GetThirdWorkflow(){
            return GetWorkflow(3);
        }

        private IActionResult GetWorkflow(int stateId){            
            if(_stateMachine.GetCurrentState().NextStateId != stateId)
                return BadRequest("This not the next state that corresponds to the previous request");
            _stateMachine.CurrentStateId = stateId;
            return Ok(_stateMachine.GetCurrentState());
        }
    }    
}
