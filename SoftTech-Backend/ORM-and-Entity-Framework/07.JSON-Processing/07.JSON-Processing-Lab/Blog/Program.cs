using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blog myBlog = new ();
            myBlog.Id= 1;
            myBlog.Name = "My Blog";
            myBlog.Owner = "John Doe";
            myBlog.Description= "My Description";

            string blogInfo = JsonSerializer.Serialize(myBlog);
            File.WriteAllText("myBlog.txt", blogInfo);
        }

    }
    public class Blog
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Owner { get; set; }
        public string Description { get; set; }
    }
}