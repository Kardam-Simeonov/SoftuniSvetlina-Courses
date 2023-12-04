public class Program
{
    //Generates Combinations of positions in a set, based on NumberOfLoops vector
    static int numberOfLoops;
    static int numberOfRepetitions;
    static int[] loops;
    static int[] set;

    static void Main()
    {
        set = Console.ReadLine().Split().Select(int.Parse).ToArray();
        numberOfRepetitions = set.Length - 1;
        numberOfLoops = int.Parse(Console.ReadLine());

        loops = new int[numberOfLoops];

        GenerateCombinations(0, 0);
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
            loops[currentLoop] = set[i];
            GenerateCombinations(currentLoop + 1, i + 1);
        }
    }
}