
namespace MyServer.Model
{
    public class Bookmark
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Url { get; set; }
    }
}
