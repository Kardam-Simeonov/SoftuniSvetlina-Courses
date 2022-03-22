namespace BookShop
{
    using Data;
    using System;
    using System.Linq;
    using System.Text;
    using BookShop.Models;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        public static void Main()
        {
            using BookShopContext db = new BookShopContext();

            Console.WriteLine(GetBooksFullInformation(db));
        }

        //In the project “BookShop.Data” click on “Configuration.cs” 
        //Check if the server name in the path is the same like in Microsoft SQL Management Studio. 
        //If it's not, change it.

        // Get Books Full Information
        public static string GetBooksFullInformation(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var books = context.Books
                .Include(x => x.Author).ToList();

            foreach (var book in books.OrderBy(x => x.BookId))
            {
                sb.AppendLine($"ID:{book.BookId} Title:{book.Title} Description:{book.Description} Price:{book.Price} Author:{book.Author.FirstName} {book.Author.LastName}");
            }

            return sb.ToString().Trim();
        }

        // Filter Data by Price
        public static string FilterDataByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            //ToDo...

            return sb.ToString().TrimEnd();
        }

        // Filter Data by Author
        public static string FilterDataByAuthor(BookShopContext context, string input)
        {

            var sb = new StringBuilder();

            //ToDo...

            return sb.ToString().TrimEnd();
        }

        // Change Description
        public static string ChangeDescription(BookShopContext context, int id)
        {
            StringBuilder sb = new StringBuilder();

            //ToDo...

            return sb.ToString().Trim();
        }

    }
}
