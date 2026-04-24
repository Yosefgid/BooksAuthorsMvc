using System.Text.Json;

namespace BooksAuthorsMVC.Models
{
    public class AuthorModel
    {
        private readonly string filePath = "Resources/Authors.json";

        public List<Author> FetchAuthors()
        {
            var jsonAuthors = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Author>>(jsonAuthors);
        }

        public Author FetchAuthorById(int id)
        {
            var jsonAuthors = File.ReadAllText(filePath);
            var authors = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);
            return authors.FirstOrDefault(a => a.Id == id); 
        }
    }
}
