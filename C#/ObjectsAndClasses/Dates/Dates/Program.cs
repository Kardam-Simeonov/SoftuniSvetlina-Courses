using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateCounter span = new DateCounter();

            Console.WriteLine(span.CalculateDifference(dateOne, dateTwo));
        }
    }
}
