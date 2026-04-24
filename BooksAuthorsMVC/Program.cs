using BooksAuthorsMVC.Services;
using BooksAuthorsMVC.Models;

namespace BooksAuthorsMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //
            builder.Services.AddControllers();
            builder.Services.AddScoped<AuthorService>();
            builder.Services.AddScoped<AuthorModel>();
            //

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllers();

            });

            app.Run();
        }
    }
}
