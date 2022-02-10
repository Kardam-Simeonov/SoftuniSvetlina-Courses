using System;

namespace RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));
        }

        static int Factorial(int n)
        {
            if (n == 1)
                return n;

            return n * Factorial(n - 1);
        }
    }
}
