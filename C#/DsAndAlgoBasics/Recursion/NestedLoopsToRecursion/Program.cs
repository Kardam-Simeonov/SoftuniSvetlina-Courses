using System;

namespace NestedLoopsToRecursion
{
    internal class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            numberOfIterations = input;
            numberOfLoops = input;

            loops = new int[numberOfLoops];

            NestedLoops(0);
        }

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                for (int i = 0; i < numberOfLoops; i++)
                    Console.Write($"{loops[i]} ");

                Console.WriteLine();
                return;
            }

            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }
    }
}
