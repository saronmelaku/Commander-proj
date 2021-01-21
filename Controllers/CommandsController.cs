using System.Collections.Generic;
using Commender.Data;
using Commender.Models;
using Microsoft.AspNetCore.Mvc;
    
namespace Commander.Controllers
{
    [Route("api/[Commands]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        
        //private readonly MockCommanderRepo_repository = new MockCommenderRepo();
            
        //GET api/commands
        [HttpGet("")]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
       {
                var CommandItems = _repository.GetAppCommands();
                return Ok(CommandItems);
            }
            //GET api/commands/{id}
            [HttpGet("{id}")]
            public ActionResult<Command> GetCommandById(int id)
            {
                var CommandItems = _repository.GetAppCommands();
                return Ok(CommandItems);
            
            }
   
    }   
}   
    
        
      
