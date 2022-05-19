using System;

namespace WordGeneration
{
    internal class Program
    {
        static int numberOfLoops;
        static char[] vector;

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            numberOfLoops = input;

            vector = new char[numberOfLoops];

            VectorLoop(0);
        }

        static void VectorLoop(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                for (int i = 0; i < numberOfLoops; i++)
                    Console.Write($"{vector[i]}");

                Console.WriteLine();
                return;
            }

            for (int counter = 0; counter < numberOfLoops; counter++)
            {
                vector[currentLoop] = (char)(counter + 97);
                VectorLoop(currentLoop + 1);
            }
        }
    }
}
