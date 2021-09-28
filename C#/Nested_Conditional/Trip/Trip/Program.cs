using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget * 0.30:f2} ");
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget * 0.70:f2} ");
                }
            }

            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget * 0.40:f2} ");
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget * 0.80:f2} ");
                }
            }

            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget * 0.90:f2} ");
            }


        }
    }
}