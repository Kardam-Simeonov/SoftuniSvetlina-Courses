using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int currentNumber = i;
                int oddSum = 0;
                int evenSum = 0;
                while (currentNumber > 0)
                {
                    oddSum += currentNumber % 10;
                    currentNumber /= 10;
                    evenSum += currentNumber % 10;
                    currentNumber /= 10;
                }
                if (oddSum == evenSum)
                    Console.Write(i + " ");
            }
        }
    }
}
