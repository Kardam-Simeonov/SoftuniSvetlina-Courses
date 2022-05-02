using System;

namespace CombinationsWithoutRepetition
{
    internal class Program
    {
        static int numberOfLoops;
        static int numberOfRepetitions;
        static int[] loops;

        static void Main()
        {
            numberOfRepetitions = int.Parse(Console.ReadLine());
            numberOfLoops = int.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            GenerateCombinations(0, 1);
        }

        static void GenerateCombinations(int currentLoop, int startNum)
        {
            if (currentLoop == numberOfLoops)
            {
                for (int i = 0; i < numberOfLoops; i++)
                    Console.Write($"{loops[i]} ");

                Console.WriteLine();
                return;
            }

            for (int i = startNum; i <= numberOfRepetitions; i++)
            {
                loops[currentLoop] = i;
                GenerateCombinations(currentLoop + 1, i + 1);
            }
        }
    }
}
