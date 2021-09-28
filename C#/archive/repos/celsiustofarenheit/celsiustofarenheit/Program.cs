using System;

namespace celsiustofarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());

            double far = (temp * 9 / 5) + 32;






            Console.WriteLine(Math.Round(far, 2));
        }
    }
}
