using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = int.Parse(Console.ReadLine());
            string vreme = Console.ReadLine();

            string a = "a";
            string b = "a";

            if (C <= 18)
            {
                switch (vreme)
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
            else if (18 <= C && C <= 24)
            {
                switch (vreme)
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
            else if (C >= 25)
            {
                switch (vreme)
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
            Console.WriteLine($"It's {C} degrees, get your {a} and {b}.");

        }
    }
}
