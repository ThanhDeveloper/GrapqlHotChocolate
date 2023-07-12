using Demo.Data;
using Demo.Error;
using Demo.Models;
using HotChocolate.Resolvers;
using HotChocolate.Subscriptions;

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

        public async Task<Book> PublishBook(string title,
            string author,
            [Service] ITopicEventSender topicEventSender,
            CancellationToken cancellationToken
            )
        {
            var book = new Book { Title = title, Author = new Author { Name = author } };
            await topicEventSender.SendAsync(nameof(PublishBook), book, cancellationToken);
            return book;
        }
    }
}
