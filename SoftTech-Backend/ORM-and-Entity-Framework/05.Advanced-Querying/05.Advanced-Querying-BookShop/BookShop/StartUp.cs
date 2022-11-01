namespace BookShop
{
    using Data;
    using Initializer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            string input = Console.ReadLine();
            Console.WriteLine(GetBooksByAgeRestriction(db, input));
            
            Console.WriteLine(GetGoldenBooks(db));
            
            Console.WriteLine(GetBooksByPrice(db));

            input = Console.ReadLine();
            Console.WriteLine(GetBooksNotReleasedIn(db, int.Parse(input)));

            input = Console.ReadLine();
            Console.WriteLine(GetBooksByCategory(db, input));

            input = Console.ReadLine();
            Console.WriteLine(GetBooksReleasedBefore(db, input));

            input = Console.ReadLine();
            Console.WriteLine(GetAuthorNamesEndingIn(db, input));

            input = Console.ReadLine();
            Console.WriteLine(GetBookTitlesContaining(db, input));

            input = Console.ReadLine();
            Console.WriteLine(GetBooksByAuthor(db, input));
            
            input = Console.ReadLine();
            Console.WriteLine(CountBooks(db, int.Parse(input)));

            Console.WriteLine(CountCopiesByAuthor(db));

            Console.WriteLine(GetTotalProfitByCategory(db));

            Console.WriteLine(GetMostRecentBooks(db));

            IncreasePrices(db);

            RemoveBooks(db);
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var bookTitles = context.Books
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var goldenBooks = context.Books
                .Where(b => b.EditionType.Equals("Golden") && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, goldenBooks);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => $"{b.Title} - ${b.Price:F2}")
                .ToList();

            return string.Join(Environment.NewLine, books);
        }
        
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var booksNotReleased = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();
            
            return string.Join(Environment.NewLine, booksNotReleased);         
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            List<string> categories = input.ToLower().Split(" ").ToList();

            var booksInCategory = context.Books
                .Where(b => b.BookCategories.Any(c => categories.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            return String.Join(Environment.NewLine, booksInCategory);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var booksReleasedBefore = context.Books
                .Where(b => b.ReleaseDate.Value < DateTime.ParseExact(date, "dd-MM-yyyy", null))
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType} - ${b.Price}")
                .ToList();

            return string.Join(Environment.NewLine, booksReleasedBefore);
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authorNames = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .OrderBy(a => a.FirstName)
                .Select(a => $"{a.FirstName} {a.LastName}")
                .ToList();

            return string.Join(Environment.NewLine, authorNames);
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var booksContaining = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, booksContaining);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var booksByAuthor = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToList();

            return string.Join(Environment.NewLine, booksByAuthor);
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            int bookCount = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return bookCount;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorCopies = context.Authors
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}",
                    Copies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.Copies)
                .Select(a => $"{a.FullName} - {a.Copies}")
                .ToList();

            return string.Join(Environment.NewLine, authorCopies);
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var totalProfitByCategory = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    TotalProfit = c.CategoryBooks.Sum(cb => cb.Book.Copies * cb.Book.Price)
                })
                .OrderByDescending(c => c.TotalProfit)
                .ThenBy(c => c.CategoryName)
                .ToList();

            return string.Join(Environment.NewLine, totalProfitByCategory);
        }
        
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var mostRecentBooks = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    ThreeRecentBooks = c.CategoryBooks
                        .Select(cb => new
                        {
                            BookTitle = cb.Book.Title,
                            ReleaseDate = cb.Book.ReleaseDate.Value.Year
                        })
                        .OrderByDescending(cb => cb.ReleaseDate)
                        .Take(3)
                        .ToList()
                })
                .OrderBy(c => c.CategoryName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var category in mostRecentBooks)
            {
                sb.AppendLine($"--{category.CategoryName}");
                foreach (var book in category.ThreeRecentBooks)
                    sb.AppendLine($"{book.BookTitle} ({book.ReleaseDate})");
            }

            return sb.ToString();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var booksToIncrease = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var book in booksToIncrease)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var booksToRemove = context.Books
                .Where(b => b.Copies < 4200)
                .ToList();

            int booksRemoved = booksToRemove.Count();

            context.Books.RemoveRange(booksToRemove);
            context.SaveChanges();

            return booksRemoved;
        }
    }
}

