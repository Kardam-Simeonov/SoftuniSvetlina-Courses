namespace Articles_2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public Article(string inputTitle, string inputContent, string inputAuthor)
        {
            Title = inputTitle;
            Content = inputContent;
            Author = inputAuthor;
        }

        
    }
}