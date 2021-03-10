using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int books = int.Parse(Console.ReadLine());
            string currentBook = "";
            int checkedBooks = 0;

            while (checkedBooks <= books)
            {
                currentBook = Console.ReadLine();

                if (currentBook == bookName)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                else if (currentBook != bookName && checkedBooks == books)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    break;
                }

                checkedBooks++;

            }
        }
    }
}
