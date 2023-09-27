public class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
    public string Author { get; set; }
    public Book(string title, double price, string Author)
    {
        this.Title = title;
        this.Price = price;
        this.Author = Author;
    }
}