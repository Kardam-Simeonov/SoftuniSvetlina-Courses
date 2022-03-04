using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiDictionary<string, string> phoneBook = new MultiDictionary<string, string>(true);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" - ");
                phoneBook.Add(input[0], input[1]);
            }

            foreach (var person in phoneBook.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{person.Key}: {person.Value}");
            }
        }
    }
}
