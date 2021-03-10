using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double price = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);

            if (puzzles + dolls + bears + minions + trucks >= 50)
            {
                price = price - price * 0.25;
            }

            price = price - price * 0.10;

            if (price >= trip)
            {
                Console.WriteLine($"Yes! {price - trip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {trip - price:f2} lv needed.");
            }




        }
    }
}
