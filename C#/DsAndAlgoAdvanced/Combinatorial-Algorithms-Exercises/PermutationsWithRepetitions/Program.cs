namespace PermutationsWithRepetitions
{
    internal class Program
    {
        static string[] input;
        static string[] permutations;

        static void Main(string[] args)
        {
            input = Console.ReadLine().Split();
            permutations = new string[input.Length];

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
                permutations[index] = input[currentIndex];
                GeneratePermutations(index + 1);
            }
        }
    }
}