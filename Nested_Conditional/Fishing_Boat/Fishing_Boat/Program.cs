using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            double price = 0.00;

            if (season == "spring")
            {
                price = 3000;

                if (people <= 6)
                    price -= price * 0.10;
                else if (people > 7 && people <= 11)
                    price -= price * 0.15;
                else if (people > 12)
                    price -= price * 0.25;

                if (people % 2 == 0 && season != "autumn")
                    price -= price * 0.05;
            }


            else if (season == "summer" || season == "autumn")
            {
                price = 4200;

                if (people <= 6)
                    price -= price * 0.10;
                else if (people > 7 && people <= 11)
                    price -= price * 0.15;
                else if (people > 12)
                    price -= price * 0.25;

                if (people % 2 == 0 && season != "autumn")
                    price -= price * 0.05;
            }


            else if (season == "winter")
            {
                price = 2600;

                if (people <= 6)
                    price -= price * 0.10;
                else if (people > 7 && people <= 11)
                    price -= price * 0.15;
                else if (people > 12)
                    price -= price * 0.25;

                if (people % 2 == 0 && season != "autumn")
                    price -= price * 0.05;
            }
            if (budget >= price)
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - price):f2} leva.");
        }
    }
}
