using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitSum = 0;
            int num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                digitSum += num % 10;
                num /= 10;
            }

            Console.WriteLine(digitSum);
        }
    }
}
