using System;

namespace TennisRankList
{
    class Program
    {
        static void Main(string[] args)
        {
            double tournnaments = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            double tournamentsWon = 0;
            double averagePoints = 0;

            for (int i = 1; i <= tournnaments; i++)
            {
                string position = Console.ReadLine();
                
                switch (position)
                {
                    case "W":
                        points += 2000;
                        averagePoints += 2000;
                        tournamentsWon++;
                        break;
                    case "F":
                        points += 1200;
                        averagePoints += 1200;
                        break;
                    case "SF":
                        points += 720;
                        averagePoints += 720;
                        break;
                    default:
                        break;
                }
            }
            averagePoints = (averagePoints / tournnaments);

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{((tournamentsWon / tournnaments) * 100):f2}%");
        }
    }
}
