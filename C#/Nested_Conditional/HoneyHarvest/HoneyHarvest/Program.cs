using System;

namespace HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user fills the three variables for flower,
            // number of flowers and season
            string flower = Console.ReadLine();
            double flowerNum = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double honey = 0;    // this var will hold the number of honey

            if (season == "Spring")                // First we check if the season is Spring
            { 
                switch (flower)               // Then using a switch case, we cycle through each flower and calculate the honey for the flower, written by the user
                { 
                    case "Sunflower":
                        honey = 10 * flowerNum;
                        break;
                    case "Daisy":
                        honey = (12 * 1.10) * flowerNum;             //Daisy has a bonus of 10% during Spring
                        break;
                    case "Lavender":
                        honey = 12 * flowerNum;
                        break;
                    case "Mint":
                        honey = (10 * 1.10) * flowerNum;             // Mint has a bonus of 10% during Spring
                        break;
                    default:
                        break;
                }
            }
            else if (season == "Summer")      // If the season isn't Spring, we check if it's Summer
            {
                switch (flower)           //Then using a switch case, we cycle through the flowers and calculate the honey
                {
                    case "Sunflower":
                        honey = 8 * flowerNum;
                        break;
                    case "Daisy":
                        honey = 8 * flowerNum;
                        break;
                    case "Lavender":
                        honey = 8 * flowerNum;
                        break;
                    case "Mint":
                        honey = 12 * flowerNum;
                        break;
                    default:
                        break;
                }
                honey *= 1.10;        // During summer, the produced honey is 10% more
            }
            else if (season == "Autumn")    // Lastly if the season isn't Spring or Summer, we check if it's Autummn
            {
                switch (flower)            // Then using a switch case, we cycle through the flowers and calculate the honey
                {
                    case "Sunflower":
                        honey = 12 * flowerNum;
                        break;
                    case "Daisy":
                        honey = 6 * flowerNum;
                        break;
                    case "Lavender":
                        honey = 6 * flowerNum;
                        break;
                    case "Mint":
                        honey = 6 * flowerNum;
                        break;
                    default:
                        break;
                }
                honey *= 0.95;      // During Autumn, the produced honey is 5% less
            }

            // In the end we print out the total honey harvested
            Console.WriteLine($"Total honey harvested: {honey:f2}");
        }
    }
}
