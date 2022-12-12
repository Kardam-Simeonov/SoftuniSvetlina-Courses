using Microsoft.Extensions.Hosting;

namespace ForumDemo.Data
{
    public class PostAnswer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
