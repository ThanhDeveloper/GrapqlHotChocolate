namespace Demo.Data
{
    //[GraphQLName("BookAuthor")]
    public class Author
    {
        public int Id { get; set; }
        //[GraphQLIgnore]
        public string? Name { get; set; }
    }
}
