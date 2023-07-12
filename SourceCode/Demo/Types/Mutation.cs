using Demo.Data;
using Demo.Error;
using Demo.Models;
using HotChocolate.Resolvers;

namespace Demo.Types
{
    public class Mutation
    {
        [UseMutationConvention]
        public async Task<BookAddedPayload> AddBook(AddBookInput input)
        {
            return new BookAddedPayload { Id = 1, Title = input.Title };
            // Omitted code for brevity
        }

        [Error<UserNameTakenException>]
        public User? UpdateUserNameAsync(IResolverContext context, [ID] Guid userId, string username)
        {
            //throw new NotImplementedException();
            //context.ReportError(new UserNameTakenException(username));
            throw new UserNameTakenException(username);

            //throw new UserNameTakenException(username);
            //UserNameTakenError.CreateErrorFrom(new UserNameTakenException("ABC"));
            return new User { UserName = username };
            //...
        }
    }
}
