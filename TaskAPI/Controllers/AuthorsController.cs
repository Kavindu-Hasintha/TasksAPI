using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;

namespace TaskAPI.Controllers
{
    // [Route("api/[controller]")] - when we rename the controller. API url also changed.
    // To prevent of changing API, we write route as this,
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        // Inject to the constructor
        private readonly IAuthorRepository _authorRepository;
        public AuthorsController(IAuthorRepository authorRepository) 
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }
    }
}
