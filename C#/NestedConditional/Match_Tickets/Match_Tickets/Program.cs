using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());


            if (people >= 1 && people <= 4)
                budget -= budget * 0.75;
            else if (people >= 5 && people <= 9)
                budget -= budget * 0.60;
            else if (people >= 10 && people <= 24)
                budget -= budget * 0.50;
            else if (people >= 25 && people <= 49)
                budget -= budget * 0.40;
            else if (people >= 50)
                budget -= budget * 0.25;

            if (ticketType == "vip")
            {
                if (budget >= (499.99 * people))
                    Console.WriteLine($"Yes! You have {budget - (499.99 * people):f2} leva left.");
                else
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budget - (499.99 * people)):f2} leva.");
            }

            else if (ticketType == "normal")
            {
                if (budget >= (249.99 * people))
                    Console.WriteLine($"Yes! You have {budget - (249.99 * people):f2} leva left.");
                else
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budget - (249.99 * people)):f2} leva.");
            }


        }
    }
}
