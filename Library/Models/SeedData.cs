using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider sp)
        {
            using (var ctx =
                new LibraryContext(sp.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (ctx.Book.Any()) return;

                ctx.AddRange(
                    new Book {Title="Blazor",Author="Ali Ahmed" },
                    new Book { Title = "Razor", Author = "Ahmed Ameen" },
                    new Book { Title = "Browser", Author = "Karem Mohram" },
                    new Book { Title = "C#", Author = "Ali Ahmed" }
                    );
                ctx.SaveChanges();
            }
        }
    }
}
