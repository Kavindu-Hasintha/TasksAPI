using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    // Name it's better to use plural
    // Controller.cs is needed for ASP.net to identify wheather this is a controller or not
   
    // Attributes
    [Route("api/[controller]")]
    [ApiController] // - tells ASP.Net to this is a API controller

    // ControllerBase - API walta ona request, response okkoma wenne
    public class TasksController : ControllerBase
    {
        
        [HttpGet] // Without this, it will raise an error
        public string[] Tasks()
        {
            return new string[] { "Task 1", "Task 2", "Task 3" }; 
        }
        
        [HttpGet("GetAllTasks")]
        // IActionResult - We can send response codes too
        public IActionResult GetTasksa()
        {
            var tasks = new string[] { "Task 1", "Task 2", "Task 3" };
            return Ok(tasks);
            // Using Ok - we can send the response codes . Ok means 200 success
        }

        [HttpPost]
        public IActionResult CreateTasks()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTasks()
        {

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTasks()
        {
            var somethingwentwrong = true;
            if (somethingwentwrong)
                return BadRequest();

            return Ok(); 
        }
        
    }
}
