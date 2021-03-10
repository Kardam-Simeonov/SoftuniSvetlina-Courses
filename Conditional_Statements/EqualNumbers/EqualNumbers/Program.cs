using System;

namespace EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if (first == second && first == third && second == third)
            {
                Console.WriteLine("yes");
                Console.WriteLine(Math.Round(45.3234323, 4));
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
