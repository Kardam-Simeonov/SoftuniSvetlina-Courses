using System;

namespace RecursionFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(12));
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            return Fibonacci(n - 1) * Fibonacci(n - 2);
        }
    }
}
