using Demo.Data;
using Demo.Error;
using Demo.Models;

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

        [Error(typeof(UserNameTakenError))]
        public User? UpdateUserNameAsync([ID] Guid userId, string username)
        {
            return new User { UserName = username };
            //...
        }
    }
}
