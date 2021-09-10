using System;
using System.Runtime.InteropServices.ComTypes;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumbers(n);
        }

        static void PrintTopNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int digitSum = 0;
                int oddDigits = 0;
                int num = i;

                while (num != 0)
                {
                    digitSum += num % 10;

                    if ((num % 10) % 2 != 0)
                     oddDigits++;

                    num /= 10;
                }


                if ((digitSum % 8 == 0) && (oddDigits > 0))
                    Console.WriteLine(i);
            }
        }
    }
}
