using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer1 = Console.ReadLine(); string namePlayer2 = Console.ReadLine();

            double pointsPlayer1 = 0; double pointsPlayer2 = 0;

            while (true)
            {
                var movePlayer1 = Console.ReadLine();
                if (movePlayer1 == "End of the game")
                    break;
                else
                    Convert.ToDouble(movePlayer1);

                var movePlayer2 = Console.ReadLine();
                if (movePlayer2 == "End of the game")
                    break;
                else
                    Convert.ToDouble(movePlayer1);

                if (movePlayer1 > movePlayer2)
                    pointsPlayer1 += movePlayer1 - movePlayer2;

            }

        }
    }
}
