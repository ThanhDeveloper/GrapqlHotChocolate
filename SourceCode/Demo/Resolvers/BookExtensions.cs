using Demo.Data;
using Demo.Types;

namespace Demo.Resolvers
{
    [ExtendObjectType(typeof(Book))]
    public class BookExtensions
    {
        public IEnumerable<string> GetProfile([Parent] Book book)
        {
            return new List<string>();
            // Omitted code for brevity
        }
    }
}
