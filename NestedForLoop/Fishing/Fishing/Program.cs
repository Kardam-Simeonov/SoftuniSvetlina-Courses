using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {

                int limit = int.Parse(Console.ReadLine());
                string input = "";
                double weight;
                int counter = 0;
                double sum = 0;
                double fishPrice;
                int fishes = 0;

                for (int i = 1; i <= limit; i++)
                {
                    input = Console.ReadLine();
                    if (input == "Stop")
                        break;

                    fishes++;
                    weight = double.Parse(Console.ReadLine());
                    fishPrice = 0;

                    for (int j = 0; j < input.Length; j++)
                    {
                        char symbol = input[j];
                        fishPrice += symbol;

                    }

                    counter++;
                    if (counter == 3)
                    {
                        sum += (fishPrice / weight);
                        counter = 0;
                    }
                    else if (counter < 3)
                        sum -= (fishPrice / weight);
                }

                if (input == "Stop")
                {
                    if (sum < 0)
                        Console.WriteLine($"Lyubo lost {Math.Abs(sum):f2} leva today.");
                    else
                        Console.WriteLine($"Lyubo's profit from {fishes} fishes is {sum:f2} leva.");
                }
                else
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    if (sum < 0)
                        Console.WriteLine($"Lyubo lost {Math.Abs(sum):f2} leva today.");
                    else
                        Console.WriteLine($"Lyubo's profit from {fishes} fishes is {sum:f2} leva.");
                }
        }
    }
}
