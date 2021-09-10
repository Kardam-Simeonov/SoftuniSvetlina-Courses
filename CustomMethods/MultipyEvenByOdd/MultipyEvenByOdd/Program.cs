using System;

namespace MultipyEvenByOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            if (input < 0)
                input = Math.Abs(input);

            Console.WriteLine(MultiplyEvenByOdd(GetSumOfEvenDigits(input.ToString()), GetSumOfOddDigits(input.ToString())));
        }

        static int GetSumOfEvenDigits(string input)
        {
            int evenSum = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int num = Int32.Parse(input[i].ToString());

                if (num % 2 == 0)
                    evenSum += num;
            }


            return evenSum;
        }

        static int GetSumOfOddDigits(string input)
        {
            int oddSum = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int num = Int32.Parse(input[i].ToString());

                if (num % 2 != 0)
                    oddSum += num;
            }

            return oddSum;
        }
        static int MultiplyEvenByOdd(int evenSum, int oddSum)
        {
            int finalResult = evenSum * oddSum;
            return finalResult;
        }
    }
}
