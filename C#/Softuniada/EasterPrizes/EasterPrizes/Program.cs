using System;
using System.Collections.Generic;

namespace EasterPrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint = int.Parse(Console.ReadLine());
            int endPoint = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>();

            for (int i = startPoint; i <= endPoint; i++)
            {
                if (IsPrime(i) == true)
                    primeNumbers.Add(i);
            }

            Console.WriteLine(String.Join(" ", primeNumbers));
            Console.WriteLine($"The total number of prime numbers between {startPoint} to {endPoint} is {primeNumbers.Count}");
        }

        public static bool IsPrime(int num)
        {
            if (num == 1)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;

            }
            return true;
        }
    }
}
