using Demo.Data;
using Demo.Models;
using Demo.Scalars;

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

        [GraphQLDescription("A query user field")] //Document similar with swagger operation in Rest
        public string GetUser([GraphQLName("name_of_user")] string username)
        {
            return username; 
            // Omitted code for brevity
        }

        [GraphQLDeprecated("Use the `authors` field instead")]
        public Author GetAuthor([DefaultValue("Helo")] [GraphQLName("author")] string author)
        {
            return new () { Name = author };
        }

        public List<User> GetUsers()
        {
            return new () { };
            // Omitted code for brevity
        }

        public User[] GetUserRole(UserRole role)
        {
            throw new NotImplementedException();
        }

        public IMessage[] GetMessages()
        {
            throw new NotImplementedException();
        }

        //Union
        public IPostContent GetContent()
        {
            return new TextContent("");
            // Omitted code for brevity
        }
    }
}
