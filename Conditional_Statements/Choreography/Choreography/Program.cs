using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double perDay = ((steps / days) / steps) * 100;
            perDay = Math.Ceiling(perDay);

            double perDancer = perDay / dancers;

            if (perDay <= 13)
                Console.WriteLine($"Yes, they will succeed in that goal! {perDancer:f2}%.");
            else
                Console.WriteLine($"No, they will not succeed in that goal! Required {perDancer:f2}% steps to be learned per day.");

            






        }
    }
}
