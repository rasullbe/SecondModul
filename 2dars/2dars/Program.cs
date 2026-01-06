using _2dars.Models;
namespace _2dars;

internal class Program
{
    static List<Book> books = new List<Book>();
    static void Main(string[] args)
    {
        ListSeed();
        var pages = GetMaxPageBook();
        Console.WriteLine(pages.PageCount);
        //var books = GetMostPage(100);
    }

    static List<Book> GetMostPage(int minPage)
    {
        var LotsPagesBook = new List<Book>();

        foreach (var book in books)
        {
            if (book.PageCount > minPage)
            {
                LotsPagesBook.Add(book);
            }
        }

        return LotsPagesBook;
    }

    static Book GetMaxPageBook()
    {
        Book book = books[0];

        foreach (var p in books)
        {
            if (book.PageCount < p.PageCount)
            {
                book = p;
            }
        }

        return book;
    }

    static void ListSeed()
    {
        books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Price = 10.99m,
            Description = "A novel set in the Jazz Age that tells the story of Jay Gatsby's unrequited love for Daisy Buchanan.",
            Created = DateTime.Now,
            Genre = "Classic",
            PageCount = 180
        });

        books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Sariq Devni Minib",
            Author = "Xudoyberdi To'xtaboyev",
            Price = 5.99m,
            Description = "Legenda",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 270
        });

        books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Harry Poter",
            Author = "Opa",
            Price = 15.99m,
            Description = "Legenda 2",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 870
        });
    }
}
