namespace Demo.Models
{
    [UnionType("PostContent")]
    public interface IPostContent
    {
    }

    public class TextContent : IPostContent
    {
        public TextContent(string text) {
            Text = text;
        }    
        public string Text { get; set; }
    }

    public class ImageContent : IPostContent
    {
        public string ImageUrl { get; set; }

        public int Height { get; set; }
    }
}
