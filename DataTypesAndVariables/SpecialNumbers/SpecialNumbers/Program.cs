using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digitSum = 0;
                int num = i;

                while (num != 0)
                {
                    digitSum += num % 10;
                    num /= 10;
                }


                if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                    Console.WriteLine($"{i} -> True");
                else
                    Console.WriteLine($"{i} -> False");
            }
        }
    }
}
