using System;

namespace NumbersOfThePowerof2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(currentNum);
                currentNum *= 4;
            }
        }
    }
}
