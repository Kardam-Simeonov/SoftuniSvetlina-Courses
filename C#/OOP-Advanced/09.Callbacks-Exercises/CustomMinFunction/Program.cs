using System;
using System.Runtime.Intrinsics.X86;

namespace CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Func<string[], int> min = x =>
            {
                int minNumber = int.MaxValue;
                foreach (string number in x)
                {
                    int currentNumber = int.Parse(number);
                    if (currentNumber < minNumber)
                    {
                        minNumber = currentNumber;
                    }
                }
                return minNumber;
            };

            Console.WriteLine(min(input));
        }
    }
}
