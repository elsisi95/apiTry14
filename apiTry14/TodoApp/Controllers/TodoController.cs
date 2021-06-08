using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiTry14.TodoApp.Controllers
{
    [ApiController] //specifying the type of the controller to let .Net know
    [Route("api/[controller]")] //define the routing that this controller will use

    public class TodoController : ControllerBase
    {
        [Route("TestRun")] //define the route of this action

        [HttpGet]
        public ActionResult TestRun()
        {
            return Ok("success");
        }
    }

    
        
    
}

