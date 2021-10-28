using System;

namespace HighestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            double highest = double.MinValue;
            double num = 0;

            for (int i = 1; i <= nums; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (num > highest)
                    highest = num;

            }

            Console.WriteLine(highest);
        }
    }
}
