using System;

namespace Tailor_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());


            double pokrivki = tables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double kareta =  tables * (length/2) *  (length/2) ;      

            double price = pokrivki * 7 + kareta * 9;
            double price_bgn = price * 1.85;

            Console.WriteLine($"{price:f2} USD");
            Console.WriteLine($"{price_bgn:f2} BGN");

        }
    }
}
