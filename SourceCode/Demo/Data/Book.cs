using Demo.Data;

namespace Demo.Types
{
    public class Book
    {

        [DefaultValue("DefaultTitle")]
        public int Id { get; set; }
        public string Title { get; set; }

        public Author Author { get; set; }
    }
}
