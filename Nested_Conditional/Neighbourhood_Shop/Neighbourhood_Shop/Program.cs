using System;

namespace Neighbourhood_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(amount * 0.50);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(amount * 0.40);
                        break;
                    case "Varna":
                        Console.WriteLine(amount * 0.45);
                        break;
                }
            }

            if (product == "water")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(amount * 0.80);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(amount * 0.70);
                        break;
                    case "Varna":
                        Console.WriteLine(amount * 0.70);
                        break;
                }
            }

            if (product == "beer")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(amount * 1.20);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(amount * 1.15);
                        break;
                    case "Varna":
                        Console.WriteLine(amount * 1.10);
                        break;
                }
            }

            if (product == "sweets")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(amount * 1.45);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(amount * 1.30);
                        break;
                    case "Varna":
                        Console.WriteLine(amount * 1.35);
                        break;
                }
            }

            if (product == "peanuts")
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine(amount * 1.60);
                        break;
                    case "Plovdiv":
                        Console.WriteLine(amount * 1.50);
                        break;
                    case "Varna":
                        Console.WriteLine(amount * 1.55);
                        break;
                }
            }
        }
    }
}
