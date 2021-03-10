using System;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int highestScore = int.MinValue;
            string winner = "";

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "STOP")
                    break;

                int currentSum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    currentSum += name[i];
                }
                if (currentSum > highestScore)
                {
                    highestScore = currentSum;
                    winner = name;
                }
            }
            Console.WriteLine($"Winner is {winner} - {highestScore}!");
        }
    }
}
