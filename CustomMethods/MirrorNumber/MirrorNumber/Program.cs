using System;

namespace MirrorNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MirrorNumber(627));
        }

        static int MirrorNumber(int number)
        {
            int mirror = 0;

            while (number != 0)
            {
                mirror += mirror * 10 + number % 10;

                number /= 10;
            }

            return mirror;
        }

        
    }
}
