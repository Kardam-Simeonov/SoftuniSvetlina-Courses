using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = new BigInteger(1);

            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
                result *= i;

            Console.WriteLine(result);
        }
    }
}
