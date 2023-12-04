namespace PermutationsWithoutRepetitions
{
    internal class Program
    {
        static string[] input;
        static string[] permutations;
        static bool[] isUsed;

        static void Main(string[] args)
        {
            input = Console.ReadLine().Split();
            permutations = new string[input.Length];
            isUsed = new bool[input.Length];

            GeneratePermutations(0);
        }

        private static void GeneratePermutations(int index)
        {
            if (index >= input.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            for (int currentIndex = 0; currentIndex < input.Length; currentIndex++)
            {
                if (!isUsed[currentIndex])
                {
                    isUsed[currentIndex] = true;
                    permutations[index] = input[currentIndex];
                    GeneratePermutations(index + 1);
                    isUsed[currentIndex] = false;
                }
            }
        }
    }
}