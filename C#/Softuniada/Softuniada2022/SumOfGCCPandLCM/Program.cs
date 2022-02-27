using System;

namespace SumOfGCCPandLCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong m = ulong.Parse(Console.ReadLine());

            ulong gcd = FindGCD(n, m);
            ulong lcm = FindLCM(n, m);

            Console.WriteLine(lcm + gcd);
        }

        private static ulong FindGCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        private static ulong FindLCM(ulong a, ulong b)
        {
            return (a / FindGCD(a, b)) * b;
        }
    }
}
