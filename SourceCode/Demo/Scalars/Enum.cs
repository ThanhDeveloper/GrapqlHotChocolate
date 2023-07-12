namespace Demo.Scalars
{
    [GraphQLName("Role")]
    public enum UserRole
    {
        [GraphQLName("VISITOR")]
        GUEST,
        DEFAULT,
        ADMINISTRATOR
    }
}
