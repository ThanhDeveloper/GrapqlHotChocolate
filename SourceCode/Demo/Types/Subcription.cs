namespace Demo.Types
{
    public class Subcription
    {
        //public async IAsyncEnumerable<Book> OnPublishedStream([Service] ITopicEventReceiver eventReceiver, [EnumeratorCancellation] CancellationToken cancellationToken )
        //{
        //    yield return new Book { Title = "MyTitle", Author = new Author { Name = "Ally" } };

        //    await Task.Delay(5000);

        //    var sourceStream = await eventReceiver.SubscribeAsync<string, Book>(nameof(Mutation.PublishBook), cancellationToken);

        //    foreach (Book book in sourceStream.ReadEventsAsync())
        //    {
        //        yield return book;
        //    }

        [Subscribe]
        [Topic(nameof(Mutation.PublishBook))]
        public Book OnPublished([EventMessage] Book publisedBook)
        {
            return publisedBook;
        }
    }
}

