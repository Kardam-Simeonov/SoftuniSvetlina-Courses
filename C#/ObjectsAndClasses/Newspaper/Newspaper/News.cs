namespace Newspaper
{
    public class News
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Writer { get; set; }
        public News(string inputTitle, string inputText, string inputWriter)
        {
            Title = inputTitle;
            Text = inputText;
            Writer = inputWriter;
        }

        public void Edit(string newText)
        {
            Text = newText;
        }

        public void ChangeWriter(string newWriter)
        {
            Writer = newWriter;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return string.Format($"{Title} - {Text}: {Writer}");
        }
    }
}