using BooksAuthorsMVC.Models;
using System.Text.Json;

namespace BooksAuthorsMVC.Services
{
    public class BookService
    {
        private readonly BookModel _bookModel;
        private readonly AuthorModel _authorModel;

        public BookService(BookModel bookModel, AuthorModel authorModel)
        {
            _bookModel = bookModel;
            _authorModel = authorModel;
        }

        public List<Book> GetAllBooks()
        {
            return _bookModel.FetchBooks();
        }

        public Book GetBookByID(int id)
        {
            return _bookModel.FetchBookById(id);
        }

        public Book AddBook(Book book)
        {
            var author = _authorModel.FetchAuthorById(book.AuthorId);

            if (author == null)
            {
                return null;
            }

            return _bookModel.PushBook(book);
        }

        /*public List<Author> GetAllAuthors()
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
