using Demo.Data;

namespace Demo.Types
{
    public class Query
    {
        public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
    }
}
