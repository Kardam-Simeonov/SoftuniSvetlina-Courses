using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string weather = Console.ReadLine();

            string a = "a";
            string b = "a";

            if (temperature <= 18)
            {
                switch (weather)
                {
                    case "Morning":
                        a = "Sweatshirt";
                        b = "Sneakers";
                        break;
                    case "Afternoon":
                        a = "Shirt";
                        b = "Moccasins";
                        break;
                    case "Evening":
                        a = "Shirt";
                        b = "Moccasins";
                        break;
                }
            }
            else if (18 <= temperature && temperature <= 24)
            {
                switch (weather)
                {
                    case "Morning":
                        a = "Shirt";
                        b = "Moccasins";
                        break;
                    case "Afternoon":
                        a = "T-Shirt";
                        b = "Sandals";
                        break;
                    case "Evening":
                        a = "Shirt";
                        b = "Moccasins";
                        break;
                }
            }
            else if (temperature >= 25)
            {
                switch (weather)
                {
                    case "Morning":
                        a = "T-Shirt";
                        b = "Sandals";
                        break;
                    case "Afternoon":
                        a = "Swim Suit";
                        b = "Barefoot";
                        break;
                    case "Evening":
                        a = "Shirt";
                        b = "Moccasins";
                        break;
                }

            }
            Console.WriteLine($"It's {temperature} degrees, get your {a} and {b}.");

        }
    }
}
