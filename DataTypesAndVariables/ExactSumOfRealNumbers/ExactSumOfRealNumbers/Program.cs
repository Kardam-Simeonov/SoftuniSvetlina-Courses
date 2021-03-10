using System;
using System.Numerics;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());

                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}
