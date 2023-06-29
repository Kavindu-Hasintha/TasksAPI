using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.ModelsDto;

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
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository authorRepository, IMapper mapper) 
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors(string job, string search)
        {
            var authors = _authorRepository.GetAllAuthors(job, search);
            
            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
            // We use ICollection, because authors is List

            return Ok(mappedAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);

            return Ok(mappedAuthor);
        }

        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor (CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var newAuthorEn = _authorRepository.AddAuthor(authorEntity);

            var authorForReturn = _mapper.Map<AuthorDto>(newAuthorEn);
            // return CreatedAtRoute("GetAuthor", new {id = authorForReturn.Id}, authorForReturn);
            return authorForReturn;
        }
    }
}
