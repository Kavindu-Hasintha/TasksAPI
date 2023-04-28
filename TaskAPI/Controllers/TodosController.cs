using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    // Name it's better to use plural
    // Controller.cs is needed for ASP.net to identify wheather this is a controller or not
   
    // Attributes
    [Route("api/[controller]")]
    [ApiController] // - tells ASP.Net to this is a API controller

    // ControllerBase - API walta ona request, response okkoma wenne
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;
        // _ - private proprety inside the class
        public TodosController()
        {
            _todoService = new TodoService();
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int id = -1)
        {
            if (id == -1)
            {
                return Ok(_todoService.AllTodos());
            }
            var myTodos = _todoService.AllTodos().Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }

        
    }
}
