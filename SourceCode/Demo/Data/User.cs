namespace Demo.Data
{
    public class User
    {
        [GraphQLNonNullType]
        public string UserName { get; set; }
    }
}
