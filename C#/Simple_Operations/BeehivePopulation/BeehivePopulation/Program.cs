using System;

namespace BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // the two variables for population and number of years, filled by the user
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            //we use a for loop to cycle through each year and calculate the population
            for (int i = 1; i <= years; i++)
            {
                population += population / 10 * 2;       //first we add the newborn bees

                if (i % 5 == 0)                                // then we check if it's a fifth year
                    population -= population / 50 * 5;          // in that case we calculate the migrated bees and change the population

                population -= population / 20 * 2;    //lastly we subtract the bees that died
            }

            //in the end we print out the population of the beehive
            Console.WriteLine($"Beehive population: {population}");
        }
    }
}
