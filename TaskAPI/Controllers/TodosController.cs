using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;
using TaskAPI.Services.ModelsDto;
using TaskAPI.Services.Todos;

namespace TaskAPI.Controllers
{
    // Name it's better to use plural
    // Controller.cs is needed for ASP.net to identify wheather this is a controller or not

    // Attributes
    [Route("api/authors/{authorId}/todos")]
    [ApiController] // - tells ASP.Net to this is a API controller

    // ControllerBase - API walta ona request, response okkoma wenne
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;
        // _ - private proprety inside the class
        public TodosController(ITodoRepository todoRepository, IMapper mapper)
        {
            // Dependencies Injection
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetAllTodos(int authorId)
        {
            var todos = _todoRepository.GetAllTodos(authorId);

            var mappedTodos = _mapper.Map<ICollection<TodoDto>>(todos);

            return Ok(mappedTodos);
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetTodo(int authorId, int id) 
        {
            var todo = _todoRepository.GetTodo(authorId, id);

            if (todo == null)
            {
                return NotFound();
            }
            var mappedTodo = _mapper.Map<TodoDto>(todo);
            return Ok(mappedTodo);
        }

        [HttpPost]
        public ActionResult<TodoDto> CreateTodo(int authorId, CreateTodoDto createTodoDto)
        {
            var todoEntity = _mapper.Map<Todo>(createTodoDto);
            var newTodo = _todoRepository.AddTodo(authorId, todoEntity);

            var todoForReturn = _mapper.Map<TodoDto>(newTodo);

            return CreatedAtRoute("GetTodo", new {authorId = authorId, id = todoForReturn.Id}, todoForReturn);
        }

        [HttpPut("{todoId}")]
        public ActionResult UpdateTodo(int authorId, int todoId, UpdateTodoDto todo)
        {
            var updatingTodo = _todoRepository.GetTodo(authorId, todoId);

            if (updatingTodo == null)
            {
                return NotFound();
            }

            _mapper.Map(todo, updatingTodo);
            _todoRepository.UpdateTodo(updatingTodo);

            return NoContent();
        }

        [HttpDelete("{todoId}")]
        public ActionResult DeleteTodo(int authorId, int todoId)
        {
            var deletingTodo = _todoRepository.GetTodo(authorId, todoId);

            if (deletingTodo == null)
            {
                return NotFound();
            }

            _todoRepository.DeleteTodo(deletingTodo);

            return NoContent();
        }
    }
}
