using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    evenSum += num;
                else
                    oddSum += num;
            }

            if (evenSum == oddSum)
                Console.WriteLine($"Yes sum {evenSum}");
            else
                Console.WriteLine($"No diff {Math.Abs(evenSum - oddSum)}");

        }
    }
}
