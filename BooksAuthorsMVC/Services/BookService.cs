using BooksAuthorsMVC.Models;
using System.Text.Json;

namespace BooksAuthorsMVC.Services
{
    public class BookService
    {
        private readonly BookModel _bookModel;

        public BookService(BookModel bookModel)
        {
            _bookModel = bookModel;
        }

        public List<Book> GetAllBooks()
        {
            return _bookModel.FetchBooks();
        }

        /*public List<Author> GetAllAuthors()
        {
            return _authorModel.FetchAuthors();
        }

        public Author GetAuthorById(int id)
        {
            return _authorModel.FetchAuthorById(id);
        }

        public Author AddAuthor(Author author)
        {
            return _authorModel.PushAuthor(author);
        }
        public bool DeleteAuthor(int id)
        {
            return _authorModel.RemoveAuthor(id);
        }*/
    }
}
