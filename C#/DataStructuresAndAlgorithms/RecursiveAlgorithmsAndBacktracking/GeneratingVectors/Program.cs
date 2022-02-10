using System;

namespace GeneratingVectors
{
    internal class Program
    {
        static int numberOfLoops;
        static int[] loops;

        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            numberOfLoops = input;

            loops = new int[numberOfLoops];

            VectorLoop(0);
        }

        static void VectorLoop(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                for (int i = 0; i < numberOfLoops; i++)
                    Console.Write($"{loops[i]}");

                Console.WriteLine();
                return;
            }

            for (int counter = 0; counter <= 1; counter++)
            {
                loops[currentLoop] = counter;
                VectorLoop(currentLoop + 1);
            }
        }
    }
}
