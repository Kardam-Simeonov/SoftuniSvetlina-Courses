namespace PermutationsWithoutRepetitions
{
    internal class Program
    {
        static string[] input;
        static int k;
        static string[] permutations;
        static bool[] isUsed;

        static void Main(string[] args)
        {
            input = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
            permutations = new string[input.Length];
            isUsed = new bool[input.Length];

            GeneratePermutations(0);
        }

        private static void GeneratePermutations(int index)
        {
            if (index >= k)
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