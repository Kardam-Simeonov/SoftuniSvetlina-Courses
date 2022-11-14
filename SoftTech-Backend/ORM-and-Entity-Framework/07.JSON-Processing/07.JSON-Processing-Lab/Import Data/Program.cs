using System.Text.Json;
using System.Text.Json.Serialization;

namespace Import_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jsonInput = File.ReadAllText("../../../Blogging.txt");
            Blog blog = JsonSerializer.Deserialize<Blog>(jsonInput);

            Console.WriteLine(blog.Name);
            Console.WriteLine(blog.Owner);
            Console.WriteLine(blog.Description);
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