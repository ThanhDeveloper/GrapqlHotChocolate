using Demo.Data;

namespace Demo.Resolvers
{
    public class QueryBookResolvers
    {
        [ExtendObjectType(typeof(Author))]
        public sealed class AuthorExtension
        {
            public Uri GetProfilePicture([Parent] Author author)
                => new Uri($"http://localhost/{author.Name}");
        }
    }
}
