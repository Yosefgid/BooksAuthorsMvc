using BooksAuthorsMVC.Models;
using System.Text.Json;

namespace BooksAuthorsMVC.Services
{
    public class AuthorService
    {
        private readonly AuthorModel _authorModel;

        public AuthorService(AuthorModel authorModel)
        {
            _authorModel = authorModel;
        }

        public List<Author> GetAllAuthors()
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
    }
}
