using Demo.Data;

namespace Demo.Error
{
    public class UserNameTakenError
    {
        private UserNameTakenError(string username)
        {
            Message = $"The username {username} is already taken.";
        }

        public static UserNameTakenError CreateErrorFrom(UserNameTakenException ex)
        {
            return new UserNameTakenError(ex.Username);
        }

        public string Message { get; }
    }

    public class UserNameTakenException : Exception
    {
        public UserNameTakenException(string username): base($"The username {username} is already taken.")
        {
            Username = username;
        }

        public string Username { get; }
    }
}
