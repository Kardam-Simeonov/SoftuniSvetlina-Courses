using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0.00;

            if (type == "Roses")
            {
                price = flowers * 5;

                if (flowers > 80)
                    price -= price * 0.10;
            }

            else if (type == "Dahlias")
            {
                price = flowers * 3.80;

                if (flowers > 90)
                    price -= price * 0.15;
            }

            else if (type == "Tulips")
            {
                price = flowers * 2.80;

                if (flowers > 80)
                    price -= price * 0.15;
            }

            else if (type == "Narcissus")   //
            {
                price = flowers * 3;

                if (flowers < 120)
                    price += price * 0.15;
            }

            else if (type == "Gladiolus")
            {
                price = flowers * 2.50;

                if (flowers < 80)
                    price += price * 0.20;
            }


            if (budget >= price)
                Console.WriteLine($"Hey, you have a great garden with {flowers} {type} and {budget - price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - price):f2} leva more.");



        }
    }
}
