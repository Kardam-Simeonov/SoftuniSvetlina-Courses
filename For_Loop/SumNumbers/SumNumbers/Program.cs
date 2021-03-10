using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= nums; i++)
                sum += double.Parse(Console.ReadLine());

            Console.WriteLine(sum);

            
        }
    }
}
