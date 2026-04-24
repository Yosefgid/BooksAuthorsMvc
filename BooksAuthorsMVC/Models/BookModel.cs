using System.Text.Json;

namespace BooksAuthorsMVC.Models
{
    public class BookModel
    {
        private readonly string filePath = "Resources/Books.json";

        public List<Book> FetchBooks()
        {
            var jsonBooks = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Book>>(jsonBooks);
        }
        
        /*
        public Author FetchAuthorById(int id)
        {
            var jsonAuthors = File.ReadAllText(filePath);
            var authors = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);
            return authors.FirstOrDefault(a => a.Id == id);
        }

        public Author PushAuthor(Author author)
        {
            var jsonAuthors = File.ReadAllText(filePath);
            var authors = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);

            author.Id = authors.Max(a => a.Id) + 1;
            authors.Add(author);
            var updateJson = JsonSerializer.Serialize(authors, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, updateJson);
            return author;
        }

        public bool RemoveAuthor(int id)
        {
            var jsonAuthors = File.ReadAllText(filePath);
            var authors = JsonSerializer.Deserialize<List<Author>>(jsonAuthors);
            var author = authors.Find(a => a.Id == id);
            authors.Remove(author);

            var updateJson = JsonSerializer.Serialize(authors, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, updateJson);

            return true;

        }*/
    }
}
