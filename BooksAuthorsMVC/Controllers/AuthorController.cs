using BooksAuthorsMVC.Models;
using BooksAuthorsMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksAuthorsMVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        
        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            var allAuthors = _authorService.GetAllAuthors();
            return Ok(allAuthors);
        }
        [HttpGet("{id}")] 
        public IActionResult GetAuthorById(int id)
        {
            var authorById = _authorService.GetAuthorById(id);
            return Ok(authorById);
        }


        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {
            var newAuthor = _authorService.AddAuthor(author);
            return StatusCode(201, newAuthor);
            //return Ok(newAuthor);
        }
    }
}
