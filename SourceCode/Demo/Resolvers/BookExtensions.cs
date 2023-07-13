using Demo.Data;
using Demo.Types;

namespace Demo.Resolvers
{
    [ExtendObjectType(typeof(Book))]
    //[ExtendObjectType(typeof(Book),IgnoreProperties = new[] { nameof(Book.Id) })]
    public class BookExtensions
    {
        //[BindMember(nameof(Book.Id))]
        public IEnumerable<string> GetProfile([Parent] Book book)
        {
            return new List<string>();
            // Omitted code for brevity
        }

        // this field is added to every object type
        public string NewField()
        {
            return string.Empty;
            // Omitted code for brevity
        }
    }
}
