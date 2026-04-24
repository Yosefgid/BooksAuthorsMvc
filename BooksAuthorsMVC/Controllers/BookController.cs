using BooksAuthorsMVC.Models;
using BooksAuthorsMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksAuthorsMVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }

        /*[HttpGet]
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

        [HttpDelete("{id}")]

        public IActionResult DeleteAuthor(int id)
        {
            var deleted = _authorService.DeleteAuthor(id);
            return NoContent();
        }*/
    }
}
