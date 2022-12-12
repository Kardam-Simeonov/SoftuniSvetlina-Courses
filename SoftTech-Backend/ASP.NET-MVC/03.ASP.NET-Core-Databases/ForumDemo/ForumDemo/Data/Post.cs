namespace ForumDemo.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public IList<PostAnswer> PostAnswers { get; set; }

        = new List<PostAnswer>();
    }
}
