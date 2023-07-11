namespace Demo.Error
{
    public class UserNameTakenError
    {
        public UserNameTakenError(UserNameTakenException ex)
        {
            Message = $"The username {ex.Username} is already taken.";
        }

        public string Message { get; }
    }

    public class UserNameTakenException : Exception
    {
        public UserNameTakenException(string username)
        {
            Username = username;
        }

        public string Username { get; }
    }
}
