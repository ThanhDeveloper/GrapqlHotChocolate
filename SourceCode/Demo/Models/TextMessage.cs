using Demo.Data;

namespace Demo.Models
{
    [InterfaceType("Message")]
    public interface IMessage
    {
        User Author { get; set; }

        DateTime CreatedAt { get; set; }
    }

    public class TextMessage : IMessage
    {
        public User Author { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Content { get; set; }
    }
}
