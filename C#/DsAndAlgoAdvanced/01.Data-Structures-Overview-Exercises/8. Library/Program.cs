List<Book> library = new List<Book>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] parts = input.Split(" ", 2);

    switch (parts[1])
    {
        case "AddBook":
            string[] addParts = parts[2].Split("-");

            library.Add(new Book(addParts[1], double.Parse(addParts[2]), addParts[3]));
            Console.WriteLine("Book added");

            break;
        case "DeleteBook":
            string[] deleteParts = parts[2].Split("-");
            int deletedBooks = 0;

            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].Title == deleteParts[0] && library[i].Author == deleteParts[1])
                {
                    library.Remove(library[i]);
                    deletedBooks++;
                }
            }

            if (deletedBooks == 0)
                Console.WriteLine("No books found");
            else
                Console.WriteLine($"{deletedBooks} books deleted");
            break;

        case "FindBooksByTitle":
            List<Book> booksByTitle = new List<Book>();
            foreach (Book book in library)
            {
                if (book.Title == parts[2])
                    booksByTitle.Add(book);
            }

            if (booksByTitle.Count != 0)
            {
                foreach (var book in booksByTitle)
                {
                    Console.WriteLine($"{{{book.Title}-{book.Author}-{book.Price}}}");
                }
            }
            else
            {
                Console.WriteLine("No books found");
            }
            break;
        case "FindBooksByAuthor":
            List<Book> booksByAuthor = new List<Book>();
            foreach (Book book in library)
            {
                if (book.Author == parts[2])
                    booksByAuthor.Add(book);
            }

            if (booksByAuthor.Count != 0)
            {
                foreach (var book in booksByAuthor)
                {
                    Console.WriteLine($"{{{book.Title}-{book.Author}-{book.Price}}}");
                }
            }
            else
            {
                Console.WriteLine("No books found");
            }
            break;
        case "FindBooksByPriceRange":
            List<Book> booksByPrice = new List<Book>();
            double[] priceRange = parts[2].Split("-").Select(double.Parse).ToArray();

            foreach (Book book in library)
            {
                if (book.Price >= priceRange[0] && book.Price <= priceRange[1])
                    booksByPrice.Add(book);
            }

            if (booksByPrice.Count != 0)
            {
                foreach (var book in booksByPrice)
                {
                    Console.WriteLine($"{{{book.Title}-{book.Author}-{book.Price}}}");
                }
            }
            else
            {
                Console.WriteLine("No books found");
            }
            break;
    }
}