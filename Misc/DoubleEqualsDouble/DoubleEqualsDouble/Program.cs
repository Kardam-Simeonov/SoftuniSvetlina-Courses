using System;

namespace DoubleEqualsDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;
            double b = 0.1 * 8;

            if (Math.Abs(a - b) < 0.01)
                Console.WriteLine("Equals");
            else
                Console.WriteLine("Not Equals");
        }
    }
}
