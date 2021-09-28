using System;

namespace CocatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string connection = Console.ReadLine();

            Console.WriteLine($"{firstName}{connection}{lastName}");
        }
    }
}
