using System;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameWins = 0;
            int gameLoses = 0;
            int gameDraws = 0;
            for (int i = 1; i <= 3; i++)
            {
                var result = Console.ReadLine();
                if (result[0] > result[2])
                    gameWins++;
                else if (result[0] < result[2])
                    gameLoses++;
                else if (result[0] == result[2])
                    gameDraws++;
            }

            Console.WriteLine($"Team won {gameWins} games.");
            Console.WriteLine($"Team lost {gameLoses} games.");
            Console.WriteLine($"Drawn games: {gameDraws}");

        }
    }
}
