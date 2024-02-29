class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] previous = new int[numbers.Length];
        int[] length = new int[numbers.Length];

        (int bestLen, int lastIndex) = GetLongestSubsequence(numbers, previous, length);

        Console.WriteLine(PrintLongestSubsequence(lastIndex, numbers, previous));
    }

    private static (int bestLen, int lastIndex) GetLongestSubsequence(
        int[] numbers,
        int[] previous,
        int[] length)
    {
        int bestLen = 0;
        int lastIndex = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            previous[i] = -1;

            int currentNumber = numbers[i];
            int currentBestSequence = 1;

            for (int j = i - 1; j >= 0; j--)
            {
                int previousNumber = numbers[j];
                if (previousNumber < currentNumber
                    && length[j] + 1 >= currentBestSequence)
                {
                    currentBestSequence = length[j] + 1;
                    previous[i] = j;
                }
            }

            if (currentBestSequence > bestLen)
            {
                bestLen = currentBestSequence;
                lastIndex = i;
            }

            length[i] = currentBestSequence;
        }

        return (bestLen, lastIndex);
    }

    private static string PrintLongestSubsequence(int lastIndex, int[] numbers, int[] previous)
    {
        Stack<int> result = new Stack<int>();
        while (lastIndex != - 1)
        {
            result.Push(numbers[lastIndex]);
            lastIndex = previous[lastIndex];
        }

        return string.Join(" ", result);
    }
}