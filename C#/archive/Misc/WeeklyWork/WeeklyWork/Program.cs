using System;

namespace WeeklyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int workplaceOne = int.Parse(Console.ReadLine());

            if (workplaceOne >= 3 && workplaceOne <= 7)
                Console.WriteLine((workplaceOne * 8) + 15);
          
            else
                Console.WriteLine($"{workplaceOne} is invalid number.");
        }
    }
}
