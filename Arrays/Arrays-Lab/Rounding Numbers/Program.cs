using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
           
            foreach(double i in numbers)
                Console.WriteLine($"{Convert.ToDecimal(i)} => {Math.Round(Convert.ToDecimal(i), MidpointRounding.AwayFromZero)}");
        }
    }
}
